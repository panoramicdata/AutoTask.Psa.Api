namespace AutoTask.Psa.Api.Data;

/// <summary>
/// PurchaseOrderItemReceivingModel
/// </summary>
[DataContract]
public class PurchaseOrderItemReceivingModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets PurchaseOrderItemID
	/// </summary>
	[DataMember(Name = "PurchaseOrderItemID")]
	public long? PurchaseOrderItemID { get; set; }

	/// <summary>
	/// Gets or Sets QuantityBackOrdered
	/// </summary>
	[DataMember(Name = "QuantityBackOrdered")]
	public int? QuantityBackOrdered { get; set; }

	/// <summary>
	/// Gets or Sets QuantityNowReceiving
	/// </summary>
	[DataMember(Name = "QuantityNowReceiving")]
	public int? QuantityNowReceiving { get; set; }

	/// <summary>
	/// Gets or Sets QuantityPreviouslyReceived
	/// </summary>
	[DataMember(Name = "QuantityPreviouslyReceived")]
	public int? QuantityPreviouslyReceived { get; set; }

	/// <summary>
	/// Gets or Sets ReceiveDate
	/// </summary>
	[DataMember(Name = "ReceiveDate")]
	public DateTime? ReceiveDate { get; set; }

	/// <summary>
	/// Gets or Sets ReceivedByResourceID
	/// </summary>
	[DataMember(Name = "ReceivedByResourceID")]
	public int? ReceivedByResourceID { get; set; }

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
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
