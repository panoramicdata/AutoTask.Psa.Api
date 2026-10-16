namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Represents a second-level organizational unit, combining identification,
/// display text, an active flag, a name and a collection of user-defined fields.
/// </summary>
[DataContract]
public sealed record OrganizationalLevel2Model
{
	/// <summary>
	/// Gets or sets the Id.
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; init; }

	/// <summary>
	/// Gets or sets the Description.
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; init; } = string.Empty;

	/// <summary>
	/// Gets or sets the IsActive.
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; init; }

	/// <summary>
	/// Gets or sets the Name.
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; init; } = string.Empty;

	/// <summary>
	/// Gets or sets the UserDefinedFields.
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; init; } = [];
}