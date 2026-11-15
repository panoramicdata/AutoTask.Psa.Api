namespace AutoTask.Psa.Api.Data;

/// <summary>
/// BillingCodeModel
/// </summary>
[DataContract]
public class BillingCodeModel : DescribedNamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets AfterHoursWorkType
	/// </summary>
	[DataMember(Name = "AfterHoursWorkType")]
	public int? AfterHoursWorkType { get; set; }

	/// <summary>
	/// Gets or Sets BillingCodeType
	/// </summary>
	[DataMember(Name = "BillingCodeType")]
	public int? BillingCodeType { get; set; }

	/// <summary>
	/// Gets or Sets Department
	/// </summary>
	[DataMember(Name = "Department")]
	public int? Department { get; set; }

	/// <summary>
	/// Gets or Sets ExternalNumber
	/// </summary>
	[DataMember(Name = "ExternalNumber")]
	public string ExternalNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets GeneralLedgerAccount
	/// </summary>
	[DataMember(Name = "GeneralLedgerAccount")]
	public int? GeneralLedgerAccount { get; set; }

	/// <summary>
	/// Gets or Sets IsExcludedFromNewContracts
	/// </summary>
	[DataMember(Name = "IsExcludedFromNewContracts")]
	public bool? IsExcludedFromNewContracts { get; set; }

	/// <summary>
	/// Gets or Sets MarkupRate
	/// </summary>
	[DataMember(Name = "MarkupRate")]
	public double? MarkupRate { get; set; }

	/// <summary>
	/// Gets or Sets TaxCategoryID
	/// </summary>
	[DataMember(Name = "TaxCategoryID")]
	public int? TaxCategoryID { get; set; }

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
	/// Gets or Sets UseType
	/// </summary>
	[DataMember(Name = "UseType")]
	public int? UseType { get; set; }
}
