namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketChecklistLibraryModel
/// </summary>
[DataContract]
public class TicketChecklistLibraryModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ChecklistLibraryID
	/// </summary>
	[DataMember(Name = "ChecklistLibraryID")]
	public int? ChecklistLibraryID { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }
}
