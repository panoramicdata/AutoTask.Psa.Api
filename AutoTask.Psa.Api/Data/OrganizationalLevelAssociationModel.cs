namespace AutoTask.Psa.Api.Data;

/// <summary>
/// OrganizationalLevelAssociationModel
/// </summary>
[DataContract]
public partial class OrganizationalLevelAssociationModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets OrganizationalLevel1ID
	/// </summary>
	[DataMember(Name = "OrganizationalLevel1ID")]
	public int? OrganizationalLevel1ID { get; set; }

	/// <summary>
	/// Gets or Sets OrganizationalLevel2ID
	/// </summary>
	[DataMember(Name = "OrganizationalLevel2ID")]
	public int? OrganizationalLevel2ID { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
