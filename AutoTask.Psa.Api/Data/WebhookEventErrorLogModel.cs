namespace AutoTask.Psa.Api.Data;

/// <summary>
/// WebhookEventErrorLogModel
/// </summary>
[DataContract]
public class WebhookEventErrorLogModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AccountWebhookID
	/// </summary>
	[DataMember(Name = "AccountWebhookID")]
	public int? AccountWebhookID { get; set; }

	/// <summary>
	/// Gets or Sets ContactWebhookID
	/// </summary>
	[DataMember(Name = "ContactWebhookID")]
	public int? ContactWebhookID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDateTime
	/// </summary>
	[DataMember(Name = "CreateDateTime")]
	public DateTime? CreateDateTime { get; set; }

	/// <summary>
	/// Gets or Sets ErrorMessage
	/// </summary>
	[DataMember(Name = "ErrorMessage")]
	public string ErrorMessage { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Payload
	/// </summary>
	[DataMember(Name = "Payload")]
	public string Payload { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SequenceNumber
	/// </summary>
	[DataMember(Name = "SequenceNumber")]
	public int? SequenceNumber { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
