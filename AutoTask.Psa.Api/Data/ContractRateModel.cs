namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractRateModel
/// </summary>
[DataContract]
public class ContractRateModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ContractHourlyRate
	/// </summary>
	[DataMember(Name = "ContractHourlyRate")]
	public double? ContractHourlyRate { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyContractHourlyRate
	/// </summary>
	[DataMember(Name = "InternalCurrencyContractHourlyRate")]
	public double? InternalCurrencyContractHourlyRate { get; set; }

	/// <summary>
	/// Gets or Sets RoleID
	/// </summary>
	[DataMember(Name = "RoleID")]
	public int? RoleID { get; set; }
}
