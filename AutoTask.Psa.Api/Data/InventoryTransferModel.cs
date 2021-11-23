namespace AutoTask.Psa.Api.Data;

/// <summary>
/// InventoryTransferModel
/// </summary>
[DataContract]
public partial class InventoryTransferModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets FromLocationID
	/// </summary>
	[DataMember(Name = "FromLocationID")]
	public long? FromLocationID { get; set; }

	/// <summary>
	/// Gets or Sets Notes
	/// </summary>
	[DataMember(Name = "Notes")]
	public string Notes { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public long? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets QuantityTransferred
	/// </summary>
	[DataMember(Name = "QuantityTransferred")]
	public int? QuantityTransferred { get; set; }

	/// <summary>
	/// Gets or Sets SerialNumber
	/// </summary>
	[DataMember(Name = "SerialNumber")]
	public string SerialNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ToLocationID
	/// </summary>
	[DataMember(Name = "ToLocationID")]
	public long? ToLocationID { get; set; }

	/// <summary>
	/// Gets or Sets TransferByResourceID
	/// </summary>
	[DataMember(Name = "TransferByResourceID")]
	public int? TransferByResourceID { get; set; }

	/// <summary>
	/// Gets or Sets TransferDate
	/// </summary>
	[DataMember(Name = "TransferDate")]
	public DateTime? TransferDate { get; set; }

	/// <summary>
	/// Gets or Sets UpdateNote
	/// </summary>
	[DataMember(Name = "UpdateNote")]
	public string UpdateNote { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
