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
		/// Initializes a new instance of the <see cref="TicketModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ApiVendorID">ApiVendorID.</param>
		/// <param name="AssignedResourceID">AssignedResourceID.</param>
		/// <param name="AssignedResourceRoleID">AssignedResourceRoleID.</param>
		/// <param name="BillingCodeID">BillingCodeID.</param>
		/// <param name="ChangeApprovalBoard">ChangeApprovalBoard.</param>
		/// <param name="ChangeApprovalStatus">ChangeApprovalStatus.</param>
		/// <param name="ChangeApprovalType">ChangeApprovalType.</param>
		/// <param name="ChangeInfoField1">ChangeInfoField1.</param>
		/// <param name="ChangeInfoField2">ChangeInfoField2.</param>
		/// <param name="ChangeInfoField3">ChangeInfoField3.</param>
		/// <param name="ChangeInfoField4">ChangeInfoField4.</param>
		/// <param name="ChangeInfoField5">ChangeInfoField5.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="CompanyLocationID">CompanyLocationID.</param>
		/// <param name="CompletedByResourceID">CompletedByResourceID.</param>
		/// <param name="CompletedDate">CompletedDate.</param>
		/// <param name="ConfigurationItemID">ConfigurationItemID.</param>
		/// <param name="ContactID">ContactID.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="ContractServiceBundleID">ContractServiceBundleID.</param>
		/// <param name="ContractServiceID">ContractServiceID.</param>
		/// <param name="CreateDate">CreateDate.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="CreatorType">CreatorType.</param>
		/// <param name="CurrentServiceThermometerRating">CurrentServiceThermometerRating.</param>
		/// <param name="Description">Description.</param>
		/// <param name="DueDateTime">DueDateTime.</param>
		/// <param name="EstimatedHours">EstimatedHours.</param>
		/// <param name="ExternalID">ExternalID.</param>
		/// <param name="FirstResponseAssignedResourceID">FirstResponseAssignedResourceID.</param>
		/// <param name="FirstResponseDateTime">FirstResponseDateTime.</param>
		/// <param name="FirstResponseDueDateTime">FirstResponseDueDateTime.</param>
		/// <param name="FirstResponseInitiatingResourceID">FirstResponseInitiatingResourceID.</param>
		/// <param name="HoursToBeScheduled">HoursToBeScheduled.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="IssueType">IssueType.</param>
		/// <param name="LastActivityDate">LastActivityDate.</param>
		/// <param name="LastActivityPersonType">LastActivityPersonType.</param>
		/// <param name="LastActivityResourceID">LastActivityResourceID.</param>
		/// <param name="LastCustomerNotificationDateTime">LastCustomerNotificationDateTime.</param>
		/// <param name="LastCustomerVisibleActivityDateTime">LastCustomerVisibleActivityDateTime.</param>
		/// <param name="LastTrackedModificationDateTime">LastTrackedModificationDateTime.</param>
		/// <param name="MonitorID">MonitorID.</param>
		/// <param name="MonitorTypeID">MonitorTypeID.</param>
		/// <param name="OpportunityID">OpportunityID.</param>
		/// <param name="OrganizationalLevelAssociationID">OrganizationalLevelAssociationID.</param>
		/// <param name="PreviousServiceThermometerRating">PreviousServiceThermometerRating.</param>
		/// <param name="Priority">Priority.</param>
		/// <param name="ProblemTicketId">ProblemTicketId.</param>
		/// <param name="ProjectID">ProjectID.</param>
		/// <param name="PurchaseOrderNumber">PurchaseOrderNumber.</param>
		/// <param name="QueueID">QueueID.</param>
		/// <param name="Resolution">Resolution.</param>
		/// <param name="ResolutionPlanDateTime">ResolutionPlanDateTime.</param>
		/// <param name="ResolutionPlanDueDateTime">ResolutionPlanDueDateTime.</param>
		/// <param name="ResolvedDateTime">ResolvedDateTime.</param>
		/// <param name="ResolvedDueDateTime">ResolvedDueDateTime.</param>
		/// <param name="RmaStatus">RmaStatus.</param>
		/// <param name="RmaType">RmaType.</param>
		/// <param name="RMMAlertID">RMMAlertID.</param>
		/// <param name="ServiceLevelAgreementHasBeenMet">ServiceLevelAgreementHasBeenMet.</param>
		/// <param name="ServiceLevelAgreementID">ServiceLevelAgreementID.</param>
		/// <param name="ServiceLevelAgreementPausedNextEventHours">ServiceLevelAgreementPausedNextEventHours.</param>
		/// <param name="ServiceThermometerTemperature">ServiceThermometerTemperature.</param>
		/// <param name="Source">Source.</param>
		/// <param name="Status">Status.</param>
		/// <param name="SubIssueType">SubIssueType.</param>
		/// <param name="TicketCategory">TicketCategory.</param>
		/// <param name="TicketNumber">TicketNumber.</param>
		/// <param name="TicketType">TicketType.</param>
		/// <param name="Title">Title.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TicketModel(long? Id = default, int? ApiVendorID = default, int? AssignedResourceID = default, int? AssignedResourceRoleID = default, int? BillingCodeID = default, int? ChangeApprovalBoard = default, int? ChangeApprovalStatus = default, int? ChangeApprovalType = default, string ChangeInfoField1 = default, string ChangeInfoField2 = default, string ChangeInfoField3 = default, string ChangeInfoField4 = default, string ChangeInfoField5 = default, int? CompanyID = default, int? CompanyLocationID = default, int? CompletedByResourceID = default, DateTime? CompletedDate = default, int? ConfigurationItemID = default, int? ContactID = default, int? ContractID = default, long? ContractServiceBundleID = default, long? ContractServiceID = default, DateTime? CreateDate = default, int? CreatorResourceID = default, int? CreatorType = default, int? CurrentServiceThermometerRating = default, string Description = default, DateTime? DueDateTime = default, double? EstimatedHours = default, string ExternalID = default, int? FirstResponseAssignedResourceID = default, DateTime? FirstResponseDateTime = default, DateTime? FirstResponseDueDateTime = default, int? FirstResponseInitiatingResourceID = default, double? HoursToBeScheduled = default, int? ImpersonatorCreatorResourceID = default, int? IssueType = default, DateTime? LastActivityDate = default, int? LastActivityPersonType = default, int? LastActivityResourceID = default, DateTime? LastCustomerNotificationDateTime = default, DateTime? LastCustomerVisibleActivityDateTime = default, DateTime? LastTrackedModificationDateTime = default, int? MonitorID = default, int? MonitorTypeID = default, int? OpportunityID = default, int? OrganizationalLevelAssociationID = default, int? PreviousServiceThermometerRating = default, int? Priority = default, int? ProblemTicketId = default, int? ProjectID = default, string PurchaseOrderNumber = default, int? QueueID = default, string Resolution = default, DateTime? ResolutionPlanDateTime = default, DateTime? ResolutionPlanDueDateTime = default, DateTime? ResolvedDateTime = default, DateTime? ResolvedDueDateTime = default, int? RmaStatus = default, int? RmaType = default, string RMMAlertID = default, bool? ServiceLevelAgreementHasBeenMet = default, int? ServiceLevelAgreementID = default, double? ServiceLevelAgreementPausedNextEventHours = default, int? ServiceThermometerTemperature = default, int? Source = default, int? Status = default, int? SubIssueType = default, int? TicketCategory = default, string TicketNumber = default, int? TicketType = default, string Title = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ApiVendorID = ApiVendorID;
			this.AssignedResourceID = AssignedResourceID;
			this.AssignedResourceRoleID = AssignedResourceRoleID;
			this.BillingCodeID = BillingCodeID;
			this.ChangeApprovalBoard = ChangeApprovalBoard;
			this.ChangeApprovalStatus = ChangeApprovalStatus;
			this.ChangeApprovalType = ChangeApprovalType;
			this.ChangeInfoField1 = ChangeInfoField1;
			this.ChangeInfoField2 = ChangeInfoField2;
			this.ChangeInfoField3 = ChangeInfoField3;
			this.ChangeInfoField4 = ChangeInfoField4;
			this.ChangeInfoField5 = ChangeInfoField5;
			this.CompanyID = CompanyID;
			this.CompanyLocationID = CompanyLocationID;
			this.CompletedByResourceID = CompletedByResourceID;
			this.CompletedDate = CompletedDate;
			this.ConfigurationItemID = ConfigurationItemID;
			this.ContactID = ContactID;
			this.ContractID = ContractID;
			this.ContractServiceBundleID = ContractServiceBundleID;
			this.ContractServiceID = ContractServiceID;
			this.CreateDate = CreateDate;
			this.CreatorResourceID = CreatorResourceID;
			this.CreatorType = CreatorType;
			this.CurrentServiceThermometerRating = CurrentServiceThermometerRating;
			this.Description = Description;
			this.DueDateTime = DueDateTime;
			this.EstimatedHours = EstimatedHours;
			this.ExternalID = ExternalID;
			this.FirstResponseAssignedResourceID = FirstResponseAssignedResourceID;
			this.FirstResponseDateTime = FirstResponseDateTime;
			this.FirstResponseDueDateTime = FirstResponseDueDateTime;
			this.FirstResponseInitiatingResourceID = FirstResponseInitiatingResourceID;
			this.HoursToBeScheduled = HoursToBeScheduled;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.IssueType = IssueType;
			this.LastActivityDate = LastActivityDate;
			this.LastActivityPersonType = LastActivityPersonType;
			this.LastActivityResourceID = LastActivityResourceID;
			this.LastCustomerNotificationDateTime = LastCustomerNotificationDateTime;
			this.LastCustomerVisibleActivityDateTime = LastCustomerVisibleActivityDateTime;
			this.LastTrackedModificationDateTime = LastTrackedModificationDateTime;
			this.MonitorID = MonitorID;
			this.MonitorTypeID = MonitorTypeID;
			this.OpportunityID = OpportunityID;
			this.OrganizationalLevelAssociationID = OrganizationalLevelAssociationID;
			this.PreviousServiceThermometerRating = PreviousServiceThermometerRating;
			this.Priority = Priority;
			this.ProblemTicketId = ProblemTicketId;
			this.ProjectID = ProjectID;
			this.PurchaseOrderNumber = PurchaseOrderNumber;
			this.QueueID = QueueID;
			this.Resolution = Resolution;
			this.ResolutionPlanDateTime = ResolutionPlanDateTime;
			this.ResolutionPlanDueDateTime = ResolutionPlanDueDateTime;
			this.ResolvedDateTime = ResolvedDateTime;
			this.ResolvedDueDateTime = ResolvedDueDateTime;
			this.RmaStatus = RmaStatus;
			this.RmaType = RmaType;
			this.RMMAlertID = RMMAlertID;
			this.ServiceLevelAgreementHasBeenMet = ServiceLevelAgreementHasBeenMet;
			this.ServiceLevelAgreementID = ServiceLevelAgreementID;
			this.ServiceLevelAgreementPausedNextEventHours = ServiceLevelAgreementPausedNextEventHours;
			this.ServiceThermometerTemperature = ServiceThermometerTemperature;
			this.Source = Source;
			this.Status = Status;
			this.SubIssueType = SubIssueType;
			this.TicketCategory = TicketCategory;
			this.TicketNumber = TicketNumber;
			this.TicketType = TicketType;
			this.Title = Title;
			this.UserDefinedFields = UserDefinedFields;
		}

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
