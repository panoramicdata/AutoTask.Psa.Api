using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// InvoiceTemplateModel
	/// </summary>
	[DataContract]
	public partial class InvoiceTemplateModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InvoiceTemplateModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CoveredByBlockRetainerContractLabel">CoveredByBlockRetainerContractLabel.</param>
		/// <param name="CoveredByRecurringServiceFixedPricePerTicketContractLabel">CoveredByRecurringServiceFixedPricePerTicketContractLabel.</param>
		/// <param name="CurrencyNegativeFormat">CurrencyNegativeFormat.</param>
		/// <param name="CurrencyPositiveFormat">CurrencyPositiveFormat.</param>
		/// <param name="DateFormat">DateFormat.</param>
		/// <param name="DisplayFixedPriceContractLabor">DisplayFixedPriceContractLabor.</param>
		/// <param name="DisplayRecurringServiceContractLabor">DisplayRecurringServiceContractLabor.</param>
		/// <param name="DisplaySeparateLineItemForEachTax">DisplaySeparateLineItemForEachTax.</param>
		/// <param name="DisplayTaxCategory">DisplayTaxCategory.</param>
		/// <param name="DisplayTaxCategorySuperscripts">DisplayTaxCategorySuperscripts.</param>
		/// <param name="DisplayZeroAmountRecurringServicesAndBundles">DisplayZeroAmountRecurringServicesAndBundles.</param>
		/// <param name="GroupBy">GroupBy.</param>
		/// <param name="ItemizeItemsInEachGroup">ItemizeItemsInEachGroup.</param>
		/// <param name="ItemizeServicesAndBundles">ItemizeServicesAndBundles.</param>
		/// <param name="Name">Name.</param>
		/// <param name="NonBillableLaborLabel">NonBillableLaborLabel.</param>
		/// <param name="NumberFormat">NumberFormat.</param>
		/// <param name="PageLayout">PageLayout.</param>
		/// <param name="PageNumberFormat">PageNumberFormat.</param>
		/// <param name="PaymentTerms">PaymentTerms.</param>
		/// <param name="RateCostExpression">RateCostExpression.</param>
		/// <param name="ShowGridHeader">ShowGridHeader.</param>
		/// <param name="ShowVerticalGridLines">ShowVerticalGridLines.</param>
		/// <param name="SortBy">SortBy.</param>
		/// <param name="TimeFormat">TimeFormat.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public InvoiceTemplateModel(long? Id = default, string CoveredByBlockRetainerContractLabel = default, string CoveredByRecurringServiceFixedPricePerTicketContractLabel = default, string CurrencyNegativeFormat = default, string CurrencyPositiveFormat = default, int? DateFormat = default, bool? DisplayFixedPriceContractLabor = default, bool? DisplayRecurringServiceContractLabor = default, bool? DisplaySeparateLineItemForEachTax = default, bool? DisplayTaxCategory = default, bool? DisplayTaxCategorySuperscripts = default, bool? DisplayZeroAmountRecurringServicesAndBundles = default, int? GroupBy = default, int? ItemizeItemsInEachGroup = default, bool? ItemizeServicesAndBundles = default, string Name = default, string NonBillableLaborLabel = default, int? NumberFormat = default, int? PageLayout = default, int? PageNumberFormat = default, int? PaymentTerms = default, string RateCostExpression = default, bool? ShowGridHeader = default, bool? ShowVerticalGridLines = default, int? SortBy = default, int? TimeFormat = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CoveredByBlockRetainerContractLabel = CoveredByBlockRetainerContractLabel;
			this.CoveredByRecurringServiceFixedPricePerTicketContractLabel = CoveredByRecurringServiceFixedPricePerTicketContractLabel;
			this.CurrencyNegativeFormat = CurrencyNegativeFormat;
			this.CurrencyPositiveFormat = CurrencyPositiveFormat;
			this.DateFormat = DateFormat;
			this.DisplayFixedPriceContractLabor = DisplayFixedPriceContractLabor;
			this.DisplayRecurringServiceContractLabor = DisplayRecurringServiceContractLabor;
			this.DisplaySeparateLineItemForEachTax = DisplaySeparateLineItemForEachTax;
			this.DisplayTaxCategory = DisplayTaxCategory;
			this.DisplayTaxCategorySuperscripts = DisplayTaxCategorySuperscripts;
			this.DisplayZeroAmountRecurringServicesAndBundles = DisplayZeroAmountRecurringServicesAndBundles;
			this.GroupBy = GroupBy;
			this.ItemizeItemsInEachGroup = ItemizeItemsInEachGroup;
			this.ItemizeServicesAndBundles = ItemizeServicesAndBundles;
			this.Name = Name;
			this.NonBillableLaborLabel = NonBillableLaborLabel;
			this.NumberFormat = NumberFormat;
			this.PageLayout = PageLayout;
			this.PageNumberFormat = PageNumberFormat;
			this.PaymentTerms = PaymentTerms;
			this.RateCostExpression = RateCostExpression;
			this.ShowGridHeader = ShowGridHeader;
			this.ShowVerticalGridLines = ShowVerticalGridLines;
			this.SortBy = SortBy;
			this.TimeFormat = TimeFormat;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CoveredByBlockRetainerContractLabel
		/// </summary>
		[DataMember(Name = "CoveredByBlockRetainerContractLabel", EmitDefaultValue = false)]
		public string CoveredByBlockRetainerContractLabel { get; set; }

		/// <summary>
		/// Gets or Sets CoveredByRecurringServiceFixedPricePerTicketContractLabel
		/// </summary>
		[DataMember(Name = "CoveredByRecurringServiceFixedPricePerTicketContractLabel", EmitDefaultValue = false)]
		public string CoveredByRecurringServiceFixedPricePerTicketContractLabel { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyNegativeFormat
		/// </summary>
		[DataMember(Name = "CurrencyNegativeFormat", EmitDefaultValue = false)]
		public string CurrencyNegativeFormat { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyPositiveFormat
		/// </summary>
		[DataMember(Name = "CurrencyPositiveFormat", EmitDefaultValue = false)]
		public string CurrencyPositiveFormat { get; set; }

		/// <summary>
		/// Gets or Sets DateFormat
		/// </summary>
		[DataMember(Name = "DateFormat", EmitDefaultValue = false)]
		public int? DateFormat { get; set; }

		/// <summary>
		/// Gets or Sets DisplayFixedPriceContractLabor
		/// </summary>
		[DataMember(Name = "DisplayFixedPriceContractLabor", EmitDefaultValue = false)]
		public bool? DisplayFixedPriceContractLabor { get; set; }

		/// <summary>
		/// Gets or Sets DisplayRecurringServiceContractLabor
		/// </summary>
		[DataMember(Name = "DisplayRecurringServiceContractLabor", EmitDefaultValue = false)]
		public bool? DisplayRecurringServiceContractLabor { get; set; }

		/// <summary>
		/// Gets or Sets DisplaySeparateLineItemForEachTax
		/// </summary>
		[DataMember(Name = "DisplaySeparateLineItemForEachTax", EmitDefaultValue = false)]
		public bool? DisplaySeparateLineItemForEachTax { get; set; }

		/// <summary>
		/// Gets or Sets DisplayTaxCategory
		/// </summary>
		[DataMember(Name = "DisplayTaxCategory", EmitDefaultValue = false)]
		public bool? DisplayTaxCategory { get; set; }

		/// <summary>
		/// Gets or Sets DisplayTaxCategorySuperscripts
		/// </summary>
		[DataMember(Name = "DisplayTaxCategorySuperscripts", EmitDefaultValue = false)]
		public bool? DisplayTaxCategorySuperscripts { get; set; }

		/// <summary>
		/// Gets or Sets DisplayZeroAmountRecurringServicesAndBundles
		/// </summary>
		[DataMember(Name = "DisplayZeroAmountRecurringServicesAndBundles", EmitDefaultValue = false)]
		public bool? DisplayZeroAmountRecurringServicesAndBundles { get; set; }

		/// <summary>
		/// Gets or Sets GroupBy
		/// </summary>
		[DataMember(Name = "GroupBy", EmitDefaultValue = false)]
		public int? GroupBy { get; set; }

		/// <summary>
		/// Gets or Sets ItemizeItemsInEachGroup
		/// </summary>
		[DataMember(Name = "ItemizeItemsInEachGroup", EmitDefaultValue = false)]
		public int? ItemizeItemsInEachGroup { get; set; }

		/// <summary>
		/// Gets or Sets ItemizeServicesAndBundles
		/// </summary>
		[DataMember(Name = "ItemizeServicesAndBundles", EmitDefaultValue = false)]
		public bool? ItemizeServicesAndBundles { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets NonBillableLaborLabel
		/// </summary>
		[DataMember(Name = "NonBillableLaborLabel", EmitDefaultValue = false)]
		public string NonBillableLaborLabel { get; set; }

		/// <summary>
		/// Gets or Sets NumberFormat
		/// </summary>
		[DataMember(Name = "NumberFormat", EmitDefaultValue = false)]
		public int? NumberFormat { get; set; }

		/// <summary>
		/// Gets or Sets PageLayout
		/// </summary>
		[DataMember(Name = "PageLayout", EmitDefaultValue = false)]
		public int? PageLayout { get; set; }

		/// <summary>
		/// Gets or Sets PageNumberFormat
		/// </summary>
		[DataMember(Name = "PageNumberFormat", EmitDefaultValue = false)]
		public int? PageNumberFormat { get; set; }

		/// <summary>
		/// Gets or Sets PaymentTerms
		/// </summary>
		[DataMember(Name = "PaymentTerms", EmitDefaultValue = false)]
		public int? PaymentTerms { get; set; }

		/// <summary>
		/// Gets or Sets RateCostExpression
		/// </summary>
		[DataMember(Name = "RateCostExpression", EmitDefaultValue = false)]
		public string RateCostExpression { get; set; }

		/// <summary>
		/// Gets or Sets ShowGridHeader
		/// </summary>
		[DataMember(Name = "ShowGridHeader", EmitDefaultValue = false)]
		public bool? ShowGridHeader { get; set; }

		/// <summary>
		/// Gets or Sets ShowVerticalGridLines
		/// </summary>
		[DataMember(Name = "ShowVerticalGridLines", EmitDefaultValue = false)]
		public bool? ShowVerticalGridLines { get; set; }

		/// <summary>
		/// Gets or Sets SortBy
		/// </summary>
		[DataMember(Name = "SortBy", EmitDefaultValue = false)]
		public int? SortBy { get; set; }

		/// <summary>
		/// Gets or Sets TimeFormat
		/// </summary>
		[DataMember(Name = "TimeFormat", EmitDefaultValue = false)]
		public int? TimeFormat { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
