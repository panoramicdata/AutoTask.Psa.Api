namespace AutoTask.Psa.Api.Data;

/// <summary>
/// An entity with an active flag and a name.
/// </summary>
[DataContract]
public abstract class NamedEntityModelBase : EntityModelBase
{
	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;
}
