using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ProjectModel
	/// </summary>
	[DataContract]
	public partial class ProjectModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ActualBilledHours
		/// </summary>
		[DataMember(Name = "ActualBilledHours", EmitDefaultValue = false)]
		public double? ActualBilledHours { get; set; }

		/// <summary>
		/// Gets or Sets ActualHours
		/// </summary>
		[DataMember(Name = "ActualHours", EmitDefaultValue = false)]
		public double? ActualHours { get; set; }

		/// <summary>
		/// Gets or Sets ChangeOrdersBudget
		/// </summary>
		[DataMember(Name = "ChangeOrdersBudget", EmitDefaultValue = false)]
		public double? ChangeOrdersBudget { get; set; }

		/// <summary>
		/// Gets or Sets ChangeOrdersRevenue
		/// </summary>
		[DataMember(Name = "ChangeOrdersRevenue", EmitDefaultValue = false)]
		public double? ChangeOrdersRevenue { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets CompanyOwnerResourceID
		/// </summary>
		[DataMember(Name = "CompanyOwnerResourceID", EmitDefaultValue = false)]
		public int? CompanyOwnerResourceID { get; set; }

		/// <summary>
		/// Gets or Sets CompletedDateTime
		/// </summary>
		[DataMember(Name = "CompletedDateTime", EmitDefaultValue = false)]
		public DateTime? CompletedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets CompletedPercentage
		/// </summary>
		[DataMember(Name = "CompletedPercentage", EmitDefaultValue = false)]
		public int? CompletedPercentage { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDateTime
		/// </summary>
		[DataMember(Name = "CreateDateTime", EmitDefaultValue = false)]
		public DateTime? CreateDateTime { get; set; }

		/// <summary>
		/// Gets or Sets CreatorResourceID
		/// </summary>
		[DataMember(Name = "CreatorResourceID", EmitDefaultValue = false)]
		public int? CreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets Department
		/// </summary>
		[DataMember(Name = "Department", EmitDefaultValue = false)]
		public int? Department { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Duration
		/// </summary>
		[DataMember(Name = "Duration", EmitDefaultValue = false)]
		public int? Duration { get; set; }

		/// <summary>
		/// Gets or Sets EndDateTime
		/// </summary>
		[DataMember(Name = "EndDateTime", EmitDefaultValue = false)]
		public DateTime? EndDateTime { get; set; }

		/// <summary>
		/// Gets or Sets EstimatedSalesCost
		/// </summary>
		[DataMember(Name = "EstimatedSalesCost", EmitDefaultValue = false)]
		public double? EstimatedSalesCost { get; set; }

		/// <summary>
		/// Gets or Sets EstimatedTime
		/// </summary>
		[DataMember(Name = "EstimatedTime", EmitDefaultValue = false)]
		public double? EstimatedTime { get; set; }

		/// <summary>
		/// Gets or Sets ExtProjectNumber
		/// </summary>
		[DataMember(Name = "ExtProjectNumber", EmitDefaultValue = false)]
		public string ExtProjectNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ExtProjectType
		/// </summary>
		[DataMember(Name = "ExtProjectType", EmitDefaultValue = false)]
		public int? ExtProjectType { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets LaborEstimatedCosts
		/// </summary>
		[DataMember(Name = "LaborEstimatedCosts", EmitDefaultValue = false)]
		public double? LaborEstimatedCosts { get; set; }

		/// <summary>
		/// Gets or Sets LaborEstimatedMarginPercentage
		/// </summary>
		[DataMember(Name = "LaborEstimatedMarginPercentage", EmitDefaultValue = false)]
		public double? LaborEstimatedMarginPercentage { get; set; }

		/// <summary>
		/// Gets or Sets LaborEstimatedRevenue
		/// </summary>
		[DataMember(Name = "LaborEstimatedRevenue", EmitDefaultValue = false)]
		public double? LaborEstimatedRevenue { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityDateTime
		/// </summary>
		[DataMember(Name = "LastActivityDateTime", EmitDefaultValue = false)]
		public DateTime? LastActivityDateTime { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityPersonType
		/// </summary>
		[DataMember(Name = "LastActivityPersonType", EmitDefaultValue = false)]
		public int? LastActivityPersonType { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityResourceID
		/// </summary>
		[DataMember(Name = "LastActivityResourceID", EmitDefaultValue = false)]
		public int? LastActivityResourceID { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets OriginalEstimatedRevenue
		/// </summary>
		[DataMember(Name = "OriginalEstimatedRevenue", EmitDefaultValue = false)]
		public double? OriginalEstimatedRevenue { get; set; }

		/// <summary>
		/// Gets or Sets ProjectCostEstimatedMarginPercentage
		/// </summary>
		[DataMember(Name = "ProjectCostEstimatedMarginPercentage", EmitDefaultValue = false)]
		public double? ProjectCostEstimatedMarginPercentage { get; set; }

		/// <summary>
		/// Gets or Sets ProjectCostsBudget
		/// </summary>
		[DataMember(Name = "ProjectCostsBudget", EmitDefaultValue = false)]
		public double? ProjectCostsBudget { get; set; }

		/// <summary>
		/// Gets or Sets ProjectCostsRevenue
		/// </summary>
		[DataMember(Name = "ProjectCostsRevenue", EmitDefaultValue = false)]
		public double? ProjectCostsRevenue { get; set; }

		/// <summary>
		/// Gets or Sets ProjectLeadResourceID
		/// </summary>
		[DataMember(Name = "ProjectLeadResourceID", EmitDefaultValue = false)]
		public int? ProjectLeadResourceID { get; set; }

		/// <summary>
		/// Gets or Sets ProjectName
		/// </summary>
		[DataMember(Name = "ProjectName", EmitDefaultValue = false)]
		public string ProjectName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ProjectNumber
		/// </summary>
		[DataMember(Name = "ProjectNumber", EmitDefaultValue = false)]
		public string ProjectNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ProjectType
		/// </summary>
		[DataMember(Name = "ProjectType", EmitDefaultValue = false)]
		public int? ProjectType { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets SGDA
		/// </summary>
		[DataMember(Name = "SGDA", EmitDefaultValue = false)]
		public double? SGDA { get; set; }

		/// <summary>
		/// Gets or Sets StartDateTime
		/// </summary>
		[DataMember(Name = "StartDateTime", EmitDefaultValue = false)]
		public DateTime? StartDateTime { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets StatusDateTime
		/// </summary>
		[DataMember(Name = "StatusDateTime", EmitDefaultValue = false)]
		public DateTime? StatusDateTime { get; set; }

		/// <summary>
		/// Gets or Sets StatusDetail
		/// </summary>
		[DataMember(Name = "StatusDetail", EmitDefaultValue = false)]
		public string StatusDetail { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
