namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ChecklistLibraryChecklistItemModel
/// </summary>
[DataContract]
public class ChecklistLibraryChecklistItemModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
