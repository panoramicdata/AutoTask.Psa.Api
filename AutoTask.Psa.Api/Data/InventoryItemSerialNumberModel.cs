namespace AutoTask.Psa.Api.Data;

/// <summary>
/// InventoryItemSerialNumberModel
/// </summary>
[DataContract]
public class InventoryItemSerialNumberModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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
