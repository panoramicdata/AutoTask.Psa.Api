namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractServiceBundleModel
/// </summary>
[DataContract]
public class ContractServiceBundleModel : ContractServicePriceModelBase
{
	/// <summary>
	/// Gets or Sets AdjustedPrice
	/// </summary>
	[DataMember(Name = "AdjustedPrice")]
	public double? AdjustedPrice { get; set; }

	/// <summary>
	/// Gets or Sets ServiceBundleID
	/// </summary>
	[DataMember(Name = "ServiceBundleID")]
	public int? ServiceBundleID { get; set; }
}
