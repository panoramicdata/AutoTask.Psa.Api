namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractExclusionSetExcludedRoleModel
/// </summary>
[DataContract]
public class ContractExclusionSetExcludedRoleModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ContractExclusionSetID
	/// </summary>
	[DataMember(Name = "ContractExclusionSetID")]
	public int? ContractExclusionSetID { get; set; }

	/// <summary>
	/// Gets or Sets ExcludedRoleID
	/// </summary>
	[DataMember(Name = "ExcludedRoleID")]
	public int? ExcludedRoleID { get; set; }
}
