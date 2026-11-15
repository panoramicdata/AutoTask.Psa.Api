namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ChangeRequestLinkModel
/// </summary>
[DataContract]
public class ChangeRequestLinkModel : EntityModelBase
{
	/// <summary>
	/// Gets or Sets ChangeRequestTicketID
	/// </summary>
	[DataMember(Name = "ChangeRequestTicketID")]
	public int? ChangeRequestTicketID { get; set; }

	/// <summary>
	/// Gets or Sets ProblemOrIncidentTicketID
	/// </summary>
	[DataMember(Name = "ProblemOrIncidentTicketID")]
	public int? ProblemOrIncidentTicketID { get; set; }
}
