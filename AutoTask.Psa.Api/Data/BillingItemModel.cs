using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// BillingItemModel
	/// </summary>
	[DataContract]
	public partial class BillingItemModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AccountManagerWhenApprovedID
		/// </summary>
		[DataMember(Name = "AccountManagerWhenApprovedID")]
		public int? AccountManagerWhenApprovedID { get; set; }

		/// <summary>
		/// Gets or Sets BillingCodeID
		/// </summary>
		[DataMember(Name = "BillingCodeID")]
		public int? BillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets BillingItemType
		/// </summary>
		[DataMember(Name = "BillingItemType")]
		public int? BillingItemType { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID")]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets ConfigurationItemID
		/// </summary>
		[DataMember(Name = "ConfigurationItemID")]
		public long? ConfigurationItemID { get; set; }

		/// <summary>
		/// Gets or Sets ContractChargeID
		/// </summary>
		[DataMember(Name = "ContractChargeID")]
		public long? ContractChargeID { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID")]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ExpenseItemID
		/// </summary>
		[DataMember(Name = "ExpenseItemID")]
		public int? ExpenseItemID { get; set; }

		/// <summary>
		/// Gets or Sets ExtendedPrice
		/// </summary>
		[DataMember(Name = "ExtendedPrice")]
		public double? ExtendedPrice { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyExtendedPrice
		/// </summary>
		[DataMember(Name = "InternalCurrencyExtendedPrice")]
		public double? InternalCurrencyExtendedPrice { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyRate
		/// </summary>
		[DataMember(Name = "InternalCurrencyRate")]
		public double? InternalCurrencyRate { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyTaxDollars
		/// </summary>
		[DataMember(Name = "InternalCurrencyTaxDollars")]
		public double? InternalCurrencyTaxDollars { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyTotalAmount
		/// </summary>
		[DataMember(Name = "InternalCurrencyTotalAmount")]
		public double? InternalCurrencyTotalAmount { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceID
		/// </summary>
		[DataMember(Name = "InvoiceID")]
		public int? InvoiceID { get; set; }

		/// <summary>
		/// Gets or Sets ItemApproverID
		/// </summary>
		[DataMember(Name = "ItemApproverID")]
		public int? ItemApproverID { get; set; }

		/// <summary>
		/// Gets or Sets ItemDate
		/// </summary>
		[DataMember(Name = "ItemDate")]
		public DateTime? ItemDate { get; set; }

		/// <summary>
		/// Gets or Sets ItemName
		/// </summary>
		[DataMember(Name = "ItemName")]
		public string ItemName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets LineItemFullDescription
		/// </summary>
		[DataMember(Name = "LineItemFullDescription")]
		public string LineItemFullDescription { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets LineItemGroupDescription
		/// </summary>
		[DataMember(Name = "LineItemGroupDescription")]
		public string LineItemGroupDescription { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets LineItemID
		/// </summary>
		[DataMember(Name = "LineItemID")]
		public long? LineItemID { get; set; }

		/// <summary>
		/// Gets or Sets MilestoneID
		/// </summary>
		[DataMember(Name = "MilestoneID")]
		public long? MilestoneID { get; set; }

		/// <summary>
		/// Gets or Sets NonBillable
		/// </summary>
		[DataMember(Name = "NonBillable")]
		public int? NonBillable { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID")]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets OurCost
		/// </summary>
		[DataMember(Name = "OurCost")]
		public double? OurCost { get; set; }

		/// <summary>
		/// Gets or Sets PostedDate
		/// </summary>
		[DataMember(Name = "PostedDate")]
		public DateTime? PostedDate { get; set; }

		/// <summary>
		/// Gets or Sets PostedOnTime
		/// </summary>
		[DataMember(Name = "PostedOnTime")]
		public DateTime? PostedOnTime { get; set; }

		/// <summary>
		/// Gets or Sets ProjectChargeID
		/// </summary>
		[DataMember(Name = "ProjectChargeID")]
		public long? ProjectChargeID { get; set; }

		/// <summary>
		/// Gets or Sets ProjectID
		/// </summary>
		[DataMember(Name = "ProjectID")]
		public int? ProjectID { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Quantity
		/// </summary>
		[DataMember(Name = "Quantity")]
		public double? Quantity { get; set; }

		/// <summary>
		/// Gets or Sets Rate
		/// </summary>
		[DataMember(Name = "Rate")]
		public double? Rate { get; set; }

		/// <summary>
		/// Gets or Sets RoleID
		/// </summary>
		[DataMember(Name = "RoleID")]
		public int? RoleID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceBundleID
		/// </summary>
		[DataMember(Name = "ServiceBundleID")]
		public long? ServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceID
		/// </summary>
		[DataMember(Name = "ServiceID")]
		public long? ServiceID { get; set; }

		/// <summary>
		/// Gets or Sets SubType
		/// </summary>
		[DataMember(Name = "SubType")]
		public int? SubType { get; set; }

		/// <summary>
		/// Gets or Sets TaskID
		/// </summary>
		[DataMember(Name = "TaskID")]
		public int? TaskID { get; set; }

		/// <summary>
		/// Gets or Sets TaxDollars
		/// </summary>
		[DataMember(Name = "TaxDollars")]
		public double? TaxDollars { get; set; }

		/// <summary>
		/// Gets or Sets TicketChargeID
		/// </summary>
		[DataMember(Name = "TicketChargeID")]
		public long? TicketChargeID { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID")]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets TimeEntryID
		/// </summary>
		[DataMember(Name = "TimeEntryID")]
		public int? TimeEntryID { get; set; }

		/// <summary>
		/// Gets or Sets TotalAmount
		/// </summary>
		[DataMember(Name = "TotalAmount")]
		public double? TotalAmount { get; set; }

		/// <summary>
		/// Gets or Sets VendorID
		/// </summary>
		[DataMember(Name = "VendorID")]
		public long? VendorID { get; set; }

		/// <summary>
		/// Gets or Sets WebServiceDate
		/// </summary>
		[DataMember(Name = "WebServiceDate")]
		public DateTime? WebServiceDate { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
