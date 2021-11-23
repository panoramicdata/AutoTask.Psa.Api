namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TimeEntryModel
/// </summary>
[DataContract]
public partial class TimeEntryModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets BillingApprovalDateTime
	/// </summary>
	[DataMember(Name = "BillingApprovalDateTime")]
	public DateTime? BillingApprovalDateTime { get; set; }

	/// <summary>
	/// Gets or Sets BillingApprovalLevelMostRecent
	/// </summary>
	[DataMember(Name = "BillingApprovalLevelMostRecent")]
	public int? BillingApprovalLevelMostRecent { get; set; }

	/// <summary>
	/// Gets or Sets BillingApprovalResourceID
	/// </summary>
	[DataMember(Name = "BillingApprovalResourceID")]
	public int? BillingApprovalResourceID { get; set; }

	/// <summary>
	/// Gets or Sets BillingCodeID
	/// </summary>
	[DataMember(Name = "BillingCodeID")]
	public int? BillingCodeID { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets ContractServiceBundleID
	/// </summary>
	[DataMember(Name = "ContractServiceBundleID")]
	public long? ContractServiceBundleID { get; set; }

	/// <summary>
	/// Gets or Sets ContractServiceID
	/// </summary>
	[DataMember(Name = "ContractServiceID")]
	public long? ContractServiceID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDateTime
	/// </summary>
	[DataMember(Name = "CreateDateTime")]
	public DateTime? CreateDateTime { get; set; }

	/// <summary>
	/// Gets or Sets CreatorUserID
	/// </summary>
	[DataMember(Name = "CreatorUserID")]
	public int? CreatorUserID { get; set; }

	/// <summary>
	/// Gets or Sets DateWorked
	/// </summary>
	[DataMember(Name = "DateWorked")]
	public DateTime? DateWorked { get; set; }

	/// <summary>
	/// Gets or Sets EndDateTime
	/// </summary>
	[DataMember(Name = "EndDateTime")]
	public DateTime? EndDateTime { get; set; }

	/// <summary>
	/// Gets or Sets HoursToBill
	/// </summary>
	[DataMember(Name = "HoursToBill")]
	public double? HoursToBill { get; set; }

	/// <summary>
	/// Gets or Sets HoursWorked
	/// </summary>
	[DataMember(Name = "HoursWorked")]
	public double? HoursWorked { get; set; }

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets ImpersonatorUpdaterResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorUpdaterResourceID")]
	public int? ImpersonatorUpdaterResourceID { get; set; }

	/// <summary>
	/// Gets or Sets InternalBillingCodeID
	/// </summary>
	[DataMember(Name = "InternalBillingCodeID")]
	public int? InternalBillingCodeID { get; set; }

	/// <summary>
	/// Gets or Sets InternalNotes
	/// </summary>
	[DataMember(Name = "InternalNotes")]
	public string InternalNotes { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets IsNonBillable
	/// </summary>
	[DataMember(Name = "IsNonBillable")]
	public bool? IsNonBillable { get; set; }

	/// <summary>
	/// Gets or Sets LastModifiedDateTime
	/// </summary>
	[DataMember(Name = "LastModifiedDateTime")]
	public DateTime? LastModifiedDateTime { get; set; }

	/// <summary>
	/// Gets or Sets LastModifiedUserID
	/// </summary>
	[DataMember(Name = "LastModifiedUserID")]
	public int? LastModifiedUserID { get; set; }

	/// <summary>
	/// Gets or Sets OffsetHours
	/// </summary>
	[DataMember(Name = "OffsetHours")]
	public double? OffsetHours { get; set; }

	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public int? ResourceID { get; set; }

	/// <summary>
	/// Gets or Sets RoleID
	/// </summary>
	[DataMember(Name = "RoleID")]
	public int? RoleID { get; set; }

	/// <summary>
	/// Gets or Sets ShowOnInvoice
	/// </summary>
	[DataMember(Name = "ShowOnInvoice")]
	public bool? ShowOnInvoice { get; set; }

	/// <summary>
	/// Gets or Sets StartDateTime
	/// </summary>
	[DataMember(Name = "StartDateTime")]
	public DateTime? StartDateTime { get; set; }

	/// <summary>
	/// Gets or Sets SummaryNotes
	/// </summary>
	[DataMember(Name = "SummaryNotes")]
	public string SummaryNotes { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TaskID
	/// </summary>
	[DataMember(Name = "TaskID")]
	public int? TaskID { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }

	/// <summary>
	/// Gets or Sets TimeEntryType
	/// </summary>
	[DataMember(Name = "TimeEntryType")]
	public int? TimeEntryType { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
