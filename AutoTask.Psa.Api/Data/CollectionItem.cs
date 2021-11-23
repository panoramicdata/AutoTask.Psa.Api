namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CollectionItem
/// </summary>
[DataContract]
public partial class CollectionItem
{
	/// <summary>
	/// Gets or Sets IntegerValue
	/// </summary>
	[DataMember(Name = "IntegerValue")]
	public int? IntegerValue { get; set; }

	/// <summary>
	/// Gets or Sets StringValue
	/// </summary>
	[DataMember(Name = "StringValue")]
	public string StringValue { get; set; } = string.Empty;
}
