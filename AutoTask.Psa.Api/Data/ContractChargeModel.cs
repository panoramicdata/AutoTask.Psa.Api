using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractChargeModel
	/// </summary>
	[DataContract]
	public partial class ContractChargeModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractChargeModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BillableAmount">BillableAmount.</param>
		/// <param name="BillingCodeID">BillingCodeID.</param>
		/// <param name="ChargeType">ChargeType.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="ContractServiceBundleID">ContractServiceBundleID.</param>
		/// <param name="ContractServiceID">ContractServiceID.</param>
		/// <param name="CreateDate">CreateDate.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="DatePurchased">DatePurchased.</param>
		/// <param name="Description">Description.</param>
		/// <param name="ExtendedCost">ExtendedCost.</param>
		/// <param name="InternalCurrencyBillableAmount">InternalCurrencyBillableAmount.</param>
		/// <param name="InternalCurrencyUnitPrice">InternalCurrencyUnitPrice.</param>
		/// <param name="InternalPurchaseOrderNumber">InternalPurchaseOrderNumber.</param>
		/// <param name="IsBillableToCompany">IsBillableToCompany.</param>
		/// <param name="IsBilled">IsBilled.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Notes">Notes.</param>
		/// <param name="OrganizationalLevelAssociationID">OrganizationalLevelAssociationID.</param>
		/// <param name="ProductID">ProductID.</param>
		/// <param name="PurchaseOrderNumber">PurchaseOrderNumber.</param>
		/// <param name="Status">Status.</param>
		/// <param name="StatusLastModifiedBy">StatusLastModifiedBy.</param>
		/// <param name="StatusLastModifiedDate">StatusLastModifiedDate.</param>
		/// <param name="UnitCost">UnitCost.</param>
		/// <param name="UnitPrice">UnitPrice.</param>
		/// <param name="UnitQuantity">UnitQuantity.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractChargeModel(long? Id = default, double? BillableAmount = default, long? BillingCodeID = default, int? ChargeType = default, long? ContractID = default, long? ContractServiceBundleID = default, long? ContractServiceID = default, DateTime? CreateDate = default, long? CreatorResourceID = default, DateTime? DatePurchased = default, string Description = default, double? ExtendedCost = default, double? InternalCurrencyBillableAmount = default, double? InternalCurrencyUnitPrice = default, string InternalPurchaseOrderNumber = default, bool? IsBillableToCompany = default, bool? IsBilled = default, string Name = default, string Notes = default, int? OrganizationalLevelAssociationID = default, long? ProductID = default, string PurchaseOrderNumber = default, long? Status = default, long? StatusLastModifiedBy = default, DateTime? StatusLastModifiedDate = default, double? UnitCost = default, double? UnitPrice = default, double? UnitQuantity = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BillableAmount = BillableAmount;
			this.BillingCodeID = BillingCodeID;
			this.ChargeType = ChargeType;
			this.ContractID = ContractID;
			this.ContractServiceBundleID = ContractServiceBundleID;
			this.ContractServiceID = ContractServiceID;
			this.CreateDate = CreateDate;
			this.CreatorResourceID = CreatorResourceID;
			this.DatePurchased = DatePurchased;
			this.Description = Description;
			this.ExtendedCost = ExtendedCost;
			this.InternalCurrencyBillableAmount = InternalCurrencyBillableAmount;
			this.InternalCurrencyUnitPrice = InternalCurrencyUnitPrice;
			this.InternalPurchaseOrderNumber = InternalPurchaseOrderNumber;
			this.IsBillableToCompany = IsBillableToCompany;
			this.IsBilled = IsBilled;
			this.Name = Name;
			this.Notes = Notes;
			this.OrganizationalLevelAssociationID = OrganizationalLevelAssociationID;
			this.ProductID = ProductID;
			this.PurchaseOrderNumber = PurchaseOrderNumber;
			this.Status = Status;
			this.StatusLastModifiedBy = StatusLastModifiedBy;
			this.StatusLastModifiedDate = StatusLastModifiedDate;
			this.UnitCost = UnitCost;
			this.UnitPrice = UnitPrice;
			this.UnitQuantity = UnitQuantity;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BillableAmount
		/// </summary>
		[DataMember(Name = "BillableAmount", EmitDefaultValue = false)]
		public double? BillableAmount { get; set; }

		/// <summary>
		/// Gets or Sets BillingCodeID
		/// </summary>
		[DataMember(Name = "BillingCodeID", EmitDefaultValue = false)]
		public long? BillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets ChargeType
		/// </summary>
		[DataMember(Name = "ChargeType", EmitDefaultValue = false)]
		public int? ChargeType { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public long? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceBundleID
		/// </summary>
		[DataMember(Name = "ContractServiceBundleID", EmitDefaultValue = false)]
		public long? ContractServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceID
		/// </summary>
		[DataMember(Name = "ContractServiceID", EmitDefaultValue = false)]
		public long? ContractServiceID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate", EmitDefaultValue = false)]
		public DateTime? CreateDate { get; set; }

		/// <summary>
		/// Gets or Sets CreatorResourceID
		/// </summary>
		[DataMember(Name = "CreatorResourceID", EmitDefaultValue = false)]
		public long? CreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets DatePurchased
		/// </summary>
		[DataMember(Name = "DatePurchased", EmitDefaultValue = false)]
		public DateTime? DatePurchased { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets ExtendedCost
		/// </summary>
		[DataMember(Name = "ExtendedCost", EmitDefaultValue = false)]
		public double? ExtendedCost { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyBillableAmount
		/// </summary>
		[DataMember(Name = "InternalCurrencyBillableAmount", EmitDefaultValue = false)]
		public double? InternalCurrencyBillableAmount { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyUnitPrice
		/// </summary>
		[DataMember(Name = "InternalCurrencyUnitPrice", EmitDefaultValue = false)]
		public double? InternalCurrencyUnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets InternalPurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "InternalPurchaseOrderNumber", EmitDefaultValue = false)]
		public string InternalPurchaseOrderNumber { get; set; }

		/// <summary>
		/// Gets or Sets IsBillableToCompany
		/// </summary>
		[DataMember(Name = "IsBillableToCompany", EmitDefaultValue = false)]
		public bool? IsBillableToCompany { get; set; }

		/// <summary>
		/// Gets or Sets IsBilled
		/// </summary>
		[DataMember(Name = "IsBilled", EmitDefaultValue = false)]
		public bool? IsBilled { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets Notes
		/// </summary>
		[DataMember(Name = "Notes", EmitDefaultValue = false)]
		public string Notes { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public long? ProductID { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public long? Status { get; set; }

		/// <summary>
		/// Gets or Sets StatusLastModifiedBy
		/// </summary>
		[DataMember(Name = "StatusLastModifiedBy", EmitDefaultValue = false)]
		public long? StatusLastModifiedBy { get; set; }

		/// <summary>
		/// Gets or Sets StatusLastModifiedDate
		/// </summary>
		[DataMember(Name = "StatusLastModifiedDate", EmitDefaultValue = false)]
		public DateTime? StatusLastModifiedDate { get; set; }

		/// <summary>
		/// Gets or Sets UnitCost
		/// </summary>
		[DataMember(Name = "UnitCost", EmitDefaultValue = false)]
		public double? UnitCost { get; set; }

		/// <summary>
		/// Gets or Sets UnitPrice
		/// </summary>
		[DataMember(Name = "UnitPrice", EmitDefaultValue = false)]
		public double? UnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets UnitQuantity
		/// </summary>
		[DataMember(Name = "UnitQuantity", EmitDefaultValue = false)]
		public double? UnitQuantity { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContractCostInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
