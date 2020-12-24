using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TaskModel
	/// </summary>
	[DataContract]
	public partial class TaskModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TaskModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AssignedResourceID">AssignedResourceID.</param>
		/// <param name="AssignedResourceRoleID">AssignedResourceRoleID.</param>
		/// <param name="BillingCodeID">BillingCodeID.</param>
		/// <param name="CanClientPortalUserCompleteTask">CanClientPortalUserCompleteTask.</param>
		/// <param name="CompanyLocationID">CompanyLocationID.</param>
		/// <param name="CompletedByResourceID">CompletedByResourceID.</param>
		/// <param name="CompletedByType">CompletedByType.</param>
		/// <param name="CompletedDateTime">CompletedDateTime.</param>
		/// <param name="CreateDateTime">CreateDateTime.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="CreatorType">CreatorType.</param>
		/// <param name="DepartmentID">DepartmentID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="EndDateTime">EndDateTime.</param>
		/// <param name="EstimatedHours">EstimatedHours.</param>
		/// <param name="ExternalID">ExternalID.</param>
		/// <param name="HoursToBeScheduled">HoursToBeScheduled.</param>
		/// <param name="IsTaskBillable">IsTaskBillable.</param>
		/// <param name="IsVisibleInClientPortal">IsVisibleInClientPortal.</param>
		/// <param name="LastActivityDateTime">LastActivityDateTime.</param>
		/// <param name="LastActivityPersonType">LastActivityPersonType.</param>
		/// <param name="LastActivityResourceID">LastActivityResourceID.</param>
		/// <param name="PhaseID">PhaseID.</param>
		/// <param name="Priority">Priority.</param>
		/// <param name="PriorityLabel">PriorityLabel.</param>
		/// <param name="ProjectID">ProjectID.</param>
		/// <param name="PurchaseOrderNumber">PurchaseOrderNumber.</param>
		/// <param name="RemainingHours">RemainingHours.</param>
		/// <param name="StartDateTime">StartDateTime.</param>
		/// <param name="Status">Status.</param>
		/// <param name="TaskCategoryID">TaskCategoryID.</param>
		/// <param name="TaskNumber">TaskNumber.</param>
		/// <param name="TaskType">TaskType.</param>
		/// <param name="Title">Title.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TaskModel(long? Id = default, int? AssignedResourceID = default, int? AssignedResourceRoleID = default, int? BillingCodeID = default, bool? CanClientPortalUserCompleteTask = default, int? CompanyLocationID = default, int? CompletedByResourceID = default, int? CompletedByType = default, DateTime? CompletedDateTime = default, DateTime? CreateDateTime = default, int? CreatorResourceID = default, int? CreatorType = default, int? DepartmentID = default, string Description = default, DateTime? EndDateTime = default, double? EstimatedHours = default, string ExternalID = default, double? HoursToBeScheduled = default, bool? IsTaskBillable = default, bool? IsVisibleInClientPortal = default, DateTime? LastActivityDateTime = default, int? LastActivityPersonType = default, int? LastActivityResourceID = default, int? PhaseID = default, int? Priority = default, int? PriorityLabel = default, int? ProjectID = default, string PurchaseOrderNumber = default, double? RemainingHours = default, DateTime? StartDateTime = default, int? Status = default, int? TaskCategoryID = default, string TaskNumber = default, int? TaskType = default, string Title = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AssignedResourceID = AssignedResourceID;
			this.AssignedResourceRoleID = AssignedResourceRoleID;
			this.BillingCodeID = BillingCodeID;
			this.CanClientPortalUserCompleteTask = CanClientPortalUserCompleteTask;
			this.CompanyLocationID = CompanyLocationID;
			this.CompletedByResourceID = CompletedByResourceID;
			this.CompletedByType = CompletedByType;
			this.CompletedDateTime = CompletedDateTime;
			this.CreateDateTime = CreateDateTime;
			this.CreatorResourceID = CreatorResourceID;
			this.CreatorType = CreatorType;
			this.DepartmentID = DepartmentID;
			this.Description = Description;
			this.EndDateTime = EndDateTime;
			this.EstimatedHours = EstimatedHours;
			this.ExternalID = ExternalID;
			this.HoursToBeScheduled = HoursToBeScheduled;
			this.IsTaskBillable = IsTaskBillable;
			this.IsVisibleInClientPortal = IsVisibleInClientPortal;
			this.LastActivityDateTime = LastActivityDateTime;
			this.LastActivityPersonType = LastActivityPersonType;
			this.LastActivityResourceID = LastActivityResourceID;
			this.PhaseID = PhaseID;
			this.Priority = Priority;
			this.PriorityLabel = PriorityLabel;
			this.ProjectID = ProjectID;
			this.PurchaseOrderNumber = PurchaseOrderNumber;
			this.RemainingHours = RemainingHours;
			this.StartDateTime = StartDateTime;
			this.Status = Status;
			this.TaskCategoryID = TaskCategoryID;
			this.TaskNumber = TaskNumber;
			this.TaskType = TaskType;
			this.Title = Title;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AssignedResourceID
		/// </summary>
		[DataMember(Name = "AssignedResourceID", EmitDefaultValue = false)]
		public int? AssignedResourceID { get; set; }

		/// <summary>
		/// Gets or Sets AssignedResourceRoleID
		/// </summary>
		[DataMember(Name = "AssignedResourceRoleID", EmitDefaultValue = false)]
		public int? AssignedResourceRoleID { get; set; }

		/// <summary>
		/// Gets or Sets BillingCodeID
		/// </summary>
		[DataMember(Name = "BillingCodeID", EmitDefaultValue = false)]
		public int? BillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets CanClientPortalUserCompleteTask
		/// </summary>
		[DataMember(Name = "CanClientPortalUserCompleteTask", EmitDefaultValue = false)]
		public bool? CanClientPortalUserCompleteTask { get; set; }

		/// <summary>
		/// Gets or Sets CompanyLocationID
		/// </summary>
		[DataMember(Name = "CompanyLocationID", EmitDefaultValue = false)]
		public int? CompanyLocationID { get; set; }

		/// <summary>
		/// Gets or Sets CompletedByResourceID
		/// </summary>
		[DataMember(Name = "CompletedByResourceID", EmitDefaultValue = false)]
		public int? CompletedByResourceID { get; set; }

		/// <summary>
		/// Gets or Sets CompletedByType
		/// </summary>
		[DataMember(Name = "CompletedByType", EmitDefaultValue = false)]
		public int? CompletedByType { get; set; }

		/// <summary>
		/// Gets or Sets CompletedDateTime
		/// </summary>
		[DataMember(Name = "CompletedDateTime", EmitDefaultValue = false)]
		public DateTime? CompletedDateTime { get; set; }

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
		/// Gets or Sets CreatorType
		/// </summary>
		[DataMember(Name = "CreatorType", EmitDefaultValue = false)]
		public int? CreatorType { get; set; }

		/// <summary>
		/// Gets or Sets DepartmentID
		/// </summary>
		[DataMember(Name = "DepartmentID", EmitDefaultValue = false)]
		public int? DepartmentID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets EndDateTime
		/// </summary>
		[DataMember(Name = "EndDateTime", EmitDefaultValue = false)]
		public DateTime? EndDateTime { get; set; }

		/// <summary>
		/// Gets or Sets EstimatedHours
		/// </summary>
		[DataMember(Name = "EstimatedHours", EmitDefaultValue = false)]
		public double? EstimatedHours { get; set; }

		/// <summary>
		/// Gets or Sets ExternalID
		/// </summary>
		[DataMember(Name = "ExternalID", EmitDefaultValue = false)]
		public string ExternalID { get; set; }

		/// <summary>
		/// Gets or Sets HoursToBeScheduled
		/// </summary>
		[DataMember(Name = "HoursToBeScheduled", EmitDefaultValue = false)]
		public double? HoursToBeScheduled { get; set; }

		/// <summary>
		/// Gets or Sets IsTaskBillable
		/// </summary>
		[DataMember(Name = "IsTaskBillable", EmitDefaultValue = false)]
		public bool? IsTaskBillable { get; set; }

		/// <summary>
		/// Gets or Sets IsVisibleInClientPortal
		/// </summary>
		[DataMember(Name = "IsVisibleInClientPortal", EmitDefaultValue = false)]
		public bool? IsVisibleInClientPortal { get; set; }

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
		/// Gets or Sets PhaseID
		/// </summary>
		[DataMember(Name = "PhaseID", EmitDefaultValue = false)]
		public int? PhaseID { get; set; }

		/// <summary>
		/// Gets or Sets Priority
		/// </summary>
		[DataMember(Name = "Priority", EmitDefaultValue = false)]
		public int? Priority { get; set; }

		/// <summary>
		/// Gets or Sets PriorityLabel
		/// </summary>
		[DataMember(Name = "PriorityLabel", EmitDefaultValue = false)]
		public int? PriorityLabel { get; set; }

		/// <summary>
		/// Gets or Sets ProjectID
		/// </summary>
		[DataMember(Name = "ProjectID", EmitDefaultValue = false)]
		public int? ProjectID { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Gets or Sets RemainingHours
		/// </summary>
		[DataMember(Name = "RemainingHours", EmitDefaultValue = false)]
		public double? RemainingHours { get; set; }

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
		/// Gets or Sets TaskCategoryID
		/// </summary>
		[DataMember(Name = "TaskCategoryID", EmitDefaultValue = false)]
		public int? TaskCategoryID { get; set; }

		/// <summary>
		/// Gets or Sets TaskNumber
		/// </summary>
		[DataMember(Name = "TaskNumber", EmitDefaultValue = false)]
		public string TaskNumber { get; set; }

		/// <summary>
		/// Gets or Sets TaskType
		/// </summary>
		[DataMember(Name = "TaskType", EmitDefaultValue = false)]
		public int? TaskType { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncTaskInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
