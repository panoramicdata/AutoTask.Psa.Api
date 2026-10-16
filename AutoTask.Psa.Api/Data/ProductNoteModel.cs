namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ProductNoteModel
/// </summary>
public class ProductNoteModel : NoteModelBase
{
	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }
}
