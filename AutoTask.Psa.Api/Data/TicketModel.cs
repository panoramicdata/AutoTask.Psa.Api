using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TicketModel
	/// </summary>
	[DataContract]
	public partial class TicketModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ApiVendorID
		/// </summary>
		[DataMember(Name = "ApiVendorID", EmitDefaultValue = false)]
		public int? ApiVendorID { get; set; }

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
		/// Gets or Sets ChangeApprovalBoard
		/// </summary>
		[DataMember(Name = "ChangeApprovalBoard", EmitDefaultValue = false)]
		public int? ChangeApprovalBoard { get; set; }

		/// <summary>
		/// Gets or Sets ChangeApprovalStatus
		/// </summary>
		[DataMember(Name = "ChangeApprovalStatus", EmitDefaultValue = false)]
		public int? ChangeApprovalStatus { get; set; }

		/// <summary>
		/// Gets or Sets ChangeApprovalType
		/// </summary>
		[DataMember(Name = "ChangeApprovalType", EmitDefaultValue = false)]
		public int? ChangeApprovalType { get; set; }

		/// <summary>
		/// Gets or Sets ChangeInfoField1
		/// </summary>
		[DataMember(Name = "ChangeInfoField1", EmitDefaultValue = false)]
		public string ChangeInfoField1 { get; set; }

		/// <summary>
		/// Gets or Sets ChangeInfoField2
		/// </summary>
		[DataMember(Name = "ChangeInfoField2", EmitDefaultValue = false)]
		public string ChangeInfoField2 { get; set; }

		/// <summary>
		/// Gets or Sets ChangeInfoField3
		/// </summary>
		[DataMember(Name = "ChangeInfoField3", EmitDefaultValue = false)]
		public string ChangeInfoField3 { get; set; }

		/// <summary>
		/// Gets or Sets ChangeInfoField4
		/// </summary>
		[DataMember(Name = "ChangeInfoField4", EmitDefaultValue = false)]
		public string ChangeInfoField4 { get; set; }

		/// <summary>
		/// Gets or Sets ChangeInfoField5
		/// </summary>
		[DataMember(Name = "ChangeInfoField5", EmitDefaultValue = false)]
		public string ChangeInfoField5 { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

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
		/// Gets or Sets CompletedDate
		/// </summary>
		[DataMember(Name = "CompletedDate", EmitDefaultValue = false)]
		public DateTime? CompletedDate { get; set; }

		/// <summary>
		/// Gets or Sets ConfigurationItemID
		/// </summary>
		[DataMember(Name = "ConfigurationItemID", EmitDefaultValue = false)]
		public int? ConfigurationItemID { get; set; }

		/// <summary>
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public int? ContactID { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceBundleID
		/// </summary>
		[DataMember(Name = "ContractServiceBundleID", EmitDefaultValue = false)]
		public long? ContractServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceID
		/// </summary>
		[DataMember(Name = "ContractServiceID", EmitDefaultValue = false)]
		public long? ContractServiceID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate", EmitDefaultValue = false)]
		public DateTime? CreateDate { get; set; }

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
		/// Gets or Sets CurrentServiceThermometerRating
		/// </summary>
		[DataMember(Name = "CurrentServiceThermometerRating", EmitDefaultValue = false)]
		public int? CurrentServiceThermometerRating { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets DueDateTime
		/// </summary>
		[DataMember(Name = "DueDateTime", EmitDefaultValue = false)]
		public DateTime? DueDateTime { get; set; }

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
		/// Gets or Sets FirstResponseAssignedResourceID
		/// </summary>
		[DataMember(Name = "FirstResponseAssignedResourceID", EmitDefaultValue = false)]
		public int? FirstResponseAssignedResourceID { get; set; }

		/// <summary>
		/// Gets or Sets FirstResponseDateTime
		/// </summary>
		[DataMember(Name = "FirstResponseDateTime", EmitDefaultValue = false)]
		public DateTime? FirstResponseDateTime { get; set; }

		/// <summary>
		/// Gets or Sets FirstResponseDueDateTime
		/// </summary>
		[DataMember(Name = "FirstResponseDueDateTime", EmitDefaultValue = false)]
		public DateTime? FirstResponseDueDateTime { get; set; }

		/// <summary>
		/// Gets or Sets FirstResponseInitiatingResourceID
		/// </summary>
		[DataMember(Name = "FirstResponseInitiatingResourceID", EmitDefaultValue = false)]
		public int? FirstResponseInitiatingResourceID { get; set; }

		/// <summary>
		/// Gets or Sets HoursToBeScheduled
		/// </summary>
		[DataMember(Name = "HoursToBeScheduled", EmitDefaultValue = false)]
		public double? HoursToBeScheduled { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets IssueType
		/// </summary>
		[DataMember(Name = "IssueType", EmitDefaultValue = false)]
		public int? IssueType { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityDate
		/// </summary>
		[DataMember(Name = "LastActivityDate", EmitDefaultValue = false)]
		public DateTime? LastActivityDate { get; set; }

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
		/// Gets or Sets LastCustomerNotificationDateTime
		/// </summary>
		[DataMember(Name = "LastCustomerNotificationDateTime", EmitDefaultValue = false)]
		public DateTime? LastCustomerNotificationDateTime { get; set; }

		/// <summary>
		/// Gets or Sets LastCustomerVisibleActivityDateTime
		/// </summary>
		[DataMember(Name = "LastCustomerVisibleActivityDateTime", EmitDefaultValue = false)]
		public DateTime? LastCustomerVisibleActivityDateTime { get; set; }

		/// <summary>
		/// Gets or Sets LastTrackedModificationDateTime
		/// </summary>
		[DataMember(Name = "LastTrackedModificationDateTime", EmitDefaultValue = false)]
		public DateTime? LastTrackedModificationDateTime { get; set; }

		/// <summary>
		/// Gets or Sets MonitorID
		/// </summary>
		[DataMember(Name = "MonitorID", EmitDefaultValue = false)]
		public int? MonitorID { get; set; }

		/// <summary>
		/// Gets or Sets MonitorTypeID
		/// </summary>
		[DataMember(Name = "MonitorTypeID", EmitDefaultValue = false)]
		public int? MonitorTypeID { get; set; }

		/// <summary>
		/// Gets or Sets OpportunityID
		/// </summary>
		[DataMember(Name = "OpportunityID", EmitDefaultValue = false)]
		public int? OpportunityID { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets PreviousServiceThermometerRating
		/// </summary>
		[DataMember(Name = "PreviousServiceThermometerRating", EmitDefaultValue = false)]
		public int? PreviousServiceThermometerRating { get; set; }

		/// <summary>
		/// Gets or Sets Priority
		/// </summary>
		[DataMember(Name = "Priority", EmitDefaultValue = false)]
		public int? Priority { get; set; }

		/// <summary>
		/// Gets or Sets ProblemTicketId
		/// </summary>
		[DataMember(Name = "ProblemTicketId", EmitDefaultValue = false)]
		public int? ProblemTicketId { get; set; }

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
		/// Gets or Sets QueueID
		/// </summary>
		[DataMember(Name = "QueueID", EmitDefaultValue = false)]
		public int? QueueID { get; set; }

		/// <summary>
		/// Gets or Sets Resolution
		/// </summary>
		[DataMember(Name = "Resolution", EmitDefaultValue = false)]
		public string Resolution { get; set; }

		/// <summary>
		/// Gets or Sets ResolutionPlanDateTime
		/// </summary>
		[DataMember(Name = "ResolutionPlanDateTime", EmitDefaultValue = false)]
		public DateTime? ResolutionPlanDateTime { get; set; }

		/// <summary>
		/// Gets or Sets ResolutionPlanDueDateTime
		/// </summary>
		[DataMember(Name = "ResolutionPlanDueDateTime", EmitDefaultValue = false)]
		public DateTime? ResolutionPlanDueDateTime { get; set; }

		/// <summary>
		/// Gets or Sets ResolvedDateTime
		/// </summary>
		[DataMember(Name = "ResolvedDateTime", EmitDefaultValue = false)]
		public DateTime? ResolvedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets ResolvedDueDateTime
		/// </summary>
		[DataMember(Name = "ResolvedDueDateTime", EmitDefaultValue = false)]
		public DateTime? ResolvedDueDateTime { get; set; }

		/// <summary>
		/// Gets or Sets RmaStatus
		/// </summary>
		[DataMember(Name = "RmaStatus", EmitDefaultValue = false)]
		public int? RmaStatus { get; set; }

		/// <summary>
		/// Gets or Sets RmaType
		/// </summary>
		[DataMember(Name = "RmaType", EmitDefaultValue = false)]
		public int? RmaType { get; set; }

		/// <summary>
		/// Gets or Sets RMMAlertID
		/// </summary>
		[DataMember(Name = "RMMAlertID", EmitDefaultValue = false)]
		public string RMMAlertID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceLevelAgreementHasBeenMet
		/// </summary>
		[DataMember(Name = "ServiceLevelAgreementHasBeenMet", EmitDefaultValue = false)]
		public bool? ServiceLevelAgreementHasBeenMet { get; set; }

		/// <summary>
		/// Gets or Sets ServiceLevelAgreementID
		/// </summary>
		[DataMember(Name = "ServiceLevelAgreementID", EmitDefaultValue = false)]
		public int? ServiceLevelAgreementID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceLevelAgreementPausedNextEventHours
		/// </summary>
		[DataMember(Name = "ServiceLevelAgreementPausedNextEventHours", EmitDefaultValue = false)]
		public double? ServiceLevelAgreementPausedNextEventHours { get; set; }

		/// <summary>
		/// Gets or Sets ServiceThermometerTemperature
		/// </summary>
		[DataMember(Name = "ServiceThermometerTemperature", EmitDefaultValue = false)]
		public int? ServiceThermometerTemperature { get; set; }

		/// <summary>
		/// Gets or Sets Source
		/// </summary>
		[DataMember(Name = "Source", EmitDefaultValue = false)]
		public int? Source { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets SubIssueType
		/// </summary>
		[DataMember(Name = "SubIssueType", EmitDefaultValue = false)]
		public int? SubIssueType { get; set; }

		/// <summary>
		/// Gets or Sets TicketCategory
		/// </summary>
		[DataMember(Name = "TicketCategory", EmitDefaultValue = false)]
		public int? TicketCategory { get; set; }

		/// <summary>
		/// Gets or Sets TicketNumber
		/// </summary>
		[DataMember(Name = "TicketNumber", EmitDefaultValue = false)]
		public string TicketNumber { get; set; }

		/// <summary>
		/// Gets or Sets TicketType
		/// </summary>
		[DataMember(Name = "TicketType", EmitDefaultValue = false)]
		public int? TicketType { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
