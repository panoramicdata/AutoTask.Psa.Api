namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractNoteModel
/// </summary>
[DataContract]
public class ContractNoteModel : NoteModelBase
{
	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }
}
