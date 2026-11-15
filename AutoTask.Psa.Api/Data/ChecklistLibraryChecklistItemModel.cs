namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ChecklistLibraryChecklistItemModel
/// </summary>
[DataContract]
public class ChecklistLibraryChecklistItemModel : ChecklistItemModelBase
{
	/// <summary>
	/// Gets or Sets ChecklistLibraryID
	/// </summary>
	[DataMember(Name = "ChecklistLibraryID")]
	public int? ChecklistLibraryID { get; set; }
}
