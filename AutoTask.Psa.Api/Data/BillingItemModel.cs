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
		/// Initializes a new instance of the <see cref="BillingItemModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AccountManagerWhenApprovedID">AccountManagerWhenApprovedID.</param>
		/// <param name="BillingCodeID">BillingCodeID.</param>
		/// <param name="BillingItemType">BillingItemType.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="ConfigurationItemID">ConfigurationItemID.</param>
		/// <param name="ContractChargeID">ContractChargeID.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="ExpenseItemID">ExpenseItemID.</param>
		/// <param name="ExtendedPrice">ExtendedPrice.</param>
		/// <param name="InternalCurrencyExtendedPrice">InternalCurrencyExtendedPrice.</param>
		/// <param name="InternalCurrencyRate">InternalCurrencyRate.</param>
		/// <param name="InternalCurrencyTaxDollars">InternalCurrencyTaxDollars.</param>
		/// <param name="InternalCurrencyTotalAmount">InternalCurrencyTotalAmount.</param>
		/// <param name="InvoiceID">InvoiceID.</param>
		/// <param name="ItemApproverID">ItemApproverID.</param>
		/// <param name="ItemDate">ItemDate.</param>
		/// <param name="ItemName">ItemName.</param>
		/// <param name="LineItemFullDescription">LineItemFullDescription.</param>
		/// <param name="LineItemGroupDescription">LineItemGroupDescription.</param>
		/// <param name="LineItemID">LineItemID.</param>
		/// <param name="MilestoneID">MilestoneID.</param>
		/// <param name="NonBillable">NonBillable.</param>
		/// <param name="OrganizationalLevelAssociationID">OrganizationalLevelAssociationID.</param>
		/// <param name="OurCost">OurCost.</param>
		/// <param name="PostedDate">PostedDate.</param>
		/// <param name="PostedOnTime">PostedOnTime.</param>
		/// <param name="ProjectChargeID">ProjectChargeID.</param>
		/// <param name="ProjectID">ProjectID.</param>
		/// <param name="PurchaseOrderNumber">PurchaseOrderNumber.</param>
		/// <param name="Quantity">Quantity.</param>
		/// <param name="Rate">Rate.</param>
		/// <param name="RoleID">RoleID.</param>
		/// <param name="ServiceBundleID">ServiceBundleID.</param>
		/// <param name="ServiceID">ServiceID.</param>
		/// <param name="SubType">SubType.</param>
		/// <param name="TaskID">TaskID.</param>
		/// <param name="TaxDollars">TaxDollars.</param>
		/// <param name="TicketChargeID">TicketChargeID.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="TimeEntryID">TimeEntryID.</param>
		/// <param name="TotalAmount">TotalAmount.</param>
		/// <param name="VendorID">VendorID.</param>
		/// <param name="WebServiceDate">WebServiceDate.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public BillingItemModel(long? Id = default, int? AccountManagerWhenApprovedID = default, int? BillingCodeID = default, int? BillingItemType = default, int? CompanyID = default, long? ConfigurationItemID = default, long? ContractChargeID = default, int? ContractID = default, string Description = default, int? ExpenseItemID = default, double? ExtendedPrice = default, double? InternalCurrencyExtendedPrice = default, double? InternalCurrencyRate = default, double? InternalCurrencyTaxDollars = default, double? InternalCurrencyTotalAmount = default, int? InvoiceID = default, int? ItemApproverID = default, DateTime? ItemDate = default, string ItemName = default, string LineItemFullDescription = default, string LineItemGroupDescription = default, long? LineItemID = default, long? MilestoneID = default, int? NonBillable = default, int? OrganizationalLevelAssociationID = default, double? OurCost = default, DateTime? PostedDate = default, DateTime? PostedOnTime = default, long? ProjectChargeID = default, int? ProjectID = default, string PurchaseOrderNumber = default, double? Quantity = default, double? Rate = default, int? RoleID = default, long? ServiceBundleID = default, long? ServiceID = default, int? SubType = default, int? TaskID = default, double? TaxDollars = default, long? TicketChargeID = default, int? TicketID = default, int? TimeEntryID = default, double? TotalAmount = default, long? VendorID = default, DateTime? WebServiceDate = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AccountManagerWhenApprovedID = AccountManagerWhenApprovedID;
			this.BillingCodeID = BillingCodeID;
			this.BillingItemType = BillingItemType;
			this.CompanyID = CompanyID;
			this.ConfigurationItemID = ConfigurationItemID;
			this.ContractChargeID = ContractChargeID;
			this.ContractID = ContractID;
			this.Description = Description;
			this.ExpenseItemID = ExpenseItemID;
			this.ExtendedPrice = ExtendedPrice;
			this.InternalCurrencyExtendedPrice = InternalCurrencyExtendedPrice;
			this.InternalCurrencyRate = InternalCurrencyRate;
			this.InternalCurrencyTaxDollars = InternalCurrencyTaxDollars;
			this.InternalCurrencyTotalAmount = InternalCurrencyTotalAmount;
			this.InvoiceID = InvoiceID;
			this.ItemApproverID = ItemApproverID;
			this.ItemDate = ItemDate;
			this.ItemName = ItemName;
			this.LineItemFullDescription = LineItemFullDescription;
			this.LineItemGroupDescription = LineItemGroupDescription;
			this.LineItemID = LineItemID;
			this.MilestoneID = MilestoneID;
			this.NonBillable = NonBillable;
			this.OrganizationalLevelAssociationID = OrganizationalLevelAssociationID;
			this.OurCost = OurCost;
			this.PostedDate = PostedDate;
			this.PostedOnTime = PostedOnTime;
			this.ProjectChargeID = ProjectChargeID;
			this.ProjectID = ProjectID;
			this.PurchaseOrderNumber = PurchaseOrderNumber;
			this.Quantity = Quantity;
			this.Rate = Rate;
			this.RoleID = RoleID;
			this.ServiceBundleID = ServiceBundleID;
			this.ServiceID = ServiceID;
			this.SubType = SubType;
			this.TaskID = TaskID;
			this.TaxDollars = TaxDollars;
			this.TicketChargeID = TicketChargeID;
			this.TicketID = TicketID;
			this.TimeEntryID = TimeEntryID;
			this.TotalAmount = TotalAmount;
			this.VendorID = VendorID;
			this.WebServiceDate = WebServiceDate;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AccountManagerWhenApprovedID
		/// </summary>
		[DataMember(Name = "AccountManagerWhenApprovedID", EmitDefaultValue = false)]
		public int? AccountManagerWhenApprovedID { get; set; }

		/// <summary>
		/// Gets or Sets BillingCodeID
		/// </summary>
		[DataMember(Name = "BillingCodeID", EmitDefaultValue = false)]
		public int? BillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets BillingItemType
		/// </summary>
		[DataMember(Name = "BillingItemType", EmitDefaultValue = false)]
		public int? BillingItemType { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets ConfigurationItemID
		/// </summary>
		[DataMember(Name = "ConfigurationItemID", EmitDefaultValue = false)]
		public long? ConfigurationItemID { get; set; }

		/// <summary>
		/// Gets or Sets ContractChargeID
		/// </summary>
		[DataMember(Name = "ContractChargeID", EmitDefaultValue = false)]
		public long? ContractChargeID { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets ExpenseItemID
		/// </summary>
		[DataMember(Name = "ExpenseItemID", EmitDefaultValue = false)]
		public int? ExpenseItemID { get; set; }

		/// <summary>
		/// Gets or Sets ExtendedPrice
		/// </summary>
		[DataMember(Name = "ExtendedPrice", EmitDefaultValue = false)]
		public double? ExtendedPrice { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyExtendedPrice
		/// </summary>
		[DataMember(Name = "InternalCurrencyExtendedPrice", EmitDefaultValue = false)]
		public double? InternalCurrencyExtendedPrice { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyRate
		/// </summary>
		[DataMember(Name = "InternalCurrencyRate", EmitDefaultValue = false)]
		public double? InternalCurrencyRate { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyTaxDollars
		/// </summary>
		[DataMember(Name = "InternalCurrencyTaxDollars", EmitDefaultValue = false)]
		public double? InternalCurrencyTaxDollars { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyTotalAmount
		/// </summary>
		[DataMember(Name = "InternalCurrencyTotalAmount", EmitDefaultValue = false)]
		public double? InternalCurrencyTotalAmount { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceID
		/// </summary>
		[DataMember(Name = "InvoiceID", EmitDefaultValue = false)]
		public int? InvoiceID { get; set; }

		/// <summary>
		/// Gets or Sets ItemApproverID
		/// </summary>
		[DataMember(Name = "ItemApproverID", EmitDefaultValue = false)]
		public int? ItemApproverID { get; set; }

		/// <summary>
		/// Gets or Sets ItemDate
		/// </summary>
		[DataMember(Name = "ItemDate", EmitDefaultValue = false)]
		public DateTime? ItemDate { get; set; }

		/// <summary>
		/// Gets or Sets ItemName
		/// </summary>
		[DataMember(Name = "ItemName", EmitDefaultValue = false)]
		public string ItemName { get; set; }

		/// <summary>
		/// Gets or Sets LineItemFullDescription
		/// </summary>
		[DataMember(Name = "LineItemFullDescription", EmitDefaultValue = false)]
		public string LineItemFullDescription { get; set; }

		/// <summary>
		/// Gets or Sets LineItemGroupDescription
		/// </summary>
		[DataMember(Name = "LineItemGroupDescription", EmitDefaultValue = false)]
		public string LineItemGroupDescription { get; set; }

		/// <summary>
		/// Gets or Sets LineItemID
		/// </summary>
		[DataMember(Name = "LineItemID", EmitDefaultValue = false)]
		public long? LineItemID { get; set; }

		/// <summary>
		/// Gets or Sets MilestoneID
		/// </summary>
		[DataMember(Name = "MilestoneID", EmitDefaultValue = false)]
		public long? MilestoneID { get; set; }

		/// <summary>
		/// Gets or Sets NonBillable
		/// </summary>
		[DataMember(Name = "NonBillable", EmitDefaultValue = false)]
		public int? NonBillable { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets OurCost
		/// </summary>
		[DataMember(Name = "OurCost", EmitDefaultValue = false)]
		public double? OurCost { get; set; }

		/// <summary>
		/// Gets or Sets PostedDate
		/// </summary>
		[DataMember(Name = "PostedDate", EmitDefaultValue = false)]
		public DateTime? PostedDate { get; set; }

		/// <summary>
		/// Gets or Sets PostedOnTime
		/// </summary>
		[DataMember(Name = "PostedOnTime", EmitDefaultValue = false)]
		public DateTime? PostedOnTime { get; set; }

		/// <summary>
		/// Gets or Sets ProjectChargeID
		/// </summary>
		[DataMember(Name = "ProjectChargeID", EmitDefaultValue = false)]
		public long? ProjectChargeID { get; set; }

		/// <summary>
		/// Gets or Sets ProjectID
		/// </summary>
		[DataMember(Name = "ProjectID", EmitDefaultValue = false)]
		public int? ProjectID { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Gets or Sets Quantity
		/// </summary>
		[DataMember(Name = "Quantity", EmitDefaultValue = false)]
		public double? Quantity { get; set; }

		/// <summary>
		/// Gets or Sets Rate
		/// </summary>
		[DataMember(Name = "Rate", EmitDefaultValue = false)]
		public double? Rate { get; set; }

		/// <summary>
		/// Gets or Sets RoleID
		/// </summary>
		[DataMember(Name = "RoleID", EmitDefaultValue = false)]
		public int? RoleID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceBundleID
		/// </summary>
		[DataMember(Name = "ServiceBundleID", EmitDefaultValue = false)]
		public long? ServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceID
		/// </summary>
		[DataMember(Name = "ServiceID", EmitDefaultValue = false)]
		public long? ServiceID { get; set; }

		/// <summary>
		/// Gets or Sets SubType
		/// </summary>
		[DataMember(Name = "SubType", EmitDefaultValue = false)]
		public int? SubType { get; set; }

		/// <summary>
		/// Gets or Sets TaskID
		/// </summary>
		[DataMember(Name = "TaskID", EmitDefaultValue = false)]
		public int? TaskID { get; set; }

		/// <summary>
		/// Gets or Sets TaxDollars
		/// </summary>
		[DataMember(Name = "TaxDollars", EmitDefaultValue = false)]
		public double? TaxDollars { get; set; }

		/// <summary>
		/// Gets or Sets TicketChargeID
		/// </summary>
		[DataMember(Name = "TicketChargeID", EmitDefaultValue = false)]
		public long? TicketChargeID { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets TimeEntryID
		/// </summary>
		[DataMember(Name = "TimeEntryID", EmitDefaultValue = false)]
		public int? TimeEntryID { get; set; }

		/// <summary>
		/// Gets or Sets TotalAmount
		/// </summary>
		[DataMember(Name = "TotalAmount", EmitDefaultValue = false)]
		public double? TotalAmount { get; set; }

		/// <summary>
		/// Gets or Sets VendorID
		/// </summary>
		[DataMember(Name = "VendorID", EmitDefaultValue = false)]
		public long? VendorID { get; set; }

		/// <summary>
		/// Gets or Sets WebServiceDate
		/// </summary>
		[DataMember(Name = "WebServiceDate", EmitDefaultValue = false)]
		public DateTime? WebServiceDate { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
