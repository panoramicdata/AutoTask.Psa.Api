namespace AutoTask.Psa.Api.Data;

/// <summary>
/// WorkTypeModifierModel
/// </summary>
[DataContract]
public partial class WorkTypeModifierModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ModifierType
	/// </summary>
	[DataMember(Name = "ModifierType")]
	public int? ModifierType { get; set; }

	/// <summary>
	/// Gets or Sets ModifierValue
	/// </summary>
	[DataMember(Name = "ModifierValue")]
	public double? ModifierValue { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
