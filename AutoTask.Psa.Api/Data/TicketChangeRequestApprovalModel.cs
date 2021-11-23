namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketChangeRequestApprovalModel
/// </summary>
[DataContract]
public partial class TicketChangeRequestApprovalModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
