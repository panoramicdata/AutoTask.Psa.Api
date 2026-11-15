namespace AutoTask.Psa.Api.Data;

/// <summary>
/// PriceListProductModel
/// </summary>
[DataContract]
public class PriceListProductModel : EntityModelBase
{
	/// <summary>
	/// Gets or Sets CurrencyID
	/// </summary>
	[DataMember(Name = "CurrencyID")]
	public int? CurrencyID { get; set; }

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }

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
