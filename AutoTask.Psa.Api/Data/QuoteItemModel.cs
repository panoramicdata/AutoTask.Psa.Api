namespace AutoTask.Psa.Api.Data;

/// <summary>
/// QuoteItemModel
/// </summary>
[DataContract]
public class QuoteItemModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AverageCost
	/// </summary>
	[DataMember(Name = "AverageCost")]
	public double? AverageCost { get; set; }

	/// <summary>
	/// Gets or Sets ChargeID
	/// </summary>
	[DataMember(Name = "ChargeID")]
	public int? ChargeID { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ExpenseID
	/// </summary>
	[DataMember(Name = "ExpenseID")]
	public int? ExpenseID { get; set; }

	/// <summary>
	/// Gets or Sets HighestCost
	/// </summary>
	[DataMember(Name = "HighestCost")]
	public double? HighestCost { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyLineDiscount
	/// </summary>
	[DataMember(Name = "InternalCurrencyLineDiscount")]
	public double? InternalCurrencyLineDiscount { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyUnitDiscount
	/// </summary>
	[DataMember(Name = "InternalCurrencyUnitDiscount")]
	public double? InternalCurrencyUnitDiscount { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyUnitPrice
	/// </summary>
	[DataMember(Name = "InternalCurrencyUnitPrice")]
	public double? InternalCurrencyUnitPrice { get; set; }

	/// <summary>
	/// Gets or Sets IsOptional
	/// </summary>
	[DataMember(Name = "IsOptional")]
	public bool? IsOptional { get; set; }

	/// <summary>
	/// Gets or Sets IsTaxable
	/// </summary>
	[DataMember(Name = "IsTaxable")]
	public bool? IsTaxable { get; set; }

	/// <summary>
	/// Gets or Sets LaborID
	/// </summary>
	[DataMember(Name = "LaborID")]
	public int? LaborID { get; set; }

	/// <summary>
	/// Gets or Sets LineDiscount
	/// </summary>
	[DataMember(Name = "LineDiscount")]
	public double? LineDiscount { get; set; }

	/// <summary>
	/// Gets or Sets MarkupRate
	/// </summary>
	[DataMember(Name = "MarkupRate")]
	public double? MarkupRate { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets PercentageDiscount
	/// </summary>
	[DataMember(Name = "PercentageDiscount")]
	public double? PercentageDiscount { get; set; }

	/// <summary>
	/// Gets or Sets PeriodType
	/// </summary>
	[DataMember(Name = "PeriodType")]
	public int? PeriodType { get; set; }

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets Quantity
	/// </summary>
	[DataMember(Name = "Quantity")]
	public double? Quantity { get; set; }

	/// <summary>
	/// Gets or Sets QuoteID
	/// </summary>
	[DataMember(Name = "QuoteID")]
	public int? QuoteID { get; set; }

	/// <summary>
	/// Gets or Sets QuoteItemType
	/// </summary>
	[DataMember(Name = "QuoteItemType")]
	public int? QuoteItemType { get; set; }

	/// <summary>
	/// Gets or Sets ServiceBundleID
	/// </summary>
	[DataMember(Name = "ServiceBundleID")]
	public int? ServiceBundleID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceID
	/// </summary>
	[DataMember(Name = "ServiceID")]
	public int? ServiceID { get; set; }

	/// <summary>
	/// Gets or Sets ShippingID
	/// </summary>
	[DataMember(Name = "ShippingID")]
	public int? ShippingID { get; set; }

	/// <summary>
	/// Gets or Sets TaxCategoryID
	/// </summary>
	[DataMember(Name = "TaxCategoryID")]
	public int? TaxCategoryID { get; set; }

	/// <summary>
	/// Gets or Sets TotalEffectiveTax
	/// </summary>
	[DataMember(Name = "TotalEffectiveTax")]
	public double? TotalEffectiveTax { get; set; }

	/// <summary>
	/// Gets or Sets UnitCost
	/// </summary>
	[DataMember(Name = "UnitCost")]
	public double? UnitCost { get; set; }

	/// <summary>
	/// Gets or Sets UnitDiscount
	/// </summary>
	[DataMember(Name = "UnitDiscount")]
	public double? UnitDiscount { get; set; }

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
