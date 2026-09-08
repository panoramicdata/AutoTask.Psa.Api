using System.Text.Json;

namespace AutoTask.Psa.Api.Test;

/// <summary>
/// Tests for deserialising the entityInformation response (issue #2).
///
/// <para>
/// AutoTask documents userAccessForCreate and its siblings as integers - 0 None, 1 All,
/// 2 Restricted - but the API returns them as the string names. RestUserAccessLevel had no members
/// at all, so every one of those strings failed and GetEntityInfoAsync threw for every entity.
/// </para>
/// </summary>
public class EntityInformationDeserializationTests
{
	/// <summary>
	/// Refit's defaults, so these tests deserialise exactly as the client does.
	/// </summary>
	private static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.Web);

	/// <summary>
	/// The shape AutoTask actually returns, taken from the entityInformation documentation.
	/// </summary>
	private const string RealWorldResponse = """
		{"info":{"name":"Companies","canCreate":true,"canDelete":false,"canQuery":true,
		"canUpdate":true,"userAccessForCreate":"All","userAccessForDelete":"None",
		"userAccessForQuery":"Restricted","userAccessForUpdate":"All",
		"hasUserDefinedFields":true,"supportsWebhookCallouts":true}}
		""";

	[Fact]
	public void EntityInformationResult_AsTheApiReturnsIt_Deserialises()
	{
		var result = JsonSerializer.Deserialize<EntityInformationResultModel>(RealWorldResponse, Options);

		result.Should().NotBeNull();
		result!.Info.Should().NotBeNull();
		result.Info!.Name.Should().Be("Companies");
		result.Info.CanCreate.Should().BeTrue();
		result.Info.CanDelete.Should().BeFalse();
	}

	[Fact]
	public void EntityInformationResult_EveryUserAccessLevel_IsBound()
	{
		var result = JsonSerializer.Deserialize<EntityInformationResultModel>(RealWorldResponse, Options);

		var info = result!.Info!;
		info.UserAccessForCreate.Should().Be(RestUserAccessLevel.All);
		info.UserAccessForDelete.Should().Be(RestUserAccessLevel.None);
		info.UserAccessForQuery.Should().Be(RestUserAccessLevel.Restricted);
		info.UserAccessForUpdate.Should().Be(RestUserAccessLevel.All);
	}

	[Theory]
	[InlineData("None", RestUserAccessLevel.None)]
	[InlineData("All", RestUserAccessLevel.All)]
	[InlineData("Restricted", RestUserAccessLevel.Restricted)]
	public void UserAccessLevel_DocumentedName_Deserialises(string name, RestUserAccessLevel expected)
		=> JsonSerializer.Deserialize<RestUserAccessLevel>($"\"{name}\"", Options).Should().Be(expected);

	[Theory]
	[InlineData("none", RestUserAccessLevel.None)]
	[InlineData("ALL", RestUserAccessLevel.All)]
	[InlineData("restricted", RestUserAccessLevel.Restricted)]
	public void UserAccessLevel_NameInAnyCasing_Deserialises(string name, RestUserAccessLevel expected)
		=> JsonSerializer.Deserialize<RestUserAccessLevel>($"\"{name}\"", Options).Should().Be(expected);

	[Theory]
	[InlineData("0", RestUserAccessLevel.None)]
	[InlineData("1", RestUserAccessLevel.All)]
	[InlineData("2", RestUserAccessLevel.Restricted)]
	public void UserAccessLevel_DocumentedNumber_Deserialises(string number, RestUserAccessLevel expected)
		=> JsonSerializer.Deserialize<RestUserAccessLevel>(number, Options).Should().Be(expected);

	[Theory]
	[InlineData("\"SomethingAutotaskAddedLater\"")]
	[InlineData("\"\"")]
	[InlineData("99")]
	[InlineData("null")]
	public void UserAccessLevel_UnrecognisedValue_IsUnknownRatherThanThrowing(string json)
	{
		var act = () => JsonSerializer.Deserialize<RestUserAccessLevel>(json, Options);

		act.Should().NotThrow(because: "a value this client does not know must not break the whole response");
		act().Should().Be(RestUserAccessLevel.Unknown);
	}

	[Fact]
	public void UserAccessLevel_RoundTrips_AsItsName()
	{
		var json = JsonSerializer.Serialize(RestUserAccessLevel.Restricted, Options);

		json.Should().Be("\"Restricted\"");
		JsonSerializer.Deserialize<RestUserAccessLevel>(json, Options).Should().Be(RestUserAccessLevel.Restricted);
	}

	[Fact]
	public void UserAccessLevel_Default_IsNone()
		=> default(RestUserAccessLevel).Should().Be(RestUserAccessLevel.None, because: "no access is the safe default");
}
