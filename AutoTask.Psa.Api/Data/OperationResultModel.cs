namespace AutoTask.Psa.Api.Data;

/// <summary>
/// OperationResultModel
/// </summary>
[DataContract]
public class OperationResultModel
{
	/// <summary>
	/// Gets or Sets ItemId
	/// </summary>
	[DataMember(Name = "ItemId")]
	public long? ItemId { get; set; }
}
