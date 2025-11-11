namespace AutoTask.Psa.Api.Data;

/// <summary>
/// InventoryItemModel
/// </summary>
[DataContract]
public class InventoryItemModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets BackOrderQuantity
	/// </summary>
	[DataMember(Name = "BackOrderQuantity")]
	public int? BackOrderQuantity { get; set; }

	/// <summary>
	/// Gets or Sets Bin
	/// </summary>
	[DataMember(Name = "Bin")]
	public string Bin { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets InventoryLocationID
	/// </summary>
	[DataMember(Name = "InventoryLocationID")]
	public int? InventoryLocationID { get; set; }

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets QuantityMaximum
	/// </summary>
	[DataMember(Name = "QuantityMaximum")]
	public int? QuantityMaximum { get; set; }

	/// <summary>
	/// Gets or Sets QuantityMinimum
	/// </summary>
	[DataMember(Name = "QuantityMinimum")]
	public int? QuantityMinimum { get; set; }

	/// <summary>
	/// Gets or Sets QuantityOnHand
	/// </summary>
	[DataMember(Name = "QuantityOnHand")]
	public int? QuantityOnHand { get; set; }

	/// <summary>
	/// Gets or Sets QuantityOnOrder
	/// </summary>
	[DataMember(Name = "QuantityOnOrder")]
	public int? QuantityOnOrder { get; set; }

	/// <summary>
	/// Gets or Sets QuantityPicked
	/// </summary>
	[DataMember(Name = "QuantityPicked")]
	public int? QuantityPicked { get; set; }

	/// <summary>
	/// Gets or Sets QuantityReserved
	/// </summary>
	[DataMember(Name = "QuantityReserved")]
	public int? QuantityReserved { get; set; }

	/// <summary>
	/// Gets or Sets ReferenceNumber
	/// </summary>
	[DataMember(Name = "ReferenceNumber")]
	public string ReferenceNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
