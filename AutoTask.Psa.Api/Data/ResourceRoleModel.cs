namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ResourceRoleModel
/// </summary>
[DataContract]
public class ResourceRoleModel : EntityModelBase
{
	/// <summary>
	/// Gets or Sets DepartmentID
	/// </summary>
	[DataMember(Name = "DepartmentID")]
	public long? DepartmentID { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets QueueID
	/// </summary>
	[DataMember(Name = "QueueID")]
	public long? QueueID { get; set; }

	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public long? ResourceID { get; set; }

	/// <summary>
	/// Gets or Sets RoleID
	/// </summary>
	[DataMember(Name = "RoleID")]
	public long? RoleID { get; set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public long? SoapParentPropertyId { get; set; }
}
