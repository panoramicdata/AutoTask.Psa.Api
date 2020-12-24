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
		/// Initializes a new instance of the <see cref="QuoteModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ApprovalStatus">ApprovalStatus.</param>
		/// <param name="ApprovalStatusChangedByResourceID">ApprovalStatusChangedByResourceID.</param>
		/// <param name="ApprovalStatusChangedDate">ApprovalStatusChangedDate.</param>
		/// <param name="BillToLocationID">BillToLocationID.</param>
		/// <param name="CalculateTaxSeparately">CalculateTaxSeparately.</param>
		/// <param name="Comment">Comment.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="ContactID">ContactID.</param>
		/// <param name="CreateDate">CreateDate.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="EffectiveDate">EffectiveDate.</param>
		/// <param name="ExpirationDate">ExpirationDate.</param>
		/// <param name="ExtApprovalContactResponse">ExtApprovalContactResponse.</param>
		/// <param name="ExtApprovalResponseDate">ExtApprovalResponseDate.</param>
		/// <param name="ExtApprovalResponseSignature">ExtApprovalResponseSignature.</param>
		/// <param name="ExternalQuoteNumber">ExternalQuoteNumber.</param>
		/// <param name="GroupByID">GroupByID.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="LastActivityDate">LastActivityDate.</param>
		/// <param name="LastModifiedBy">LastModifiedBy.</param>
		/// <param name="Name">Name.</param>
		/// <param name="OpportunityID">OpportunityID.</param>
		/// <param name="PaymentTerm">PaymentTerm.</param>
		/// <param name="PaymentType">PaymentType.</param>
		/// <param name="PrimaryQuote">PrimaryQuote.</param>
		/// <param name="ProposalProjectID">ProposalProjectID.</param>
		/// <param name="PurchaseOrderNumber">PurchaseOrderNumber.</param>
		/// <param name="QuoteNumber">QuoteNumber.</param>
		/// <param name="QuoteTemplateID">QuoteTemplateID.</param>
		/// <param name="ShippingType">ShippingType.</param>
		/// <param name="ShipToLocationID">ShipToLocationID.</param>
		/// <param name="ShowEachTaxInGroup">ShowEachTaxInGroup.</param>
		/// <param name="ShowTaxCategory">ShowTaxCategory.</param>
		/// <param name="SoldToLocationID">SoldToLocationID.</param>
		/// <param name="TaxRegionID">TaxRegionID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public QuoteModel(long? Id = default, int? ApprovalStatus = default, int? ApprovalStatusChangedByResourceID = default, DateTime? ApprovalStatusChangedDate = default, int? BillToLocationID = default, bool? CalculateTaxSeparately = default, string Comment = default, int? CompanyID = default, int? ContactID = default, DateTime? CreateDate = default, int? CreatorResourceID = default, string Description = default, DateTime? EffectiveDate = default, DateTime? ExpirationDate = default, int? ExtApprovalContactResponse = default, DateTime? ExtApprovalResponseDate = default, string ExtApprovalResponseSignature = default, string ExternalQuoteNumber = default, int? GroupByID = default, int? ImpersonatorCreatorResourceID = default, bool? IsActive = default, DateTime? LastActivityDate = default, int? LastModifiedBy = default, string Name = default, int? OpportunityID = default, int? PaymentTerm = default, int? PaymentType = default, bool? PrimaryQuote = default, int? ProposalProjectID = default, string PurchaseOrderNumber = default, int? QuoteNumber = default, int? QuoteTemplateID = default, int? ShippingType = default, int? ShipToLocationID = default, bool? ShowEachTaxInGroup = default, bool? ShowTaxCategory = default, int? SoldToLocationID = default, int? TaxRegionID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ApprovalStatus = ApprovalStatus;
			this.ApprovalStatusChangedByResourceID = ApprovalStatusChangedByResourceID;
			this.ApprovalStatusChangedDate = ApprovalStatusChangedDate;
			this.BillToLocationID = BillToLocationID;
			this.CalculateTaxSeparately = CalculateTaxSeparately;
			this.Comment = Comment;
			this.CompanyID = CompanyID;
			this.ContactID = ContactID;
			this.CreateDate = CreateDate;
			this.CreatorResourceID = CreatorResourceID;
			this.Description = Description;
			this.EffectiveDate = EffectiveDate;
			this.ExpirationDate = ExpirationDate;
			this.ExtApprovalContactResponse = ExtApprovalContactResponse;
			this.ExtApprovalResponseDate = ExtApprovalResponseDate;
			this.ExtApprovalResponseSignature = ExtApprovalResponseSignature;
			this.ExternalQuoteNumber = ExternalQuoteNumber;
			this.GroupByID = GroupByID;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.IsActive = IsActive;
			this.LastActivityDate = LastActivityDate;
			this.LastModifiedBy = LastModifiedBy;
			this.Name = Name;
			this.OpportunityID = OpportunityID;
			this.PaymentTerm = PaymentTerm;
			this.PaymentType = PaymentType;
			this.PrimaryQuote = PrimaryQuote;
			this.ProposalProjectID = ProposalProjectID;
			this.PurchaseOrderNumber = PurchaseOrderNumber;
			this.QuoteNumber = QuoteNumber;
			this.QuoteTemplateID = QuoteTemplateID;
			this.ShippingType = ShippingType;
			this.ShipToLocationID = ShipToLocationID;
			this.ShowEachTaxInGroup = ShowEachTaxInGroup;
			this.ShowTaxCategory = ShowTaxCategory;
			this.SoldToLocationID = SoldToLocationID;
			this.TaxRegionID = TaxRegionID;
			this.UserDefinedFields = UserDefinedFields;
		}

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
