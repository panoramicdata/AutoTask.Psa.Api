namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractRoleCostModel
/// </summary>
[DataContract]
public class ContractRoleCostModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets Rate
	/// </summary>
	[DataMember(Name = "Rate")]
	public double? Rate { get; set; }

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
