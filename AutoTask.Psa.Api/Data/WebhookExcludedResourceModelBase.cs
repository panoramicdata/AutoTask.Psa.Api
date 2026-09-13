namespace AutoTask.Psa.Api.Data;

/// <summary>
/// A resource excluded from a webhook, as defined for both Company and Contact webhooks.
/// </summary>
public abstract class WebhookExcludedResourceModelBase : WebhookChildModelBase
{
	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public int? ResourceID { get; set; }
}
