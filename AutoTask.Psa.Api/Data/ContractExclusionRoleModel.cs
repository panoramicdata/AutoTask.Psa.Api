namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractExclusionRoleModel
/// </summary>
[DataContract]
public class ContractExclusionRoleModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public long? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets RoleID
	/// </summary>
	[DataMember(Name = "RoleID")]
	public long? RoleID { get; set; }
}
