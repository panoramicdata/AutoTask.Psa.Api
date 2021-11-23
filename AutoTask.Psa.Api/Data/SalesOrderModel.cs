namespace AutoTask.Psa.Api.Data;

/// <summary>
/// SalesOrderModel
/// </summary>
[DataContract]
public partial class SalesOrderModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AdditionalBillToAddressInformation
	/// </summary>
	[DataMember(Name = "AdditionalBillToAddressInformation")]
	public string AdditionalBillToAddressInformation { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets AdditionalShipToAddressInformation
	/// </summary>
	[DataMember(Name = "AdditionalShipToAddressInformation")]
	public string AdditionalShipToAddressInformation { get; set; } = string.Empty;

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
	/// Gets or Sets BillToPostalCode
	/// </summary>
	[DataMember(Name = "BillToPostalCode")]
	public string BillToPostalCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets BillToState
	/// </summary>
	[DataMember(Name = "BillToState")]
	public string BillToState { get; set; } = string.Empty;

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
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets OpportunityID
	/// </summary>
	[DataMember(Name = "OpportunityID")]
	public int? OpportunityID { get; set; }

	/// <summary>
	/// Gets or Sets OrganizationalLevelAssociationID
	/// </summary>
	[DataMember(Name = "OrganizationalLevelAssociationID")]
	public int? OrganizationalLevelAssociationID { get; set; }

	/// <summary>
	/// Gets or Sets OwnerResourceID
	/// </summary>
	[DataMember(Name = "OwnerResourceID")]
	public int? OwnerResourceID { get; set; }

	/// <summary>
	/// Gets or Sets PromisedFulfillmentDate
	/// </summary>
	[DataMember(Name = "PromisedFulfillmentDate")]
	public DateTime? PromisedFulfillmentDate { get; set; }

	/// <summary>
	/// Gets or Sets SalesOrderDate
	/// </summary>
	[DataMember(Name = "SalesOrderDate")]
	public DateTime? SalesOrderDate { get; set; }

	/// <summary>
	/// Gets or Sets ShipToAddress1
	/// </summary>
	[DataMember(Name = "ShipToAddress1")]
	public string ShipToAddress1 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ShipToAddress2
	/// </summary>
	[DataMember(Name = "ShipToAddress2")]
	public string ShipToAddress2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ShipToCity
	/// </summary>
	[DataMember(Name = "ShipToCity")]
	public string ShipToCity { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ShipToCountryID
	/// </summary>
	[DataMember(Name = "ShipToCountryID")]
	public int? ShipToCountryID { get; set; }

	/// <summary>
	/// Gets or Sets ShipToPostalCode
	/// </summary>
	[DataMember(Name = "ShipToPostalCode")]
	public string ShipToPostalCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ShipToState
	/// </summary>
	[DataMember(Name = "ShipToState")]
	public string ShipToState { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "Title")]
	public string Title { get; set; } = string.Empty;

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
