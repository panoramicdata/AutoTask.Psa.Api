namespace AutoTask.Psa.Api.Data;

/// <summary>
/// WorkTypeModifierModel
/// </summary>
[DataContract]
public class WorkTypeModifierModel : EntityModelBase
{
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
}
