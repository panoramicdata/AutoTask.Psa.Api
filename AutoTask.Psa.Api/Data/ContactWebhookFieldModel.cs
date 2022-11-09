namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContactWebhookFieldModel
/// </summary>
[DataContract]
public class ContactWebhookFieldModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
