namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Fields shared by every entity that hangs off a webhook.
/// </summary>
[DataContract]
public abstract class WebhookChildModelBase
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets WebhookID
	/// </summary>
	[DataMember(Name = "WebhookID")]
	public int? WebhookID { get; set; }

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
