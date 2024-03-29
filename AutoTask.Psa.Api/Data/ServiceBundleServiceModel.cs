namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ServiceBundleServiceModel
/// </summary>
[DataContract]
public class ServiceBundleServiceModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ServiceBundleID
	/// </summary>
	[DataMember(Name = "ServiceBundleID")]
	public long? ServiceBundleID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceID
	/// </summary>
	[DataMember(Name = "ServiceID")]
	public long? ServiceID { get; set; }

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
