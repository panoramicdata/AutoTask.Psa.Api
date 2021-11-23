namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ServiceCallModel
/// </summary>
[DataContract]
public partial class ServiceCallModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets CancelationNoticeHours
	/// </summary>
	[DataMember(Name = "CancelationNoticeHours")]
	public double? CancelationNoticeHours { get; set; }

	/// <summary>
	/// Gets or Sets CanceledByResourceID
	/// </summary>
	[DataMember(Name = "CanceledByResourceID")]
	public int? CanceledByResourceID { get; set; }

	/// <summary>
	/// Gets or Sets CanceledDateTime
	/// </summary>
	[DataMember(Name = "CanceledDateTime")]
	public DateTime? CanceledDateTime { get; set; }

	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets CompanyLocationID
	/// </summary>
	[DataMember(Name = "CompanyLocationID")]
	public int? CompanyLocationID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDateTime
	/// </summary>
	[DataMember(Name = "CreateDateTime")]
	public DateTime? CreateDateTime { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public int? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Duration
	/// </summary>
	[DataMember(Name = "Duration")]
	public double? Duration { get; set; }

	/// <summary>
	/// Gets or Sets EndDateTime
	/// </summary>
	[DataMember(Name = "EndDateTime")]
	public DateTime? EndDateTime { get; set; }

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets IsComplete
	/// </summary>
	[DataMember(Name = "IsComplete")]
	public int? IsComplete { get; set; }

	/// <summary>
	/// Gets or Sets LastModifiedDateTime
	/// </summary>
	[DataMember(Name = "LastModifiedDateTime")]
	public DateTime? LastModifiedDateTime { get; set; }

	/// <summary>
	/// Gets or Sets StartDateTime
	/// </summary>
	[DataMember(Name = "StartDateTime")]
	public DateTime? StartDateTime { get; set; }

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
