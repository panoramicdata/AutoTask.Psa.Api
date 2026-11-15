namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Properties common to the contract service and contract service bundle entities.
/// </summary>
[DataContract]
public abstract class ContractServicePriceModelBase : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyAdjustedPrice
	/// </summary>
	[DataMember(Name = "InternalCurrencyAdjustedPrice")]
	public double? InternalCurrencyAdjustedPrice { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyUnitPrice
	/// </summary>
	[DataMember(Name = "InternalCurrencyUnitPrice")]
	public double? InternalCurrencyUnitPrice { get; set; }

	/// <summary>
	/// Gets or Sets InternalDescription
	/// </summary>
	[DataMember(Name = "InternalDescription")]
	public string InternalDescription { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets InvoiceDescription
	/// </summary>
	[DataMember(Name = "InvoiceDescription")]
	public string InvoiceDescription { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets QuoteItemID
	/// </summary>
	[DataMember(Name = "QuoteItemID")]
	public long? QuoteItemID { get; set; }

	/// <summary>
	/// Gets or Sets UnitPrice
	/// </summary>
	[DataMember(Name = "UnitPrice")]
	public double? UnitPrice { get; set; }
}
