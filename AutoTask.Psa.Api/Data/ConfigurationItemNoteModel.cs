namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ConfigurationItemNoteModel
/// </summary>
[DataContract]
public class ConfigurationItemNoteModel : NoteModelBase
{
	/// <summary>
	/// Gets or Sets ConfigurationItemID
	/// </summary>
	[DataMember(Name = "ConfigurationItemID")]
	public int? ConfigurationItemID { get; set; }

	/// <summary>
	/// Gets or Sets NoteType
	/// </summary>
	[DataMember(Name = "NoteType")]
	public int? NoteType { get; set; }
}
