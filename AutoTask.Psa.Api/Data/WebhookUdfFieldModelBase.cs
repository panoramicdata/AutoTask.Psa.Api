namespace AutoTask.Psa.Api.Data;

/// <summary>
/// A user-defined field subscribed to by a webhook, as defined for both Company and Contact webhooks.
/// </summary>
public abstract class WebhookUdfFieldModelBase : WebhookChildModelBase
{
	/// <summary>
	/// Gets or Sets UdfFieldID
	/// </summary>
	[DataMember(Name = "UdfFieldID")]
	public int? UdfFieldID { get; set; }

	/// <summary>
	/// Gets or Sets IsDisplayAlwaysField
	/// </summary>
	[DataMember(Name = "IsDisplayAlwaysField")]
	public bool? IsDisplayAlwaysField { get; set; }

	/// <summary>
	/// Gets or Sets IsSubscribedField
	/// </summary>
	[DataMember(Name = "IsSubscribedField")]
	public bool? IsSubscribedField { get; set; }
}
