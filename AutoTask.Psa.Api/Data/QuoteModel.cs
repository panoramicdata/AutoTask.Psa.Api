namespace AutoTask.Psa.Api.Data;

/// <summary>
/// QuoteModel
/// </summary>
[DataContract]
public class QuoteModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ApprovalStatus
	/// </summary>
	[DataMember(Name = "ApprovalStatus")]
	public int? ApprovalStatus { get; set; }

	/// <summary>
	/// Gets or Sets ApprovalStatusChangedByResourceID
	/// </summary>
	[DataMember(Name = "ApprovalStatusChangedByResourceID")]
	public int? ApprovalStatusChangedByResourceID { get; set; }

	/// <summary>
	/// Gets or Sets ApprovalStatusChangedDate
	/// </summary>
	[DataMember(Name = "ApprovalStatusChangedDate")]
	public DateTime? ApprovalStatusChangedDate { get; set; }

	/// <summary>
	/// Gets or Sets BillToLocationID
	/// </summary>
	[DataMember(Name = "BillToLocationID")]
	public int? BillToLocationID { get; set; }

	/// <summary>
	/// Gets or Sets CalculateTaxSeparately
	/// </summary>
	[DataMember(Name = "CalculateTaxSeparately")]
	public bool? CalculateTaxSeparately { get; set; }

	/// <summary>
	/// Gets or Sets Comment
	/// </summary>
	[DataMember(Name = "Comment")]
	public string Comment { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets ContactID
	/// </summary>
	[DataMember(Name = "ContactID")]
	public int? ContactID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDate
	/// </summary>
	[DataMember(Name = "CreateDate")]
	public DateTime? CreateDate { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public int? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets EffectiveDate
	/// </summary>
	[DataMember(Name = "EffectiveDate")]
	public DateTime? EffectiveDate { get; set; }

	/// <summary>
	/// Gets or Sets ExpirationDate
	/// </summary>
	[DataMember(Name = "ExpirationDate")]
	public DateTime? ExpirationDate { get; set; }

	/// <summary>
	/// Gets or Sets ExtApprovalContactResponse
	/// </summary>
	[DataMember(Name = "ExtApprovalContactResponse")]
	public int? ExtApprovalContactResponse { get; set; }

	/// <summary>
	/// Gets or Sets ExtApprovalResponseDate
	/// </summary>
	[DataMember(Name = "ExtApprovalResponseDate")]
	public DateTime? ExtApprovalResponseDate { get; set; }

	/// <summary>
	/// Gets or Sets ExtApprovalResponseSignature
	/// </summary>
	[DataMember(Name = "ExtApprovalResponseSignature")]
	public string ExtApprovalResponseSignature { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ExternalQuoteNumber
	/// </summary>
	[DataMember(Name = "ExternalQuoteNumber")]
	public string ExternalQuoteNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets GroupByID
	/// </summary>
	[DataMember(Name = "GroupByID")]
	public int? GroupByID { get; set; }

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets LastActivityDate
	/// </summary>
	[DataMember(Name = "LastActivityDate")]
	public DateTime? LastActivityDate { get; set; }

	/// <summary>
	/// Gets or Sets LastModifiedBy
	/// </summary>
	[DataMember(Name = "LastModifiedBy")]
	public int? LastModifiedBy { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets OpportunityID
	/// </summary>
	[DataMember(Name = "OpportunityID")]
	public int? OpportunityID { get; set; }

	/// <summary>
	/// Gets or Sets PaymentTerm
	/// </summary>
	[DataMember(Name = "PaymentTerm")]
	public int? PaymentTerm { get; set; }

	/// <summary>
	/// Gets or Sets PaymentType
	/// </summary>
	[DataMember(Name = "PaymentType")]
	public int? PaymentType { get; set; }

	/// <summary>
	/// Gets or Sets PrimaryQuote
	/// </summary>
	[DataMember(Name = "PrimaryQuote")]
	public bool? PrimaryQuote { get; set; }

	/// <summary>
	/// Gets or Sets ProposalProjectID
	/// </summary>
	[DataMember(Name = "ProposalProjectID")]
	public int? ProposalProjectID { get; set; }

	/// <summary>
	/// Gets or Sets PurchaseOrderNumber
	/// </summary>
	[DataMember(Name = "PurchaseOrderNumber")]
	public string PurchaseOrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets QuoteNumber
	/// </summary>
	[DataMember(Name = "QuoteNumber")]
	public int? QuoteNumber { get; set; }

	/// <summary>
	/// Gets or Sets QuoteTemplateID
	/// </summary>
	[DataMember(Name = "QuoteTemplateID")]
	public int? QuoteTemplateID { get; set; }

	/// <summary>
	/// Gets or Sets ShippingType
	/// </summary>
	[DataMember(Name = "ShippingType")]
	public int? ShippingType { get; set; }

	/// <summary>
	/// Gets or Sets ShipToLocationID
	/// </summary>
	[DataMember(Name = "ShipToLocationID")]
	public int? ShipToLocationID { get; set; }

	/// <summary>
	/// Gets or Sets ShowEachTaxInGroup
	/// </summary>
	[DataMember(Name = "ShowEachTaxInGroup")]
	public bool? ShowEachTaxInGroup { get; set; }

	/// <summary>
	/// Gets or Sets ShowTaxCategory
	/// </summary>
	[DataMember(Name = "ShowTaxCategory")]
	public bool? ShowTaxCategory { get; set; }

	/// <summary>
	/// Gets or Sets SoldToLocationID
	/// </summary>
	[DataMember(Name = "SoldToLocationID")]
	public int? SoldToLocationID { get; set; }

	/// <summary>
	/// Gets or Sets TaxRegionID
	/// </summary>
	[DataMember(Name = "TaxRegionID")]
	public int? TaxRegionID { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
