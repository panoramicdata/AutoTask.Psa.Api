using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// PurchaseOrderModel
	/// </summary>
	[DataContract]
	public partial class PurchaseOrderModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CancelDateTime
		/// </summary>
		[DataMember(Name = "CancelDateTime", EmitDefaultValue = false)]
		public DateTime? CancelDateTime { get; set; }

		/// <summary>
		/// Gets or Sets CreateDateTime
		/// </summary>
		[DataMember(Name = "CreateDateTime", EmitDefaultValue = false)]
		public DateTime? CreateDateTime { get; set; }

		/// <summary>
		/// Gets or Sets CreatorResourceID
		/// </summary>
		[DataMember(Name = "CreatorResourceID", EmitDefaultValue = false)]
		public int? CreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets ExternalPONumber
		/// </summary>
		[DataMember(Name = "ExternalPONumber", EmitDefaultValue = false)]
		public string ExternalPONumber { get; set; }

		/// <summary>
		/// Gets or Sets Fax
		/// </summary>
		[DataMember(Name = "Fax", EmitDefaultValue = false)]
		public string Fax { get; set; }

		/// <summary>
		/// Gets or Sets Freight
		/// </summary>
		[DataMember(Name = "Freight", EmitDefaultValue = false)]
		public double? Freight { get; set; }

		/// <summary>
		/// Gets or Sets GeneralMemo
		/// </summary>
		[DataMember(Name = "GeneralMemo", EmitDefaultValue = false)]
		public string GeneralMemo { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyFreight
		/// </summary>
		[DataMember(Name = "InternalCurrencyFreight", EmitDefaultValue = false)]
		public double? InternalCurrencyFreight { get; set; }

		/// <summary>
		/// Gets or Sets LatestEstimatedArrivalDate
		/// </summary>
		[DataMember(Name = "LatestEstimatedArrivalDate", EmitDefaultValue = false)]
		public DateTime? LatestEstimatedArrivalDate { get; set; }

		/// <summary>
		/// Gets or Sets PaymentTerm
		/// </summary>
		[DataMember(Name = "PaymentTerm", EmitDefaultValue = false)]
		public int? PaymentTerm { get; set; }

		/// <summary>
		/// Gets or Sets Phone
		/// </summary>
		[DataMember(Name = "Phone", EmitDefaultValue = false)]
		public string Phone { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseForCompanyID
		/// </summary>
		[DataMember(Name = "PurchaseForCompanyID", EmitDefaultValue = false)]
		public int? PurchaseForCompanyID { get; set; }

		/// <summary>
		/// Gets or Sets ShippingDate
		/// </summary>
		[DataMember(Name = "ShippingDate", EmitDefaultValue = false)]
		public DateTime? ShippingDate { get; set; }

		/// <summary>
		/// Gets or Sets ShippingType
		/// </summary>
		[DataMember(Name = "ShippingType", EmitDefaultValue = false)]
		public int? ShippingType { get; set; }

		/// <summary>
		/// Gets or Sets ShipToAddress1
		/// </summary>
		[DataMember(Name = "ShipToAddress1", EmitDefaultValue = false)]
		public string ShipToAddress1 { get; set; }

		/// <summary>
		/// Gets or Sets ShipToAddress2
		/// </summary>
		[DataMember(Name = "ShipToAddress2", EmitDefaultValue = false)]
		public string ShipToAddress2 { get; set; }

		/// <summary>
		/// Gets or Sets ShipToCity
		/// </summary>
		[DataMember(Name = "ShipToCity", EmitDefaultValue = false)]
		public string ShipToCity { get; set; }

		/// <summary>
		/// Gets or Sets ShipToName
		/// </summary>
		[DataMember(Name = "ShipToName", EmitDefaultValue = false)]
		public string ShipToName { get; set; }

		/// <summary>
		/// Gets or Sets ShipToPostalCode
		/// </summary>
		[DataMember(Name = "ShipToPostalCode", EmitDefaultValue = false)]
		public string ShipToPostalCode { get; set; }

		/// <summary>
		/// Gets or Sets ShipToState
		/// </summary>
		[DataMember(Name = "ShipToState", EmitDefaultValue = false)]
		public string ShipToState { get; set; }

		/// <summary>
		/// Gets or Sets ShowEachTaxInGroup
		/// </summary>
		[DataMember(Name = "ShowEachTaxInGroup", EmitDefaultValue = false)]
		public bool? ShowEachTaxInGroup { get; set; }

		/// <summary>
		/// Gets or Sets ShowTaxCategory
		/// </summary>
		[DataMember(Name = "ShowTaxCategory", EmitDefaultValue = false)]
		public bool? ShowTaxCategory { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets SubmitDateTime
		/// </summary>
		[DataMember(Name = "SubmitDateTime", EmitDefaultValue = false)]
		public DateTime? SubmitDateTime { get; set; }

		/// <summary>
		/// Gets or Sets TaxRegionID
		/// </summary>
		[DataMember(Name = "TaxRegionID", EmitDefaultValue = false)]
		public int? TaxRegionID { get; set; }

		/// <summary>
		/// Gets or Sets UseItemDescriptionsFrom
		/// </summary>
		[DataMember(Name = "UseItemDescriptionsFrom", EmitDefaultValue = false)]
		public int? UseItemDescriptionsFrom { get; set; }

		/// <summary>
		/// Gets or Sets VendorID
		/// </summary>
		[DataMember(Name = "VendorID", EmitDefaultValue = false)]
		public int? VendorID { get; set; }

		/// <summary>
		/// Gets or Sets VendorInvoiceNumber
		/// </summary>
		[DataMember(Name = "VendorInvoiceNumber", EmitDefaultValue = false)]
		public string VendorInvoiceNumber { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
