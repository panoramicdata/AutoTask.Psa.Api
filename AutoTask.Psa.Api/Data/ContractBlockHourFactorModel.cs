namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractBlockHourFactorModel
/// </summary>
[DataContract]
public class ContractBlockHourFactorModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets BlockHourMultiplier
	/// </summary>
	[DataMember(Name = "BlockHourMultiplier")]
	public double? BlockHourMultiplier { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets RoleID
	/// </summary>
	[DataMember(Name = "RoleID")]
	public int? RoleID { get; set; }
}
