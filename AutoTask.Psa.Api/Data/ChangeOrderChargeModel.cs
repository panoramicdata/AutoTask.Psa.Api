namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ChangeOrderChargeModel
/// </summary>
[DataContract]
public class ChangeOrderChargeModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets BillableAmount
	/// </summary>
	[DataMember(Name = "BillableAmount")]
	public double? BillableAmount { get; set; }

	/// <summary>
	/// Gets or Sets BillingCodeID
	/// </summary>
	[DataMember(Name = "BillingCodeID")]
	public int? BillingCodeID { get; set; }

	/// <summary>
	/// Gets or Sets ChangeOrderHours
	/// </summary>
	[DataMember(Name = "ChangeOrderHours")]
	public double? ChangeOrderHours { get; set; }

	/// <summary>
	/// Gets or Sets ChargeType
	/// </summary>
	[DataMember(Name = "ChargeType")]
	public int? ChargeType { get; set; }

	/// <summary>
	/// Gets or Sets ContractServiceBundleID
	/// </summary>
	[DataMember(Name = "ContractServiceBundleID")]
	public int? ContractServiceBundleID { get; set; }

	/// <summary>
	/// Gets or Sets ContractServiceID
	/// </summary>
	[DataMember(Name = "ContractServiceID")]
	public int? ContractServiceID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDate
	/// </summary>
	[DataMember(Name = "CreateDate")]
	public DateTime? CreateDate { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public int? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets DatePurchased
	/// </summary>
	[DataMember(Name = "DatePurchased")]
	public DateTime? DatePurchased { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ExtendedCost
	/// </summary>
	[DataMember(Name = "ExtendedCost")]
	public double? ExtendedCost { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyBillableAmount
	/// </summary>
	[DataMember(Name = "InternalCurrencyBillableAmount")]
	public double? InternalCurrencyBillableAmount { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyUnitPrice
	/// </summary>
	[DataMember(Name = "InternalCurrencyUnitPrice")]
	public double? InternalCurrencyUnitPrice { get; set; }

	/// <summary>
	/// Gets or Sets InternalPurchaseOrderNumber
	/// </summary>
	[DataMember(Name = "InternalPurchaseOrderNumber")]
	public string InternalPurchaseOrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets IsBillableToCompany
	/// </summary>
	[DataMember(Name = "IsBillableToCompany")]
	public bool? IsBillableToCompany { get; set; }

	/// <summary>
	/// Gets or Sets IsBilled
	/// </summary>
	[DataMember(Name = "IsBilled")]
	public bool? IsBilled { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Notes
	/// </summary>
	[DataMember(Name = "Notes")]
	public string Notes { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets OrganizationalLevelAssociationID
	/// </summary>
	[DataMember(Name = "OrganizationalLevelAssociationID")]
	public int? OrganizationalLevelAssociationID { get; set; }

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets PurchaseOrderNumber
	/// </summary>
	[DataMember(Name = "PurchaseOrderNumber")]
	public string PurchaseOrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

	/// <summary>
	/// Gets or Sets StatusLastModifiedBy
	/// </summary>
	[DataMember(Name = "StatusLastModifiedBy")]
	public int? StatusLastModifiedBy { get; set; }

	/// <summary>
	/// Gets or Sets StatusLastModifiedDate
	/// </summary>
	[DataMember(Name = "StatusLastModifiedDate")]
	public DateTime? StatusLastModifiedDate { get; set; }

	/// <summary>
	/// Gets or Sets TaskID
	/// </summary>
	[DataMember(Name = "TaskID")]
	public int? TaskID { get; set; }

	/// <summary>
	/// Gets or Sets UnitCost
	/// </summary>
	[DataMember(Name = "UnitCost")]
	public double? UnitCost { get; set; }

	/// <summary>
	/// Gets or Sets UnitPrice
	/// </summary>
	[DataMember(Name = "UnitPrice")]
	public double? UnitPrice { get; set; }

	/// <summary>
	/// Gets or Sets UnitQuantity
	/// </summary>
	[DataMember(Name = "UnitQuantity")]
	public double? UnitQuantity { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
