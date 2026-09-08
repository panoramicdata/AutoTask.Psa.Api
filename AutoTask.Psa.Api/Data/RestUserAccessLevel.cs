namespace AutoTask.Psa.Api.Data;

/// <summary>
/// The calling user's permission for an action on an entity, as reported by the
/// entityInformation call.
/// </summary>
/// <remarks>
/// AutoTask documents these as the integers 0, 1 and 2, but the REST API sends the names as JSON
/// strings. <see cref="RestUserAccessLevelConverter"/> accepts either, and maps anything it does
/// not recognise to <see cref="Unknown"/> rather than failing the whole response.
/// </remarks>
[DataContract]
[JsonConverter(typeof(RestUserAccessLevelConverter))]
public enum RestUserAccessLevel
{
	/// <summary>
	/// A value this client does not recognise, such as one AutoTask added after this release.
	/// </summary>
	[EnumMember(Value = "Unknown")]
	Unknown = -1,

	/// <summary>
	/// The user can never perform the action, even where the entity itself allows it.
	/// </summary>
	[EnumMember(Value = "None")]
	None = 0,

	/// <summary>
	/// The user can always perform the action.
	/// </summary>
	[EnumMember(Value = "All")]
	All = 1,

	/// <summary>
	/// The user can perform the action under specific conditions.
	/// </summary>
	[EnumMember(Value = "Restricted")]
	Restricted = 2
}
