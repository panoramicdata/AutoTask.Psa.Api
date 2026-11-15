namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Fields shared by every note entity. AutoTask defines notes on products, projects, tickets,
/// tasks, contracts and configuration items with the same ten properties, so the shape lives
/// here once; each note type adds the identifier that ties it to its parent.
/// </summary>
[DataContract]
public abstract class NoteModelBase : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets CreateDateTime
	/// </summary>
	[DataMember(Name = "CreateDateTime")]
	public DateTime? CreateDateTime { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public int? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets ImpersonatorUpdaterResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorUpdaterResourceID")]
	public int? ImpersonatorUpdaterResourceID { get; set; }

	/// <summary>
	/// Gets or Sets LastActivityDate
	/// </summary>
	[DataMember(Name = "LastActivityDate")]
	public DateTime? LastActivityDate { get; set; }

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "Title")]
	public string Title { get; set; } = string.Empty;
}
