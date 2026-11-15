namespace AutoTask.Psa.Api.Data;

/// <summary>
/// BillingItemApprovalLevelModel
/// </summary>
[DataContract]
public class BillingItemApprovalLevelModel : EntityModelBase
{
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
}
