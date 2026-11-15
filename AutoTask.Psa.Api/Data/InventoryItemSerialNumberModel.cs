namespace AutoTask.Psa.Api.Data;

/// <summary>
/// InventoryItemSerialNumberModel
/// </summary>
[DataContract]
public class InventoryItemSerialNumberModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets InventoryItemID
	/// </summary>
	[DataMember(Name = "InventoryItemID")]
	public long? InventoryItemID { get; set; }

	/// <summary>
	/// Gets or Sets SerialNumber
	/// </summary>
	[DataMember(Name = "SerialNumber")]
	public string SerialNumber { get; set; } = string.Empty;
}
