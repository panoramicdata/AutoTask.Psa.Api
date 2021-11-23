namespace AutoTask.Psa.Api.Data;

/// <summary>
/// InvoiceTemplateModel
/// </summary>
[DataContract]
public partial class InvoiceTemplateModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets CoveredByBlockRetainerContractLabel
	/// </summary>
	[DataMember(Name = "CoveredByBlockRetainerContractLabel")]
	public string CoveredByBlockRetainerContractLabel { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CoveredByRecurringServiceFixedPricePerTicketContractLabel
	/// </summary>
	[DataMember(Name = "CoveredByRecurringServiceFixedPricePerTicketContractLabel")]
	public string CoveredByRecurringServiceFixedPricePerTicketContractLabel { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CurrencyNegativeFormat
	/// </summary>
	[DataMember(Name = "CurrencyNegativeFormat")]
	public string CurrencyNegativeFormat { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CurrencyPositiveFormat
	/// </summary>
	[DataMember(Name = "CurrencyPositiveFormat")]
	public string CurrencyPositiveFormat { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DateFormat
	/// </summary>
	[DataMember(Name = "DateFormat")]
	public int? DateFormat { get; set; }

	/// <summary>
	/// Gets or Sets DisplayFixedPriceContractLabor
	/// </summary>
	[DataMember(Name = "DisplayFixedPriceContractLabor")]
	public bool? DisplayFixedPriceContractLabor { get; set; }

	/// <summary>
	/// Gets or Sets DisplayRecurringServiceContractLabor
	/// </summary>
	[DataMember(Name = "DisplayRecurringServiceContractLabor")]
	public bool? DisplayRecurringServiceContractLabor { get; set; }

	/// <summary>
	/// Gets or Sets DisplaySeparateLineItemForEachTax
	/// </summary>
	[DataMember(Name = "DisplaySeparateLineItemForEachTax")]
	public bool? DisplaySeparateLineItemForEachTax { get; set; }

	/// <summary>
	/// Gets or Sets DisplayTaxCategory
	/// </summary>
	[DataMember(Name = "DisplayTaxCategory")]
	public bool? DisplayTaxCategory { get; set; }

	/// <summary>
	/// Gets or Sets DisplayTaxCategorySuperscripts
	/// </summary>
	[DataMember(Name = "DisplayTaxCategorySuperscripts")]
	public bool? DisplayTaxCategorySuperscripts { get; set; }

	/// <summary>
	/// Gets or Sets DisplayZeroAmountRecurringServicesAndBundles
	/// </summary>
	[DataMember(Name = "DisplayZeroAmountRecurringServicesAndBundles")]
	public bool? DisplayZeroAmountRecurringServicesAndBundles { get; set; }

	/// <summary>
	/// Gets or Sets GroupBy
	/// </summary>
	[DataMember(Name = "GroupBy")]
	public int? GroupBy { get; set; }

	/// <summary>
	/// Gets or Sets ItemizeItemsInEachGroup
	/// </summary>
	[DataMember(Name = "ItemizeItemsInEachGroup")]
	public int? ItemizeItemsInEachGroup { get; set; }

	/// <summary>
	/// Gets or Sets ItemizeServicesAndBundles
	/// </summary>
	[DataMember(Name = "ItemizeServicesAndBundles")]
	public bool? ItemizeServicesAndBundles { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets NonBillableLaborLabel
	/// </summary>
	[DataMember(Name = "NonBillableLaborLabel")]
	public string NonBillableLaborLabel { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets NumberFormat
	/// </summary>
	[DataMember(Name = "NumberFormat")]
	public int? NumberFormat { get; set; }

	/// <summary>
	/// Gets or Sets PageLayout
	/// </summary>
	[DataMember(Name = "PageLayout")]
	public int? PageLayout { get; set; }

	/// <summary>
	/// Gets or Sets PageNumberFormat
	/// </summary>
	[DataMember(Name = "PageNumberFormat")]
	public int? PageNumberFormat { get; set; }

	/// <summary>
	/// Gets or Sets PaymentTerms
	/// </summary>
	[DataMember(Name = "PaymentTerms")]
	public int? PaymentTerms { get; set; }

	/// <summary>
	/// Gets or Sets RateCostExpression
	/// </summary>
	[DataMember(Name = "RateCostExpression")]
	public string RateCostExpression { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ShowGridHeader
	/// </summary>
	[DataMember(Name = "ShowGridHeader")]
	public bool? ShowGridHeader { get; set; }

	/// <summary>
	/// Gets or Sets ShowVerticalGridLines
	/// </summary>
	[DataMember(Name = "ShowVerticalGridLines")]
	public bool? ShowVerticalGridLines { get; set; }

	/// <summary>
	/// Gets or Sets SortBy
	/// </summary>
	[DataMember(Name = "SortBy")]
	public int? SortBy { get; set; }

	/// <summary>
	/// Gets or Sets TimeFormat
	/// </summary>
	[DataMember(Name = "TimeFormat")]
	public int? TimeFormat { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
