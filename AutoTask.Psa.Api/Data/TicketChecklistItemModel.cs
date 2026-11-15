namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketChecklistItemModel
/// </summary>
[DataContract]
public class TicketChecklistItemModel : ChecklistItemModelBase
{
	/// <summary>
	/// Gets or Sets CompletedByResourceID
	/// </summary>
	[DataMember(Name = "CompletedByResourceID")]
	public int? CompletedByResourceID { get; set; }

	/// <summary>
	/// Gets or Sets CompletedDateTime
	/// </summary>
	[DataMember(Name = "CompletedDateTime")]
	public DateTime? CompletedDateTime { get; set; }

	/// <summary>
	/// Gets or Sets IsCompleted
	/// </summary>
	[DataMember(Name = "IsCompleted")]
	public bool? IsCompleted { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }
}
