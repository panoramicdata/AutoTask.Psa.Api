namespace AutoTask.Psa.Api.Data;

/// <summary>
/// PriceListServiceModel
/// </summary>
[DataContract]
public class PriceListServiceModel : EntityModelBase
{
	/// <summary>
	/// Gets or Sets CurrencyID
	/// </summary>
	[DataMember(Name = "CurrencyID")]
	public int? CurrencyID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceID
	/// </summary>
	[DataMember(Name = "ServiceID")]
	public int? ServiceID { get; set; }

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
