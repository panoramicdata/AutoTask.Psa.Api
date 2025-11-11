namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ProjectModel
/// </summary>
[DataContract]
public class ProjectModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ActualBilledHours
	/// </summary>
	[DataMember(Name = "ActualBilledHours")]
	public double? ActualBilledHours { get; set; }

	/// <summary>
	/// Gets or Sets ActualHours
	/// </summary>
	[DataMember(Name = "ActualHours")]
	public double? ActualHours { get; set; }

	/// <summary>
	/// Gets or Sets ChangeOrdersBudget
	/// </summary>
	[DataMember(Name = "ChangeOrdersBudget")]
	public double? ChangeOrdersBudget { get; set; }

	/// <summary>
	/// Gets or Sets ChangeOrdersRevenue
	/// </summary>
	[DataMember(Name = "ChangeOrdersRevenue")]
	public double? ChangeOrdersRevenue { get; set; }

	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets CompanyOwnerResourceID
	/// </summary>
	[DataMember(Name = "CompanyOwnerResourceID")]
	public int? CompanyOwnerResourceID { get; set; }

	/// <summary>
	/// Gets or Sets CompletedDateTime
	/// </summary>
	[DataMember(Name = "CompletedDateTime")]
	public DateTime? CompletedDateTime { get; set; }

	/// <summary>
	/// Gets or Sets CompletedPercentage
	/// </summary>
	[DataMember(Name = "CompletedPercentage")]
	public int? CompletedPercentage { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

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
	/// Gets or Sets Department
	/// </summary>
	[DataMember(Name = "Department")]
	public int? Department { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Duration
	/// </summary>
	[DataMember(Name = "Duration")]
	public int? Duration { get; set; }

	/// <summary>
	/// Gets or Sets EndDateTime
	/// </summary>
	[DataMember(Name = "EndDateTime")]
	public DateTime? EndDateTime { get; set; }

	/// <summary>
	/// Gets or Sets EstimatedSalesCost
	/// </summary>
	[DataMember(Name = "EstimatedSalesCost")]
	public double? EstimatedSalesCost { get; set; }

	/// <summary>
	/// Gets or Sets EstimatedTime
	/// </summary>
	[DataMember(Name = "EstimatedTime")]
	public double? EstimatedTime { get; set; }

	/// <summary>
	/// Gets or Sets ExtProjectNumber
	/// </summary>
	[DataMember(Name = "ExtProjectNumber")]
	public string ExtProjectNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ExtProjectType
	/// </summary>
	[DataMember(Name = "ExtProjectType")]
	public int? ExtProjectType { get; set; }

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets LaborEstimatedCosts
	/// </summary>
	[DataMember(Name = "LaborEstimatedCosts")]
	public double? LaborEstimatedCosts { get; set; }

	/// <summary>
	/// Gets or Sets LaborEstimatedMarginPercentage
	/// </summary>
	[DataMember(Name = "LaborEstimatedMarginPercentage")]
	public double? LaborEstimatedMarginPercentage { get; set; }

	/// <summary>
	/// Gets or Sets LaborEstimatedRevenue
	/// </summary>
	[DataMember(Name = "LaborEstimatedRevenue")]
	public double? LaborEstimatedRevenue { get; set; }

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
	/// Gets or Sets OrganizationalLevelAssociationID
	/// </summary>
	[DataMember(Name = "OrganizationalLevelAssociationID")]
	public int? OrganizationalLevelAssociationID { get; set; }

	/// <summary>
	/// Gets or Sets OriginalEstimatedRevenue
	/// </summary>
	[DataMember(Name = "OriginalEstimatedRevenue")]
	public double? OriginalEstimatedRevenue { get; set; }

	/// <summary>
	/// Gets or Sets ProjectCostEstimatedMarginPercentage
	/// </summary>
	[DataMember(Name = "ProjectCostEstimatedMarginPercentage")]
	public double? ProjectCostEstimatedMarginPercentage { get; set; }

	/// <summary>
	/// Gets or Sets ProjectCostsBudget
	/// </summary>
	[DataMember(Name = "ProjectCostsBudget")]
	public double? ProjectCostsBudget { get; set; }

	/// <summary>
	/// Gets or Sets ProjectCostsRevenue
	/// </summary>
	[DataMember(Name = "ProjectCostsRevenue")]
	public double? ProjectCostsRevenue { get; set; }

	/// <summary>
	/// Gets or Sets ProjectLeadResourceID
	/// </summary>
	[DataMember(Name = "ProjectLeadResourceID")]
	public int? ProjectLeadResourceID { get; set; }

	/// <summary>
	/// Gets or Sets ProjectName
	/// </summary>
	[DataMember(Name = "ProjectName")]
	public string ProjectName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ProjectNumber
	/// </summary>
	[DataMember(Name = "ProjectNumber")]
	public string ProjectNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ProjectType
	/// </summary>
	[DataMember(Name = "ProjectType")]
	public int? ProjectType { get; set; }

	/// <summary>
	/// Gets or Sets PurchaseOrderNumber
	/// </summary>
	[DataMember(Name = "PurchaseOrderNumber")]
	public string PurchaseOrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SGDA
	/// </summary>
	[DataMember(Name = "SGDA")]
	public double? SGDA { get; set; }

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
	/// Gets or Sets StatusDateTime
	/// </summary>
	[DataMember(Name = "StatusDateTime")]
	public DateTime? StatusDateTime { get; set; }

	/// <summary>
	/// Gets or Sets StatusDetail
	/// </summary>
	[DataMember(Name = "StatusDetail")]
	public string StatusDetail { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
