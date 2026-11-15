namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Field
/// </summary>
[DataContract]
public class Field : FieldModelBase
{
	/// <summary>
	/// Gets or Sets Label
	/// </summary>
	[DataMember(Name = "Label")]
	public string Label { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[DataMember(Name = "Type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DefaultValue
	/// </summary>
	[DataMember(Name = "DefaultValue")]
	public string DefaultValue { get; set; } = string.Empty;
}
