namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Properties common to the field metadata entities.
/// </summary>
[DataContract]
public abstract class FieldModelBase
{
	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Length
	/// </summary>
	[DataMember(Name = "Length")]
	public int? Length { get; set; }

	/// <summary>
	/// Gets or Sets IsRequired
	/// </summary>
	[DataMember(Name = "IsRequired")]
	public bool? IsRequired { get; set; }

	/// <summary>
	/// Gets or Sets IsReadOnly
	/// </summary>
	[DataMember(Name = "IsReadOnly")]
	public bool? IsReadOnly { get; set; }

	/// <summary>
	/// Gets or Sets IsQueryable
	/// </summary>
	[DataMember(Name = "IsQueryable")]
	public bool? IsQueryable { get; set; }

	/// <summary>
	/// Gets or Sets IsReference
	/// </summary>
	[DataMember(Name = "IsReference")]
	public bool? IsReference { get; set; }

	/// <summary>
	/// Gets or Sets ReferenceEntityType
	/// </summary>
	[DataMember(Name = "ReferenceEntityType")]
	public string ReferenceEntityType { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets IsPickList
	/// </summary>
	[DataMember(Name = "IsPickList")]
	public bool? IsPickList { get; set; }

	/// <summary>
	/// Gets or Sets PicklistValues
	/// </summary>
	[DataMember(Name = "PicklistValues")]
	public List<PickListValue> PicklistValues { get; set; } = [];

	/// <summary>
	/// Gets or Sets PicklistParentValueField
	/// </summary>
	[DataMember(Name = "PicklistParentValueField")]
	public string PicklistParentValueField { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets IsSupportedWebhookField
	/// </summary>
	[DataMember(Name = "IsSupportedWebhookField")]
	public object? IsSupportedWebhookField { get; set; }
}
