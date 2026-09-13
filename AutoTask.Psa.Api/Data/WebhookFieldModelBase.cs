namespace AutoTask.Psa.Api.Data;

/// <summary>
/// A field subscribed to by a webhook, as defined for both Company and Contact webhooks.
/// </summary>
public abstract class WebhookFieldModelBase : WebhookChildModelBase
{
	/// <summary>
	/// Gets or Sets FieldID
	/// </summary>
	[DataMember(Name = "FieldID")]
	public int? FieldID { get; set; }

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
