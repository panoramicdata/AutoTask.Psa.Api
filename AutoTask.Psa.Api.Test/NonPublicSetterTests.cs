using System.Reflection;
using System.Text.Json;

namespace AutoTask.Psa.Api.Test;

/// <summary>
/// Tests for issue #51: System.Text.Json ignores non-public setters, so such properties are never populated.
/// </summary>
public class NonPublicSetterTests
{
	private static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.Web);

	[Fact]
	public void ThresholdStatusResultModel_PopulatedPayload_MapsAllValues()
	{
		const string json = """{"externalRequestThreshold":100,"requestThresholdTimeframe":60,"currentTimeframeRequestCount":42}""";

		var result = JsonSerializer.Deserialize<ThresholdStatusResultModel>(json, Options);

		_ = result.Should().NotBeNull();
		_ = result!.ExternalRequestThreshold.Should().Be(100);
		_ = result.RequestThresholdTimeframe.Should().Be(60);
		_ = result.CurrentTimeframeRequestCount.Should().Be(42);
	}

	[Fact]
	public void TicketAttachmentModel_PopulatedPayload_MapsBaseClassProperties()
	{
		const string json = """{"isTaskAttachment":true,"parentType":3}""";

		var result = JsonSerializer.Deserialize<TicketAttachmentModel>(json, Options);

		_ = result.Should().NotBeNull();
		_ = result!.IsTaskAttachment.Should().BeTrue();
		_ = result.ParentType.Should().Be(3);
	}

	[Fact]
	public void ContractServiceUnitModel_PopulatedPayload_MapsSoapParentPropertyId()
	{
		var result = JsonSerializer.Deserialize<ContractServiceUnitModel>("""{"soapParentPropertyId":7}""", Options);

		_ = result.Should().NotBeNull();
		_ = result!.SoapParentPropertyId.Should().Be(7);
	}

	[Fact]
	public void ParameterExpression_PopulatedPayload_MapsCanReduce()
	{
		var result = JsonSerializer.Deserialize<ParameterExpression>("""{"canReduce":true}""", Options);

		_ = result.Should().NotBeNull();
		_ = result!.CanReduce.Should().BeTrue();
	}

	[Fact]
	public void DataModels_DeclareNoPublicPropertyWithNonPublicSetter()
	{
		var offenders = typeof(ThresholdStatusResultModel).Assembly.GetTypes()
			.Where(t => t.IsPublic && t.Namespace == typeof(ThresholdStatusResultModel).Namespace)
			.SelectMany(t => t.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
			.Where(p => p.SetMethod is { IsPublic: false })
			.Select(p => $"{p.DeclaringType!.Name}.{p.Name}")
			.ToArray();

		_ = offenders.Should().BeEmpty();
	}
}
