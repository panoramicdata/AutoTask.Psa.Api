namespace AutoTask.Psa.Api.Data;

/// <summary>
/// OrganizationalLevel1Model
/// </summary>
[DataContract]
public class OrganizationalLevel1Model
{
	/// <summary>Gets or sets Id.</summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>Gets or sets Description.</summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>Gets or sets IsActive.</summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>Gets or sets Name.</summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>Gets or sets UserDefinedFields.</summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
