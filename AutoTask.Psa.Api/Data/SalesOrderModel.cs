using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// SalesOrderModel
	/// </summary>
	[DataContract]
	public partial class SalesOrderModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SalesOrderModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AdditionalBillToAddressInformation">AdditionalBillToAddressInformation.</param>
		/// <param name="AdditionalShipToAddressInformation">AdditionalShipToAddressInformation.</param>
		/// <param name="BillingAddress1">BillingAddress1.</param>
		/// <param name="BillingAddress2">BillingAddress2.</param>
		/// <param name="BillToCity">BillToCity.</param>
		/// <param name="BillToCountryID">BillToCountryID.</param>
		/// <param name="BillToPostalCode">BillToPostalCode.</param>
		/// <param name="BillToState">BillToState.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="ContactID">ContactID.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="OpportunityID">OpportunityID.</param>
		/// <param name="OrganizationalLevelAssociationID">OrganizationalLevelAssociationID.</param>
		/// <param name="OwnerResourceID">OwnerResourceID.</param>
		/// <param name="PromisedFulfillmentDate">PromisedFulfillmentDate.</param>
		/// <param name="SalesOrderDate">SalesOrderDate.</param>
		/// <param name="ShipToAddress1">ShipToAddress1.</param>
		/// <param name="ShipToAddress2">ShipToAddress2.</param>
		/// <param name="ShipToCity">ShipToCity.</param>
		/// <param name="ShipToCountryID">ShipToCountryID.</param>
		/// <param name="ShipToPostalCode">ShipToPostalCode.</param>
		/// <param name="ShipToState">ShipToState.</param>
		/// <param name="Status">Status.</param>
		/// <param name="Title">Title.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public SalesOrderModel(long? Id = default, string AdditionalBillToAddressInformation = default, string AdditionalShipToAddressInformation = default, string BillingAddress1 = default, string BillingAddress2 = default, string BillToCity = default, int? BillToCountryID = default, string BillToPostalCode = default, string BillToState = default, int? CompanyID = default, int? ContactID = default, int? ImpersonatorCreatorResourceID = default, int? OpportunityID = default, int? OrganizationalLevelAssociationID = default, int? OwnerResourceID = default, DateTime? PromisedFulfillmentDate = default, DateTime? SalesOrderDate = default, string ShipToAddress1 = default, string ShipToAddress2 = default, string ShipToCity = default, int? ShipToCountryID = default, string ShipToPostalCode = default, string ShipToState = default, int? Status = default, string Title = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AdditionalBillToAddressInformation = AdditionalBillToAddressInformation;
			this.AdditionalShipToAddressInformation = AdditionalShipToAddressInformation;
			this.BillingAddress1 = BillingAddress1;
			this.BillingAddress2 = BillingAddress2;
			this.BillToCity = BillToCity;
			this.BillToCountryID = BillToCountryID;
			this.BillToPostalCode = BillToPostalCode;
			this.BillToState = BillToState;
			this.CompanyID = CompanyID;
			this.ContactID = ContactID;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.OpportunityID = OpportunityID;
			this.OrganizationalLevelAssociationID = OrganizationalLevelAssociationID;
			this.OwnerResourceID = OwnerResourceID;
			this.PromisedFulfillmentDate = PromisedFulfillmentDate;
			this.SalesOrderDate = SalesOrderDate;
			this.ShipToAddress1 = ShipToAddress1;
			this.ShipToAddress2 = ShipToAddress2;
			this.ShipToCity = ShipToCity;
			this.ShipToCountryID = ShipToCountryID;
			this.ShipToPostalCode = ShipToPostalCode;
			this.ShipToState = ShipToState;
			this.Status = Status;
			this.Title = Title;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AdditionalBillToAddressInformation
		/// </summary>
		[DataMember(Name = "AdditionalBillToAddressInformation", EmitDefaultValue = false)]
		public string AdditionalBillToAddressInformation { get; set; }

		/// <summary>
		/// Gets or Sets AdditionalShipToAddressInformation
		/// </summary>
		[DataMember(Name = "AdditionalShipToAddressInformation", EmitDefaultValue = false)]
		public string AdditionalShipToAddressInformation { get; set; }

		/// <summary>
		/// Gets or Sets BillingAddress1
		/// </summary>
		[DataMember(Name = "BillingAddress1", EmitDefaultValue = false)]
		public string BillingAddress1 { get; set; }

		/// <summary>
		/// Gets or Sets BillingAddress2
		/// </summary>
		[DataMember(Name = "BillingAddress2", EmitDefaultValue = false)]
		public string BillingAddress2 { get; set; }

		/// <summary>
		/// Gets or Sets BillToCity
		/// </summary>
		[DataMember(Name = "BillToCity", EmitDefaultValue = false)]
		public string BillToCity { get; set; }

		/// <summary>
		/// Gets or Sets BillToCountryID
		/// </summary>
		[DataMember(Name = "BillToCountryID", EmitDefaultValue = false)]
		public int? BillToCountryID { get; set; }

		/// <summary>
		/// Gets or Sets BillToPostalCode
		/// </summary>
		[DataMember(Name = "BillToPostalCode", EmitDefaultValue = false)]
		public string BillToPostalCode { get; set; }

		/// <summary>
		/// Gets or Sets BillToState
		/// </summary>
		[DataMember(Name = "BillToState", EmitDefaultValue = false)]
		public string BillToState { get; set; }

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
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets OpportunityID
		/// </summary>
		[DataMember(Name = "OpportunityID", EmitDefaultValue = false)]
		public int? OpportunityID { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets OwnerResourceID
		/// </summary>
		[DataMember(Name = "OwnerResourceID", EmitDefaultValue = false)]
		public int? OwnerResourceID { get; set; }

		/// <summary>
		/// Gets or Sets PromisedFulfillmentDate
		/// </summary>
		[DataMember(Name = "PromisedFulfillmentDate", EmitDefaultValue = false)]
		public DateTime? PromisedFulfillmentDate { get; set; }

		/// <summary>
		/// Gets or Sets SalesOrderDate
		/// </summary>
		[DataMember(Name = "SalesOrderDate", EmitDefaultValue = false)]
		public DateTime? SalesOrderDate { get; set; }

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
		/// Gets or Sets ShipToCountryID
		/// </summary>
		[DataMember(Name = "ShipToCountryID", EmitDefaultValue = false)]
		public int? ShipToCountryID { get; set; }

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
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncSalesOrderInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
