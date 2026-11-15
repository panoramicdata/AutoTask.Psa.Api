namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ProjectNoteModel
/// </summary>
[DataContract]
public class ProjectNoteModel : NoteModelBase
{
	/// <summary>
	/// Gets or Sets IsAnnouncement
	/// </summary>
	[DataMember(Name = "IsAnnouncement")]
	public bool? IsAnnouncement { get; set; }

	/// <summary>
	/// Gets or Sets NoteType
	/// </summary>
	[DataMember(Name = "NoteType")]
	public int? NoteType { get; set; }

	/// <summary>
	/// Gets or Sets ProjectID
	/// </summary>
	[DataMember(Name = "ProjectID")]
	public int? ProjectID { get; set; }

	/// <summary>
	/// Gets or Sets Publish
	/// </summary>
	[DataMember(Name = "Publish")]
	public int? Publish { get; set; }
}
