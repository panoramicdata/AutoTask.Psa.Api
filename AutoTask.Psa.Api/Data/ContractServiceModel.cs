namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractServiceModel
/// </summary>
[DataContract]
public class ContractServiceModel : ContractServicePriceModelBase
{
	/// <summary>
	/// Gets or Sets ServiceID
	/// </summary>
	[DataMember(Name = "ServiceID")]
	public int? ServiceID { get; set; }

	/// <summary>
	/// Gets or Sets UnitCost
	/// </summary>
	[DataMember(Name = "UnitCost")]
	public double? UnitCost { get; set; }
}
