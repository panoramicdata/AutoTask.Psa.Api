namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CompanyModel
/// </summary>
[DataContract]
public class CompanyModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AdditionalAddressInformation
	/// </summary>
	[DataMember(Name = "AdditionalAddressInformation")]
	public string AdditionalAddressInformation { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Address1
	/// </summary>
	[DataMember(Name = "Address1")]
	public string Address1 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Address2
	/// </summary>
	[DataMember(Name = "Address2")]
	public string Address2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets AlternatePhone1
	/// </summary>
	[DataMember(Name = "AlternatePhone1")]
	public string AlternatePhone1 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets AlternatePhone2
	/// </summary>
	[DataMember(Name = "AlternatePhone2")]
	public string AlternatePhone2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ApiVendorID
	/// </summary>
	[DataMember(Name = "ApiVendorID")]
	public int? ApiVendorID { get; set; }

	/// <summary>
	/// Gets or Sets AssetValue
	/// </summary>
	[DataMember(Name = "AssetValue")]
	public double? AssetValue { get; set; }

	/// <summary>
	/// Gets or Sets BillToCompanyLocationID
	/// </summary>
	[DataMember(Name = "BillToCompanyLocationID")]
	public int? BillToCompanyLocationID { get; set; }

	/// <summary>
	/// Gets or Sets BillToAdditionalAddressInformation
	/// </summary>
	[DataMember(Name = "BillToAdditionalAddressInformation")]
	public string BillToAdditionalAddressInformation { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets BillingAddress1
	/// </summary>
	[DataMember(Name = "BillingAddress1")]
	public string BillingAddress1 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets BillingAddress2
	/// </summary>
	[DataMember(Name = "BillingAddress2")]
	public string BillingAddress2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets BillToAddressToUse
	/// </summary>
	[DataMember(Name = "BillToAddressToUse")]
	public int? BillToAddressToUse { get; set; }

	/// <summary>
	/// Gets or Sets BillToAttention
	/// </summary>
	[DataMember(Name = "BillToAttention")]
	public string BillToAttention { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets BillToCity
	/// </summary>
	[DataMember(Name = "BillToCity")]
	public string BillToCity { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets BillToCountryID
	/// </summary>
	[DataMember(Name = "BillToCountryID")]
	public int? BillToCountryID { get; set; }

	/// <summary>
	/// Gets or Sets BillToState
	/// </summary>
	[DataMember(Name = "BillToState")]
	public string BillToState { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets BillToZipCode
	/// </summary>
	[DataMember(Name = "BillToZipCode")]
	public string BillToZipCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets City
	/// </summary>
	[DataMember(Name = "City")]
	public string City { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Classification
	/// </summary>
	[DataMember(Name = "Classification")]
	public int? Classification { get; set; }

	/// <summary>
	/// Gets or Sets CompanyName
	/// </summary>
	[DataMember(Name = "CompanyName")]
	public string CompanyName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CompanyNumber
	/// </summary>
	[DataMember(Name = "CompanyNumber")]
	public string CompanyNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CompanyType
	/// </summary>
	[DataMember(Name = "CompanyType")]
	public int? CompanyType { get; set; }

	/// <summary>
	/// Gets or Sets CompetitorID
	/// </summary>
	[DataMember(Name = "CompetitorID")]
	public int? CompetitorID { get; set; }

	/// <summary>
	/// Gets or Sets CountryID
	/// </summary>
	[DataMember(Name = "CountryID")]
	public int? CountryID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDate
	/// </summary>
	[DataMember(Name = "CreateDate")]
	public DateTime? CreateDate { get; set; }

	/// <summary>
	/// Gets or Sets CreatedByResourceID
	/// </summary>
	[DataMember(Name = "CreatedByResourceID")]
	public int? CreatedByResourceID { get; set; }

	/// <summary>
	/// Gets or Sets CurrencyID
	/// </summary>
	[DataMember(Name = "CurrencyID")]
	public int? CurrencyID { get; set; }

	/// <summary>
	/// Gets or Sets Fax
	/// </summary>
	[DataMember(Name = "Fax")]
	public string Fax { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets InvoiceEmailMessageID
	/// </summary>
	[DataMember(Name = "InvoiceEmailMessageID")]
	public int? InvoiceEmailMessageID { get; set; }

	/// <summary>
	/// Gets or Sets InvoiceMethod
	/// </summary>
	[DataMember(Name = "InvoiceMethod")]
	public int? InvoiceMethod { get; set; }

	/// <summary>
	/// Gets or Sets InvoiceNonContractItemsToParentCompany
	/// </summary>
	[DataMember(Name = "InvoiceNonContractItemsToParentCompany")]
	public bool? InvoiceNonContractItemsToParentCompany { get; set; }

	/// <summary>
	/// Gets or Sets InvoiceTemplateID
	/// </summary>
	[DataMember(Name = "InvoiceTemplateID")]
	public int? InvoiceTemplateID { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets IsClientPortalActive
	/// </summary>
	[DataMember(Name = "IsClientPortalActive")]
	public bool? IsClientPortalActive { get; set; }

	/// <summary>
	/// Gets or Sets IsEnabledForComanaged
	/// </summary>
	[DataMember(Name = "IsEnabledForComanaged")]
	public bool? IsEnabledForComanaged { get; set; }

	/// <summary>
	/// Gets or Sets IsTaskFireActive
	/// </summary>
	[DataMember(Name = "IsTaskFireActive")]
	public bool? IsTaskFireActive { get; set; }

	/// <summary>
	/// Gets or Sets IsTaxExempt
	/// </summary>
	[DataMember(Name = "IsTaxExempt")]
	public bool? IsTaxExempt { get; set; }

	/// <summary>
	/// Gets or Sets LastActivityDate
	/// </summary>
	[DataMember(Name = "LastActivityDate")]
	public DateTime? LastActivityDate { get; set; }

	/// <summary>
	/// Gets or Sets LastTrackedModifiedDateTime
	/// </summary>
	[DataMember(Name = "LastTrackedModifiedDateTime")]
	public DateTime? LastTrackedModifiedDateTime { get; set; }

	/// <summary>
	/// Gets or Sets MarketSegmentID
	/// </summary>
	[DataMember(Name = "MarketSegmentID")]
	public int? MarketSegmentID { get; set; }

	/// <summary>
	/// Gets or Sets OwnerResourceID
	/// </summary>
	[DataMember(Name = "OwnerResourceID")]
	public int? OwnerResourceID { get; set; }

	/// <summary>
	/// Gets or Sets ParentCompanyID
	/// </summary>
	[DataMember(Name = "ParentCompanyID")]
	public int? ParentCompanyID { get; set; }

	/// <summary>
	/// Gets or Sets Phone
	/// </summary>
	[DataMember(Name = "Phone")]
	public string Phone { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets PostalCode
	/// </summary>
	[DataMember(Name = "PostalCode")]
	public string PostalCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets QuoteEmailMessageID
	/// </summary>
	[DataMember(Name = "QuoteEmailMessageID")]
	public int? QuoteEmailMessageID { get; set; }

	/// <summary>
	/// Gets or Sets QuoteTemplateID
	/// </summary>
	[DataMember(Name = "QuoteTemplateID")]
	public int? QuoteTemplateID { get; set; }

	/// <summary>
	/// Gets or Sets SICCode
	/// </summary>
	[DataMember(Name = "SICCode")]
	public string SICCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets State
	/// </summary>
	[DataMember(Name = "State")]
	public string State { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets StockMarket
	/// </summary>
	[DataMember(Name = "StockMarket")]
	public string StockMarket { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets StockSymbol
	/// </summary>
	[DataMember(Name = "StockSymbol")]
	public string StockSymbol { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SurveyCompanyRating
	/// </summary>
	[DataMember(Name = "SurveyCompanyRating")]
	public double? SurveyCompanyRating { get; set; }

	/// <summary>
	/// Gets or Sets TaxID
	/// </summary>
	[DataMember(Name = "TaxID")]
	public string TaxID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TaxRegionID
	/// </summary>
	[DataMember(Name = "TaxRegionID")]
	public int? TaxRegionID { get; set; }

	/// <summary>
	/// Gets or Sets TerritoryID
	/// </summary>
	[DataMember(Name = "TerritoryID")]
	public int? TerritoryID { get; set; }

	/// <summary>
	/// Gets or Sets WebAddress
	/// </summary>
	[DataMember(Name = "WebAddress")]
	public string WebAddress { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
