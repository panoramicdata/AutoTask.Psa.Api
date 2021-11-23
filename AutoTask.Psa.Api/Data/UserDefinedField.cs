namespace AutoTask.Psa.Api.Data;

/// <summary>
/// UserDefinedField
/// </summary>
[DataContract]
public partial class UserDefinedField
{
	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Value
	/// </summary>
	[DataMember(Name = "Value")]
	public string Value { get; set; } = string.Empty;
}
