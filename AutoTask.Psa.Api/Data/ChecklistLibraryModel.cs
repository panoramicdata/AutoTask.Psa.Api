namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ChecklistLibraryModel
/// </summary>
[DataContract]
public class ChecklistLibraryModel : DescribedNamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets EntityType
	/// </summary>
	[DataMember(Name = "EntityType")]
	public int? EntityType { get; set; }
}
