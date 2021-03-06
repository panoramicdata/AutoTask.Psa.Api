using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ChangeOrderChargeModel
	/// </summary>
	[DataContract]
	public partial class ChangeOrderChargeModel
	{
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
		public int? BillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets ChangeOrderHours
		/// </summary>
		[DataMember(Name = "ChangeOrderHours", EmitDefaultValue = false)]
		public double? ChangeOrderHours { get; set; }

		/// <summary>
		/// Gets or Sets ChargeType
		/// </summary>
		[DataMember(Name = "ChargeType", EmitDefaultValue = false)]
		public int? ChargeType { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceBundleID
		/// </summary>
		[DataMember(Name = "ContractServiceBundleID", EmitDefaultValue = false)]
		public int? ContractServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceID
		/// </summary>
		[DataMember(Name = "ContractServiceID", EmitDefaultValue = false)]
		public int? ContractServiceID { get; set; }

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
		/// Gets or Sets DatePurchased
		/// </summary>
		[DataMember(Name = "DatePurchased", EmitDefaultValue = false)]
		public DateTime? DatePurchased { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; } = string.Empty;

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
		public string InternalPurchaseOrderNumber { get; set; } = string.Empty;

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
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Notes
		/// </summary>
		[DataMember(Name = "Notes", EmitDefaultValue = false)]
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public int? ProductID { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets StatusLastModifiedBy
		/// </summary>
		[DataMember(Name = "StatusLastModifiedBy", EmitDefaultValue = false)]
		public int? StatusLastModifiedBy { get; set; }

		/// <summary>
		/// Gets or Sets StatusLastModifiedDate
		/// </summary>
		[DataMember(Name = "StatusLastModifiedDate", EmitDefaultValue = false)]
		public DateTime? StatusLastModifiedDate { get; set; }

		/// <summary>
		/// Gets or Sets TaskID
		/// </summary>
		[DataMember(Name = "TaskID", EmitDefaultValue = false)]
		public int? TaskID { get; set; }

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
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
