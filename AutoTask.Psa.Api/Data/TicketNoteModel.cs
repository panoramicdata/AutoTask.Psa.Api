namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketNoteModel
/// </summary>
public class TicketNoteModel : NoteModelBase
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
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }
}
