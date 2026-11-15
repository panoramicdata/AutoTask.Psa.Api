namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Fields shared by every entity that hangs off a webhook.
/// </summary>
[DataContract]
public abstract class WebhookChildModelBase : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets WebhookID
	/// </summary>
	[DataMember(Name = "WebhookID")]
	public int? WebhookID { get; set; }
}
