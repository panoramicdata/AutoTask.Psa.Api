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
