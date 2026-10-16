namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TaskNoteModel
/// </summary>
public class TaskNoteModel : NoteModelBase
{
	/// <summary>
	/// Gets or Sets NoteType
	/// </summary>
	[DataMember(Name = "NoteType")]
	public int? NoteType { get; set; }

	/// <summary>
	/// Gets or Sets Publish
	/// </summary>
	[DataMember(Name = "Publish")]
	public int? Publish { get; set; }

	/// <summary>
	/// Gets or Sets TaskID
	/// </summary>
	[DataMember(Name = "TaskID")]
	public int? TaskID { get; set; }
}
