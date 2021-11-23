namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractServiceModel
/// </summary>
[DataContract]
public partial class ContractServiceModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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
	/// Gets or Sets ServiceID
	/// </summary>
	[DataMember(Name = "ServiceID")]
	public int? ServiceID { get; set; }

	/// <summary>
	/// Gets or Sets UnitCost
	/// </summary>
	[DataMember(Name = "UnitCost")]
	public double? UnitCost { get; set; }

	/// <summary>
	/// Gets or Sets UnitPrice
	/// </summary>
	[DataMember(Name = "UnitPrice")]
	public double? UnitPrice { get; set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
