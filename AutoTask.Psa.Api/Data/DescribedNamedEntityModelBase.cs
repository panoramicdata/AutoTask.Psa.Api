namespace AutoTask.Psa.Api.Data;

/// <summary>
/// A named entity that also has a description.
/// </summary>
[DataContract]
public abstract class DescribedNamedEntityModelBase : NamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;
}
