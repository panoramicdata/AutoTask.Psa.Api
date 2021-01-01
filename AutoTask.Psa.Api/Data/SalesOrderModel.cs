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
