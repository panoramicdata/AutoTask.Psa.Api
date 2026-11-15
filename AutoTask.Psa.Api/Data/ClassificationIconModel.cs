namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ClassificationIconModel
/// </summary>
[DataContract]
public class ClassificationIconModel : DescribedNamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets IsSystem
	/// </summary>
	[DataMember(Name = "IsSystem")]
	public bool? IsSystem { get; set; }

	/// <summary>
	/// Gets or Sets RelativeUrl
	/// </summary>
	[DataMember(Name = "RelativeUrl")]
	public string RelativeUrl { get; set; } = string.Empty;
}
