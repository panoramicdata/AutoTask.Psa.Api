namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ChecklistLibraryChecklistItemModel
/// </summary>
[DataContract]
public class ChecklistLibraryChecklistItemModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ChecklistLibraryID
	/// </summary>
	[DataMember(Name = "ChecklistLibraryID")]
	public int? ChecklistLibraryID { get; set; }

	/// <summary>
	/// Gets or Sets IsImportant
	/// </summary>
	[DataMember(Name = "IsImportant")]
	public bool? IsImportant { get; set; }

	/// <summary>
	/// Gets or Sets ItemName
	/// </summary>
	[DataMember(Name = "ItemName")]
	public string ItemName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets KnowledgebaseArticleID
	/// </summary>
	[DataMember(Name = "KnowledgebaseArticleID")]
	public int? KnowledgebaseArticleID { get; set; }

	/// <summary>
	/// Gets or Sets Position
	/// </summary>
	[DataMember(Name = "Position")]
	public int? Position { get; set; }
}
