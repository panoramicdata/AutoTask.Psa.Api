namespace AutoTask.Psa.Api.Data;

/// <summary>
/// PriceListProductTierModel
/// </summary>
[DataContract]
public class PriceListProductTierModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets CurrencyID
	/// </summary>
	[DataMember(Name = "CurrencyID")]
	public int? CurrencyID { get; set; }

	/// <summary>
	/// Gets or Sets ProductTierID
	/// </summary>
	[DataMember(Name = "ProductTierID")]
	public int? ProductTierID { get; set; }

	/// <summary>
	/// Gets or Sets UnitPrice
	/// </summary>
	[DataMember(Name = "UnitPrice")]
	public double? UnitPrice { get; set; }

	/// <summary>
	/// Gets or Sets UsesInternalCurrencyPrice
	/// </summary>
	[DataMember(Name = "UsesInternalCurrencyPrice")]
	public bool? UsesInternalCurrencyPrice { get; set; }
}
