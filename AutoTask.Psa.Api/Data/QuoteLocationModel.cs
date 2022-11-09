namespace AutoTask.Psa.Api.Data;

/// <summary>
/// QuoteLocationModel
/// </summary>
[DataContract]
public class QuoteLocationModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets Address1
	/// </summary>
	[DataMember(Name = "Address1")]
	public string Address1 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Address2
	/// </summary>
	[DataMember(Name = "Address2")]
	public string Address2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets City
	/// </summary>
	[DataMember(Name = "City")]
	public string City { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets PostalCode
	/// </summary>
	[DataMember(Name = "PostalCode")]
	public string PostalCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets State
	/// </summary>
	[DataMember(Name = "State")]
	public string State { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
