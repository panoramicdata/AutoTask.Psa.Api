using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// QuoteModel
	/// </summary>
	[DataContract]
	public partial class QuoteModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ApprovalStatus
		/// </summary>
		[DataMember(Name = "ApprovalStatus", EmitDefaultValue = false)]
		public int? ApprovalStatus { get; set; }

		/// <summary>
		/// Gets or Sets ApprovalStatusChangedByResourceID
		/// </summary>
		[DataMember(Name = "ApprovalStatusChangedByResourceID", EmitDefaultValue = false)]
		public int? ApprovalStatusChangedByResourceID { get; set; }

		/// <summary>
		/// Gets or Sets ApprovalStatusChangedDate
		/// </summary>
		[DataMember(Name = "ApprovalStatusChangedDate", EmitDefaultValue = false)]
		public DateTime? ApprovalStatusChangedDate { get; set; }

		/// <summary>
		/// Gets or Sets BillToLocationID
		/// </summary>
		[DataMember(Name = "BillToLocationID", EmitDefaultValue = false)]
		public int? BillToLocationID { get; set; }

		/// <summary>
		/// Gets or Sets CalculateTaxSeparately
		/// </summary>
		[DataMember(Name = "CalculateTaxSeparately", EmitDefaultValue = false)]
		public bool? CalculateTaxSeparately { get; set; }

		/// <summary>
		/// Gets or Sets Comment
		/// </summary>
		[DataMember(Name = "Comment", EmitDefaultValue = false)]
		public string Comment { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public int? ContactID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate", EmitDefaultValue = false)]
		public DateTime? CreateDate { get; set; }

		/// <summary>
		/// Gets or Sets CreatorResourceID
		/// </summary>
		[DataMember(Name = "CreatorResourceID", EmitDefaultValue = false)]
		public int? CreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets EffectiveDate
		/// </summary>
		[DataMember(Name = "EffectiveDate", EmitDefaultValue = false)]
		public DateTime? EffectiveDate { get; set; }

		/// <summary>
		/// Gets or Sets ExpirationDate
		/// </summary>
		[DataMember(Name = "ExpirationDate", EmitDefaultValue = false)]
		public DateTime? ExpirationDate { get; set; }

		/// <summary>
		/// Gets or Sets ExtApprovalContactResponse
		/// </summary>
		[DataMember(Name = "ExtApprovalContactResponse", EmitDefaultValue = false)]
		public int? ExtApprovalContactResponse { get; set; }

		/// <summary>
		/// Gets or Sets ExtApprovalResponseDate
		/// </summary>
		[DataMember(Name = "ExtApprovalResponseDate", EmitDefaultValue = false)]
		public DateTime? ExtApprovalResponseDate { get; set; }

		/// <summary>
		/// Gets or Sets ExtApprovalResponseSignature
		/// </summary>
		[DataMember(Name = "ExtApprovalResponseSignature", EmitDefaultValue = false)]
		public string ExtApprovalResponseSignature { get; set; }

		/// <summary>
		/// Gets or Sets ExternalQuoteNumber
		/// </summary>
		[DataMember(Name = "ExternalQuoteNumber", EmitDefaultValue = false)]
		public string ExternalQuoteNumber { get; set; }

		/// <summary>
		/// Gets or Sets GroupByID
		/// </summary>
		[DataMember(Name = "GroupByID", EmitDefaultValue = false)]
		public int? GroupByID { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityDate
		/// </summary>
		[DataMember(Name = "LastActivityDate", EmitDefaultValue = false)]
		public DateTime? LastActivityDate { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedBy
		/// </summary>
		[DataMember(Name = "LastModifiedBy", EmitDefaultValue = false)]
		public int? LastModifiedBy { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets OpportunityID
		/// </summary>
		[DataMember(Name = "OpportunityID", EmitDefaultValue = false)]
		public int? OpportunityID { get; set; }

		/// <summary>
		/// Gets or Sets PaymentTerm
		/// </summary>
		[DataMember(Name = "PaymentTerm", EmitDefaultValue = false)]
		public int? PaymentTerm { get; set; }

		/// <summary>
		/// Gets or Sets PaymentType
		/// </summary>
		[DataMember(Name = "PaymentType", EmitDefaultValue = false)]
		public int? PaymentType { get; set; }

		/// <summary>
		/// Gets or Sets PrimaryQuote
		/// </summary>
		[DataMember(Name = "PrimaryQuote", EmitDefaultValue = false)]
		public bool? PrimaryQuote { get; set; }

		/// <summary>
		/// Gets or Sets ProposalProjectID
		/// </summary>
		[DataMember(Name = "ProposalProjectID", EmitDefaultValue = false)]
		public int? ProposalProjectID { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Gets or Sets QuoteNumber
		/// </summary>
		[DataMember(Name = "QuoteNumber", EmitDefaultValue = false)]
		public int? QuoteNumber { get; set; }

		/// <summary>
		/// Gets or Sets QuoteTemplateID
		/// </summary>
		[DataMember(Name = "QuoteTemplateID", EmitDefaultValue = false)]
		public int? QuoteTemplateID { get; set; }

		/// <summary>
		/// Gets or Sets ShippingType
		/// </summary>
		[DataMember(Name = "ShippingType", EmitDefaultValue = false)]
		public int? ShippingType { get; set; }

		/// <summary>
		/// Gets or Sets ShipToLocationID
		/// </summary>
		[DataMember(Name = "ShipToLocationID", EmitDefaultValue = false)]
		public int? ShipToLocationID { get; set; }

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
		/// Gets or Sets SoldToLocationID
		/// </summary>
		[DataMember(Name = "SoldToLocationID", EmitDefaultValue = false)]
		public int? SoldToLocationID { get; set; }

		/// <summary>
		/// Gets or Sets TaxRegionID
		/// </summary>
		[DataMember(Name = "TaxRegionID", EmitDefaultValue = false)]
		public int? TaxRegionID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
