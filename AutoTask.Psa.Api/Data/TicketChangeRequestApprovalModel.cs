namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketChangeRequestApprovalModel
/// </summary>
[DataContract]
public class TicketChangeRequestApprovalModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ApproveRejectDateTime
	/// </summary>
	[DataMember(Name = "ApproveRejectDateTime")]
	public DateTime? ApproveRejectDateTime { get; set; }

	/// <summary>
	/// Gets or Sets ApproveRejectNote
	/// </summary>
	[DataMember(Name = "ApproveRejectNote")]
	public string ApproveRejectNote { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ContactID
	/// </summary>
	[DataMember(Name = "ContactID")]
	public int? ContactID { get; set; }

	/// <summary>
	/// Gets or Sets IsApproved
	/// </summary>
	[DataMember(Name = "IsApproved")]
	public bool? IsApproved { get; set; }

	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public int? ResourceID { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }
}
