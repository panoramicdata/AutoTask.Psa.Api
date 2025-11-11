namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TaskModel
/// </summary>
[DataContract]
public class TaskModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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
	/// Gets or Sets CanClientPortalUserCompleteTask
	/// </summary>
	[DataMember(Name = "CanClientPortalUserCompleteTask")]
	public bool? CanClientPortalUserCompleteTask { get; set; }

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
	/// Gets or Sets CompletedByType
	/// </summary>
	[DataMember(Name = "CompletedByType")]
	public int? CompletedByType { get; set; }

	/// <summary>
	/// Gets or Sets CompletedDateTime
	/// </summary>
	[DataMember(Name = "CompletedDateTime")]
	public DateTime? CompletedDateTime { get; set; }

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
	/// Gets or Sets CreatorType
	/// </summary>
	[DataMember(Name = "CreatorType")]
	public int? CreatorType { get; set; }

	/// <summary>
	/// Gets or Sets DepartmentID
	/// </summary>
	[DataMember(Name = "DepartmentID")]
	public int? DepartmentID { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets EndDateTime
	/// </summary>
	[DataMember(Name = "EndDateTime")]
	public DateTime? EndDateTime { get; set; }

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
	/// Gets or Sets HoursToBeScheduled
	/// </summary>
	[DataMember(Name = "HoursToBeScheduled")]
	public double? HoursToBeScheduled { get; set; }

	/// <summary>
	/// Gets or Sets IsTaskBillable
	/// </summary>
	[DataMember(Name = "IsTaskBillable")]
	public bool? IsTaskBillable { get; set; }

	/// <summary>
	/// Gets or Sets IsVisibleInClientPortal
	/// </summary>
	[DataMember(Name = "IsVisibleInClientPortal")]
	public bool? IsVisibleInClientPortal { get; set; }

	/// <summary>
	/// Gets or Sets LastActivityDateTime
	/// </summary>
	[DataMember(Name = "LastActivityDateTime")]
	public DateTime? LastActivityDateTime { get; set; }

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
	/// Gets or Sets PhaseID
	/// </summary>
	[DataMember(Name = "PhaseID")]
	public int? PhaseID { get; set; }

	/// <summary>
	/// Gets or Sets Priority
	/// </summary>
	[DataMember(Name = "Priority")]
	public int? Priority { get; set; }

	/// <summary>
	/// Gets or Sets PriorityLabel
	/// </summary>
	[DataMember(Name = "PriorityLabel")]
	public int? PriorityLabel { get; set; }

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
	/// Gets or Sets RemainingHours
	/// </summary>
	[DataMember(Name = "RemainingHours")]
	public double? RemainingHours { get; set; }

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
	/// Gets or Sets TaskCategoryID
	/// </summary>
	[DataMember(Name = "TaskCategoryID")]
	public int? TaskCategoryID { get; set; }

	/// <summary>
	/// Gets or Sets TaskNumber
	/// </summary>
	[DataMember(Name = "TaskNumber")]
	public string TaskNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TaskType
	/// </summary>
	[DataMember(Name = "TaskType")]
	public int? TaskType { get; set; }

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "Title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
