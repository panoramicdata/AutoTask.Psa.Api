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
		/// Initializes a new instance of the <see cref="ProjectModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ActualBilledHours">ActualBilledHours.</param>
		/// <param name="ActualHours">ActualHours.</param>
		/// <param name="ChangeOrdersBudget">ChangeOrdersBudget.</param>
		/// <param name="ChangeOrdersRevenue">ChangeOrdersRevenue.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="CompanyOwnerResourceID">CompanyOwnerResourceID.</param>
		/// <param name="CompletedDateTime">CompletedDateTime.</param>
		/// <param name="CompletedPercentage">CompletedPercentage.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="CreateDateTime">CreateDateTime.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="Department">Department.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Duration">Duration.</param>
		/// <param name="EndDateTime">EndDateTime.</param>
		/// <param name="EstimatedSalesCost">EstimatedSalesCost.</param>
		/// <param name="EstimatedTime">EstimatedTime.</param>
		/// <param name="ExtProjectNumber">ExtProjectNumber.</param>
		/// <param name="ExtProjectType">ExtProjectType.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="LaborEstimatedCosts">LaborEstimatedCosts.</param>
		/// <param name="LaborEstimatedMarginPercentage">LaborEstimatedMarginPercentage.</param>
		/// <param name="LaborEstimatedRevenue">LaborEstimatedRevenue.</param>
		/// <param name="LastActivityDateTime">LastActivityDateTime.</param>
		/// <param name="LastActivityPersonType">LastActivityPersonType.</param>
		/// <param name="LastActivityResourceID">LastActivityResourceID.</param>
		/// <param name="OrganizationalLevelAssociationID">OrganizationalLevelAssociationID.</param>
		/// <param name="OriginalEstimatedRevenue">OriginalEstimatedRevenue.</param>
		/// <param name="ProjectCostEstimatedMarginPercentage">ProjectCostEstimatedMarginPercentage.</param>
		/// <param name="ProjectCostsBudget">ProjectCostsBudget.</param>
		/// <param name="ProjectCostsRevenue">ProjectCostsRevenue.</param>
		/// <param name="ProjectLeadResourceID">ProjectLeadResourceID.</param>
		/// <param name="ProjectName">ProjectName.</param>
		/// <param name="ProjectNumber">ProjectNumber.</param>
		/// <param name="ProjectType">ProjectType.</param>
		/// <param name="PurchaseOrderNumber">PurchaseOrderNumber.</param>
		/// <param name="SGDA">SGDA.</param>
		/// <param name="StartDateTime">StartDateTime.</param>
		/// <param name="Status">Status.</param>
		/// <param name="StatusDateTime">StatusDateTime.</param>
		/// <param name="StatusDetail">StatusDetail.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ProjectModel(long? Id = default, double? ActualBilledHours = default, double? ActualHours = default, double? ChangeOrdersBudget = default, double? ChangeOrdersRevenue = default, int? CompanyID = default, int? CompanyOwnerResourceID = default, DateTime? CompletedDateTime = default, int? CompletedPercentage = default, int? ContractID = default, DateTime? CreateDateTime = default, int? CreatorResourceID = default, int? Department = default, string Description = default, int? Duration = default, DateTime? EndDateTime = default, double? EstimatedSalesCost = default, double? EstimatedTime = default, string ExtProjectNumber = default, int? ExtProjectType = default, int? ImpersonatorCreatorResourceID = default, double? LaborEstimatedCosts = default, double? LaborEstimatedMarginPercentage = default, double? LaborEstimatedRevenue = default, DateTime? LastActivityDateTime = default, int? LastActivityPersonType = default, int? LastActivityResourceID = default, int? OrganizationalLevelAssociationID = default, double? OriginalEstimatedRevenue = default, double? ProjectCostEstimatedMarginPercentage = default, double? ProjectCostsBudget = default, double? ProjectCostsRevenue = default, int? ProjectLeadResourceID = default, string ProjectName = default, string ProjectNumber = default, int? ProjectType = default, string PurchaseOrderNumber = default, double? SGDA = default, DateTime? StartDateTime = default, int? Status = default, DateTime? StatusDateTime = default, string StatusDetail = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ActualBilledHours = ActualBilledHours;
			this.ActualHours = ActualHours;
			this.ChangeOrdersBudget = ChangeOrdersBudget;
			this.ChangeOrdersRevenue = ChangeOrdersRevenue;
			this.CompanyID = CompanyID;
			this.CompanyOwnerResourceID = CompanyOwnerResourceID;
			this.CompletedDateTime = CompletedDateTime;
			this.CompletedPercentage = CompletedPercentage;
			this.ContractID = ContractID;
			this.CreateDateTime = CreateDateTime;
			this.CreatorResourceID = CreatorResourceID;
			this.Department = Department;
			this.Description = Description;
			this.Duration = Duration;
			this.EndDateTime = EndDateTime;
			this.EstimatedSalesCost = EstimatedSalesCost;
			this.EstimatedTime = EstimatedTime;
			this.ExtProjectNumber = ExtProjectNumber;
			this.ExtProjectType = ExtProjectType;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.LaborEstimatedCosts = LaborEstimatedCosts;
			this.LaborEstimatedMarginPercentage = LaborEstimatedMarginPercentage;
			this.LaborEstimatedRevenue = LaborEstimatedRevenue;
			this.LastActivityDateTime = LastActivityDateTime;
			this.LastActivityPersonType = LastActivityPersonType;
			this.LastActivityResourceID = LastActivityResourceID;
			this.OrganizationalLevelAssociationID = OrganizationalLevelAssociationID;
			this.OriginalEstimatedRevenue = OriginalEstimatedRevenue;
			this.ProjectCostEstimatedMarginPercentage = ProjectCostEstimatedMarginPercentage;
			this.ProjectCostsBudget = ProjectCostsBudget;
			this.ProjectCostsRevenue = ProjectCostsRevenue;
			this.ProjectLeadResourceID = ProjectLeadResourceID;
			this.ProjectName = ProjectName;
			this.ProjectNumber = ProjectNumber;
			this.ProjectType = ProjectType;
			this.PurchaseOrderNumber = PurchaseOrderNumber;
			this.SGDA = SGDA;
			this.StartDateTime = StartDateTime;
			this.Status = Status;
			this.StatusDateTime = StatusDateTime;
			this.StatusDetail = StatusDetail;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		public string Description { get; set; }

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
		public string ExtProjectNumber { get; set; }

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
		public string ProjectName { get; set; }

		/// <summary>
		/// Gets or Sets ProjectNumber
		/// </summary>
		[DataMember(Name = "ProjectNumber", EmitDefaultValue = false)]
		public string ProjectNumber { get; set; }

		/// <summary>
		/// Gets or Sets ProjectType
		/// </summary>
		[DataMember(Name = "ProjectType", EmitDefaultValue = false)]
		public int? ProjectType { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; }

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
		public string StatusDetail { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
