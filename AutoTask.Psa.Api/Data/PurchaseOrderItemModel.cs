namespace AutoTask.Psa.Api.Data;

/// <summary>
/// PurchaseOrderItemModel
/// </summary>
[DataContract]
public class PurchaseOrderItemModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ChargeID
	/// </summary>
	[DataMember(Name = "ChargeID")]
	public int? ChargeID { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public long? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets EstimatedArrivalDate
	/// </summary>
	[DataMember(Name = "EstimatedArrivalDate")]
	public DateTime? EstimatedArrivalDate { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyUnitCost
	/// </summary>
	[DataMember(Name = "InternalCurrencyUnitCost")]
	public double? InternalCurrencyUnitCost { get; set; }

	/// <summary>
	/// Gets or Sets InventoryLocationID
	/// </summary>
	[DataMember(Name = "InventoryLocationID")]
	public int? InventoryLocationID { get; set; }

	/// <summary>
	/// Gets or Sets Memo
	/// </summary>
	[DataMember(Name = "Memo")]
	public string Memo { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets OrderID
	/// </summary>
	[DataMember(Name = "OrderID")]
	public int? OrderID { get; set; }

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets ProjectID
	/// </summary>
	[DataMember(Name = "ProjectID")]
	public long? ProjectID { get; set; }

	/// <summary>
	/// Gets or Sets Quantity
	/// </summary>
	[DataMember(Name = "Quantity")]
	public int? Quantity { get; set; }

	/// <summary>
	/// Gets or Sets SalesOrderID
	/// </summary>
	[DataMember(Name = "SalesOrderID")]
	public long? SalesOrderID { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public long? TicketID { get; set; }

	/// <summary>
	/// Gets or Sets UnitCost
	/// </summary>
	[DataMember(Name = "UnitCost")]
	public double? UnitCost { get; set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
