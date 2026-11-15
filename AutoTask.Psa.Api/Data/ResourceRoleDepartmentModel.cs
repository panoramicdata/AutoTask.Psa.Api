namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ResourceRoleDepartmentModel
/// </summary>
[DataContract]
public class ResourceRoleDepartmentModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets DepartmentID
	/// </summary>
	[DataMember(Name = "DepartmentID")]
	public int? DepartmentID { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets IsDefault
	/// </summary>
	[DataMember(Name = "IsDefault")]
	public bool? IsDefault { get; set; }

	/// <summary>
	/// Gets or Sets IsDepartmentLead
	/// </summary>
	[DataMember(Name = "IsDepartmentLead")]
	public bool? IsDepartmentLead { get; set; }

	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public int? ResourceID { get; set; }

	/// <summary>
	/// Gets or Sets RoleID
	/// </summary>
	[DataMember(Name = "RoleID")]
	public int? RoleID { get; set; }
}
