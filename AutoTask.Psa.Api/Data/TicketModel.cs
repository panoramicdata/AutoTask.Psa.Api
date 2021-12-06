namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketModel
/// </summary>
[DataContract]
public class TicketModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ApiVendorID
	/// </summary>
	[DataMember(Name = "ApiVendorID")]
	public int? ApiVendorID { get; set; }

	/// <summary>
	/// Gets or Sets AssignedResourceID
	/// </summary>
	[DataMember(Name = "AssignedResourceID")]
	public int? AssignedResourceID { get; set; }

	/// <summary>
	/// Gets or Sets AssignedResourceRoleID
	/// </summary>
	[DataMember(Name = "AssignedResourceRoleID")]
	public int? AssignedResourceRoleID { get; set; }

	/// <summary>
	/// Gets or Sets BillingCodeID
	/// </summary>
	[DataMember(Name = "BillingCodeID")]
	public int? BillingCodeID { get; set; }

	/// <summary>
	/// Gets or Sets ChangeApprovalBoard
	/// </summary>
	[DataMember(Name = "ChangeApprovalBoard")]
	public int? ChangeApprovalBoard { get; set; }

	/// <summary>
	/// Gets or Sets ChangeApprovalStatus
	/// </summary>
	[DataMember(Name = "ChangeApprovalStatus")]
	public int? ChangeApprovalStatus { get; set; }

	/// <summary>
	/// Gets or Sets ChangeApprovalType
	/// </summary>
	[DataMember(Name = "ChangeApprovalType")]
	public int? ChangeApprovalType { get; set; }

	/// <summary>
	/// Gets or Sets ChangeInfoField1
	/// </summary>
	[DataMember(Name = "ChangeInfoField1")]
	public string ChangeInfoField1 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ChangeInfoField2
	/// </summary>
	[DataMember(Name = "ChangeInfoField2")]
	public string ChangeInfoField2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ChangeInfoField3
	/// </summary>
	[DataMember(Name = "ChangeInfoField3")]
	public string ChangeInfoField3 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ChangeInfoField4
	/// </summary>
	[DataMember(Name = "ChangeInfoField4")]
	public string ChangeInfoField4 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ChangeInfoField5
	/// </summary>
	[DataMember(Name = "ChangeInfoField5")]
	public string ChangeInfoField5 { get; set; } = string.Empty;

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
	/// Gets or Sets CompletedByResourceID
	/// </summary>
	[DataMember(Name = "CompletedByResourceID")]
	public int? CompletedByResourceID { get; set; }

	/// <summary>
	/// Gets or Sets CompletedDate
	/// </summary>
	[DataMember(Name = "CompletedDate")]
	public DateTime? CompletedDate { get; set; }

	/// <summary>
	/// Gets or Sets ConfigurationItemID
	/// </summary>
	[DataMember(Name = "ConfigurationItemID")]
	public int? ConfigurationItemID { get; set; }

	/// <summary>
	/// Gets or Sets ContactID
	/// </summary>
	[DataMember(Name = "ContactID")]
	public int? ContactID { get; set; }

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
	/// Gets or Sets CreateDate
	/// </summary>
	[DataMember(Name = "CreateDate")]
	public DateTime? CreateDate { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public int? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets CreatorType
	/// </summary>
	[DataMember(Name = "CreatorType")]
	public int? CreatorType { get; set; }

	/// <summary>
	/// Gets or Sets CurrentServiceThermometerRating
	/// </summary>
	[DataMember(Name = "CurrentServiceThermometerRating")]
	public int? CurrentServiceThermometerRating { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DueDateTime
	/// </summary>
	[DataMember(Name = "DueDateTime")]
	public DateTime? DueDateTime { get; set; }

	/// <summary>
	/// Gets or Sets EstimatedHours
	/// </summary>
	[DataMember(Name = "EstimatedHours")]
	public double? EstimatedHours { get; set; }

	/// <summary>
	/// Gets or Sets ExternalID
	/// </summary>
	[DataMember(Name = "ExternalID")]
	public string ExternalID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets FirstResponseAssignedResourceID
	/// </summary>
	[DataMember(Name = "FirstResponseAssignedResourceID")]
	public int? FirstResponseAssignedResourceID { get; set; }

	/// <summary>
	/// Gets or Sets FirstResponseDateTime
	/// </summary>
	[DataMember(Name = "FirstResponseDateTime")]
	public DateTime? FirstResponseDateTime { get; set; }

	/// <summary>
	/// Gets or Sets FirstResponseDueDateTime
	/// </summary>
	[DataMember(Name = "FirstResponseDueDateTime")]
	public DateTime? FirstResponseDueDateTime { get; set; }

	/// <summary>
	/// Gets or Sets FirstResponseInitiatingResourceID
	/// </summary>
	[DataMember(Name = "FirstResponseInitiatingResourceID")]
	public int? FirstResponseInitiatingResourceID { get; set; }

	/// <summary>
	/// Gets or Sets HoursToBeScheduled
	/// </summary>
	[DataMember(Name = "HoursToBeScheduled")]
	public double? HoursToBeScheduled { get; set; }

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets IssueType
	/// </summary>
	[DataMember(Name = "IssueType")]
	public int? IssueType { get; set; }

	/// <summary>
	/// Gets or Sets LastActivityDate
	/// </summary>
	[DataMember(Name = "LastActivityDate")]
	public DateTime? LastActivityDate { get; set; }

	/// <summary>
	/// Gets or Sets LastActivityPersonType
	/// </summary>
	[DataMember(Name = "LastActivityPersonType")]
	public int? LastActivityPersonType { get; set; }

	/// <summary>
	/// Gets or Sets LastActivityResourceID
	/// </summary>
	[DataMember(Name = "LastActivityResourceID")]
	public int? LastActivityResourceID { get; set; }

	/// <summary>
	/// Gets or Sets LastCustomerNotificationDateTime
	/// </summary>
	[DataMember(Name = "LastCustomerNotificationDateTime")]
	public DateTime? LastCustomerNotificationDateTime { get; set; }

	/// <summary>
	/// Gets or Sets LastCustomerVisibleActivityDateTime
	/// </summary>
	[DataMember(Name = "LastCustomerVisibleActivityDateTime")]
	public DateTime? LastCustomerVisibleActivityDateTime { get; set; }

	/// <summary>
	/// Gets or Sets LastTrackedModificationDateTime
	/// </summary>
	[DataMember(Name = "LastTrackedModificationDateTime")]
	public DateTime? LastTrackedModificationDateTime { get; set; }

	/// <summary>
	/// Gets or Sets MonitorID
	/// </summary>
	[DataMember(Name = "MonitorID")]
	public int? MonitorID { get; set; }

	/// <summary>
	/// Gets or Sets MonitorTypeID
	/// </summary>
	[DataMember(Name = "MonitorTypeID")]
	public int? MonitorTypeID { get; set; }

	/// <summary>
	/// Gets or Sets OpportunityID
	/// </summary>
	[DataMember(Name = "OpportunityID")]
	public int? OpportunityID { get; set; }

	/// <summary>
	/// Gets or Sets OrganizationalLevelAssociationID
	/// </summary>
	[DataMember(Name = "OrganizationalLevelAssociationID")]
	public int? OrganizationalLevelAssociationID { get; set; }

	/// <summary>
	/// Gets or Sets PreviousServiceThermometerRating
	/// </summary>
	[DataMember(Name = "PreviousServiceThermometerRating")]
	public int? PreviousServiceThermometerRating { get; set; }

	/// <summary>
	/// Gets or Sets Priority
	/// </summary>
	[DataMember(Name = "Priority")]
	public int? Priority { get; set; }

	/// <summary>
	/// Gets or Sets ProblemTicketId
	/// </summary>
	[DataMember(Name = "ProblemTicketId")]
	public int? ProblemTicketId { get; set; }

	/// <summary>
	/// Gets or Sets ProjectID
	/// </summary>
	[DataMember(Name = "ProjectID")]
	public int? ProjectID { get; set; }

	/// <summary>
	/// Gets or Sets PurchaseOrderNumber
	/// </summary>
	[DataMember(Name = "PurchaseOrderNumber")]
	public string PurchaseOrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets QueueID
	/// </summary>
	[DataMember(Name = "QueueID")]
	public int? QueueID { get; set; }

	/// <summary>
	/// Gets or Sets Resolution
	/// </summary>
	[DataMember(Name = "Resolution")]
	public string Resolution { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ResolutionPlanDateTime
	/// </summary>
	[DataMember(Name = "ResolutionPlanDateTime")]
	public DateTime? ResolutionPlanDateTime { get; set; }

	/// <summary>
	/// Gets or Sets ResolutionPlanDueDateTime
	/// </summary>
	[DataMember(Name = "ResolutionPlanDueDateTime")]
	public DateTime? ResolutionPlanDueDateTime { get; set; }

	/// <summary>
	/// Gets or Sets ResolvedDateTime
	/// </summary>
	[DataMember(Name = "ResolvedDateTime")]
	public DateTime? ResolvedDateTime { get; set; }

	/// <summary>
	/// Gets or Sets ResolvedDueDateTime
	/// </summary>
	[DataMember(Name = "ResolvedDueDateTime")]
	public DateTime? ResolvedDueDateTime { get; set; }

	/// <summary>
	/// Gets or Sets RmaStatus
	/// </summary>
	[DataMember(Name = "RmaStatus")]
	public int? RmaStatus { get; set; }

	/// <summary>
	/// Gets or Sets RmaType
	/// </summary>
	[DataMember(Name = "RmaType")]
	public int? RmaType { get; set; }

	/// <summary>
	/// Gets or Sets RMMAlertID
	/// </summary>
	[DataMember(Name = "RMMAlertID")]
	public string RMMAlertID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ServiceLevelAgreementHasBeenMet
	/// </summary>
	[DataMember(Name = "ServiceLevelAgreementHasBeenMet")]
	public bool? ServiceLevelAgreementHasBeenMet { get; set; }

	/// <summary>
	/// Gets or Sets ServiceLevelAgreementID
	/// </summary>
	[DataMember(Name = "ServiceLevelAgreementID")]
	public int? ServiceLevelAgreementID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceLevelAgreementPausedNextEventHours
	/// </summary>
	[DataMember(Name = "ServiceLevelAgreementPausedNextEventHours")]
	public double? ServiceLevelAgreementPausedNextEventHours { get; set; }

	/// <summary>
	/// Gets or Sets ServiceThermometerTemperature
	/// </summary>
	[DataMember(Name = "ServiceThermometerTemperature")]
	public int? ServiceThermometerTemperature { get; set; }

	/// <summary>
	/// Gets or Sets Source
	/// </summary>
	[DataMember(Name = "Source")]
	public int? Source { get; set; }

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

	/// <summary>
	/// Gets or Sets SubIssueType
	/// </summary>
	[DataMember(Name = "SubIssueType")]
	public int? SubIssueType { get; set; }

	/// <summary>
	/// Gets or Sets TicketCategory
	/// </summary>
	[DataMember(Name = "TicketCategory")]
	public int? TicketCategory { get; set; }

	/// <summary>
	/// Gets or Sets TicketNumber
	/// </summary>
	[DataMember(Name = "TicketNumber")]
	public string TicketNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TicketType
	/// </summary>
	[DataMember(Name = "TicketType")]
	public int? TicketType { get; set; }

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "Title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
