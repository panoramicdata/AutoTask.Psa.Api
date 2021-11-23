namespace AutoTask.Psa.Api.Data;

/// <summary>
/// BillingItemApprovalLevelModel
/// </summary>
[DataContract]
public partial class BillingItemApprovalLevelModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ApprovalDateTime
	/// </summary>
	[DataMember(Name = "ApprovalDateTime")]
	public DateTime? ApprovalDateTime { get; set; }

	/// <summary>
	/// Gets or Sets ApprovalLevel
	/// </summary>
	[DataMember(Name = "ApprovalLevel")]
	public int? ApprovalLevel { get; set; }

	/// <summary>
	/// Gets or Sets ApprovalResourceID
	/// </summary>
	[DataMember(Name = "ApprovalResourceID")]
	public int? ApprovalResourceID { get; set; }

	/// <summary>
	/// Gets or Sets TimeEntryID
	/// </summary>
	[DataMember(Name = "TimeEntryID")]
	public int? TimeEntryID { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
