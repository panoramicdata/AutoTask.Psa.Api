namespace AutoTask.Psa.Api.Data;

/// <summary>
/// WebhookEventErrorLogModel
/// </summary>
[DataContract]
public class WebhookEventErrorLogModel : EntityModelBase
{
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
}
