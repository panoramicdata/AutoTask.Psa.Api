namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ChangeRequestLinkModel
/// </summary>
[DataContract]
public partial class ChangeRequestLinkModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
