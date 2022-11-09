namespace AutoTask.Psa.Api.Data;

/// <summary>
/// PurchaseOrderModel
/// </summary>
[DataContract]
public class PurchaseOrderModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets CancelDateTime
	/// </summary>
	[DataMember(Name = "CancelDateTime")]
	public DateTime? CancelDateTime { get; set; }

	/// <summary>
	/// Gets or Sets CreateDateTime
	/// </summary>
	[DataMember(Name = "CreateDateTime")]
	public DateTime? CreateDateTime { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public int? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets ExternalPONumber
	/// </summary>
	[DataMember(Name = "ExternalPONumber")]
	public string ExternalPONumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Fax
	/// </summary>
	[DataMember(Name = "Fax")]
	public string Fax { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Freight
	/// </summary>
	[DataMember(Name = "Freight")]
	public double? Freight { get; set; }

	/// <summary>
	/// Gets or Sets GeneralMemo
	/// </summary>
	[DataMember(Name = "GeneralMemo")]
	public string GeneralMemo { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyFreight
	/// </summary>
	[DataMember(Name = "InternalCurrencyFreight")]
	public double? InternalCurrencyFreight { get; set; }

	/// <summary>
	/// Gets or Sets LatestEstimatedArrivalDate
	/// </summary>
	[DataMember(Name = "LatestEstimatedArrivalDate")]
	public DateTime? LatestEstimatedArrivalDate { get; set; }

	/// <summary>
	/// Gets or Sets PaymentTerm
	/// </summary>
	[DataMember(Name = "PaymentTerm")]
	public int? PaymentTerm { get; set; }

	/// <summary>
	/// Gets or Sets Phone
	/// </summary>
	[DataMember(Name = "Phone")]
	public string Phone { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets PurchaseForCompanyID
	/// </summary>
	[DataMember(Name = "PurchaseForCompanyID")]
	public int? PurchaseForCompanyID { get; set; }

	/// <summary>
	/// Gets or Sets ShippingDate
	/// </summary>
	[DataMember(Name = "ShippingDate")]
	public DateTime? ShippingDate { get; set; }

	/// <summary>
	/// Gets or Sets ShippingType
	/// </summary>
	[DataMember(Name = "ShippingType")]
	public int? ShippingType { get; set; }

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
	/// Gets or Sets ShipToName
	/// </summary>
	[DataMember(Name = "ShipToName")]
	public string ShipToName { get; set; } = string.Empty;

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
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

	/// <summary>
	/// Gets or Sets SubmitDateTime
	/// </summary>
	[DataMember(Name = "SubmitDateTime")]
	public DateTime? SubmitDateTime { get; set; }

	/// <summary>
	/// Gets or Sets TaxRegionID
	/// </summary>
	[DataMember(Name = "TaxRegionID")]
	public int? TaxRegionID { get; set; }

	/// <summary>
	/// Gets or Sets UseItemDescriptionsFrom
	/// </summary>
	[DataMember(Name = "UseItemDescriptionsFrom")]
	public int? UseItemDescriptionsFrom { get; set; }

	/// <summary>
	/// Gets or Sets VendorID
	/// </summary>
	[DataMember(Name = "VendorID")]
	public int? VendorID { get; set; }

	/// <summary>
	/// Gets or Sets VendorInvoiceNumber
	/// </summary>
	[DataMember(Name = "VendorInvoiceNumber")]
	public string VendorInvoiceNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
