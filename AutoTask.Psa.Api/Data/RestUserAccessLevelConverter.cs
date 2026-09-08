using System.Text.Json;
using System.Text.Json.Serialization;

namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Reads <see cref="RestUserAccessLevel"/> from either the name AutoTask sends ("None", "All",
/// "Restricted") or the number it documents (0, 1, 2), and writes it back as the name.
/// </summary>
/// <remarks>
/// Anything unrecognised - a null, a value added to the API after this release - becomes
/// <see cref="RestUserAccessLevel.Unknown"/>. One unfamiliar access level should not cost the
/// caller the entire entityInformation response, which is what happened before this converter
/// existed.
/// </remarks>
public sealed class RestUserAccessLevelConverter : JsonConverter<RestUserAccessLevel>
{
	/// <inheritdoc />
	public override RestUserAccessLevel Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options)
		=> reader.TokenType switch
		{
			JsonTokenType.String => FromName(reader.GetString()),
			JsonTokenType.Number => FromNumber(ref reader),
			_ => RestUserAccessLevel.Unknown
		};

	/// <inheritdoc />
	public override void Write(
		Utf8JsonWriter writer,
		RestUserAccessLevel value,
		JsonSerializerOptions options)
	{
		ArgumentNullException.ThrowIfNull(writer);

		writer.WriteStringValue(value.ToString());
	}

	private static RestUserAccessLevel FromName(string? name)
		=> Enum.TryParse<RestUserAccessLevel>(name, ignoreCase: true, out var parsed) && IsDefined(parsed)
			? parsed
			: RestUserAccessLevel.Unknown;

	private static RestUserAccessLevel FromNumber(ref Utf8JsonReader reader)
		=> reader.TryGetInt32(out var number) && IsDefined((RestUserAccessLevel)number)
			? (RestUserAccessLevel)number
			: RestUserAccessLevel.Unknown;

	private static bool IsDefined(RestUserAccessLevel value)
		=> Enum.IsDefined(value);
}
