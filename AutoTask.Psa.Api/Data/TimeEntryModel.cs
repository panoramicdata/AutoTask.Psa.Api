using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TimeEntryModel
	/// </summary>
	[DataContract]
	public partial class TimeEntryModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TimeEntryModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BillingApprovalDateTime">BillingApprovalDateTime.</param>
		/// <param name="BillingApprovalLevelMostRecent">BillingApprovalLevelMostRecent.</param>
		/// <param name="BillingApprovalResourceID">BillingApprovalResourceID.</param>
		/// <param name="BillingCodeID">BillingCodeID.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="ContractServiceBundleID">ContractServiceBundleID.</param>
		/// <param name="ContractServiceID">ContractServiceID.</param>
		/// <param name="CreateDateTime">CreateDateTime.</param>
		/// <param name="CreatorUserID">CreatorUserID.</param>
		/// <param name="DateWorked">DateWorked.</param>
		/// <param name="EndDateTime">EndDateTime.</param>
		/// <param name="HoursToBill">HoursToBill.</param>
		/// <param name="HoursWorked">HoursWorked.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="ImpersonatorUpdaterResourceID">ImpersonatorUpdaterResourceID.</param>
		/// <param name="InternalBillingCodeID">InternalBillingCodeID.</param>
		/// <param name="InternalNotes">InternalNotes.</param>
		/// <param name="IsNonBillable">IsNonBillable.</param>
		/// <param name="LastModifiedDateTime">LastModifiedDateTime.</param>
		/// <param name="LastModifiedUserID">LastModifiedUserID.</param>
		/// <param name="OffsetHours">OffsetHours.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="RoleID">RoleID.</param>
		/// <param name="ShowOnInvoice">ShowOnInvoice.</param>
		/// <param name="StartDateTime">StartDateTime.</param>
		/// <param name="SummaryNotes">SummaryNotes.</param>
		/// <param name="TaskID">TaskID.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="TimeEntryType">TimeEntryType.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TimeEntryModel(long? Id = default, DateTime? BillingApprovalDateTime = default, int? BillingApprovalLevelMostRecent = default, int? BillingApprovalResourceID = default, int? BillingCodeID = default, int? ContractID = default, long? ContractServiceBundleID = default, long? ContractServiceID = default, DateTime? CreateDateTime = default, int? CreatorUserID = default, DateTime? DateWorked = default, DateTime? EndDateTime = default, double? HoursToBill = default, double? HoursWorked = default, int? ImpersonatorCreatorResourceID = default, int? ImpersonatorUpdaterResourceID = default, int? InternalBillingCodeID = default, string InternalNotes = default, bool? IsNonBillable = default, DateTime? LastModifiedDateTime = default, int? LastModifiedUserID = default, double? OffsetHours = default, int? ResourceID = default, int? RoleID = default, bool? ShowOnInvoice = default, DateTime? StartDateTime = default, string SummaryNotes = default, int? TaskID = default, int? TicketID = default, int? TimeEntryType = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BillingApprovalDateTime = BillingApprovalDateTime;
			this.BillingApprovalLevelMostRecent = BillingApprovalLevelMostRecent;
			this.BillingApprovalResourceID = BillingApprovalResourceID;
			this.BillingCodeID = BillingCodeID;
			this.ContractID = ContractID;
			this.ContractServiceBundleID = ContractServiceBundleID;
			this.ContractServiceID = ContractServiceID;
			this.CreateDateTime = CreateDateTime;
			this.CreatorUserID = CreatorUserID;
			this.DateWorked = DateWorked;
			this.EndDateTime = EndDateTime;
			this.HoursToBill = HoursToBill;
			this.HoursWorked = HoursWorked;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.ImpersonatorUpdaterResourceID = ImpersonatorUpdaterResourceID;
			this.InternalBillingCodeID = InternalBillingCodeID;
			this.InternalNotes = InternalNotes;
			this.IsNonBillable = IsNonBillable;
			this.LastModifiedDateTime = LastModifiedDateTime;
			this.LastModifiedUserID = LastModifiedUserID;
			this.OffsetHours = OffsetHours;
			this.ResourceID = ResourceID;
			this.RoleID = RoleID;
			this.ShowOnInvoice = ShowOnInvoice;
			this.StartDateTime = StartDateTime;
			this.SummaryNotes = SummaryNotes;
			this.TaskID = TaskID;
			this.TicketID = TicketID;
			this.TimeEntryType = TimeEntryType;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BillingApprovalDateTime
		/// </summary>
		[DataMember(Name = "BillingApprovalDateTime", EmitDefaultValue = false)]
		public DateTime? BillingApprovalDateTime { get; set; }

		/// <summary>
		/// Gets or Sets BillingApprovalLevelMostRecent
		/// </summary>
		[DataMember(Name = "BillingApprovalLevelMostRecent", EmitDefaultValue = false)]
		public int? BillingApprovalLevelMostRecent { get; set; }

		/// <summary>
		/// Gets or Sets BillingApprovalResourceID
		/// </summary>
		[DataMember(Name = "BillingApprovalResourceID", EmitDefaultValue = false)]
		public int? BillingApprovalResourceID { get; set; }

		/// <summary>
		/// Gets or Sets BillingCodeID
		/// </summary>
		[DataMember(Name = "BillingCodeID", EmitDefaultValue = false)]
		public int? BillingCodeID { get; set; }

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
		/// Gets or Sets CreateDateTime
		/// </summary>
		[DataMember(Name = "CreateDateTime", EmitDefaultValue = false)]
		public DateTime? CreateDateTime { get; set; }

		/// <summary>
		/// Gets or Sets CreatorUserID
		/// </summary>
		[DataMember(Name = "CreatorUserID", EmitDefaultValue = false)]
		public int? CreatorUserID { get; set; }

		/// <summary>
		/// Gets or Sets DateWorked
		/// </summary>
		[DataMember(Name = "DateWorked", EmitDefaultValue = false)]
		public DateTime? DateWorked { get; set; }

		/// <summary>
		/// Gets or Sets EndDateTime
		/// </summary>
		[DataMember(Name = "EndDateTime", EmitDefaultValue = false)]
		public DateTime? EndDateTime { get; set; }

		/// <summary>
		/// Gets or Sets HoursToBill
		/// </summary>
		[DataMember(Name = "HoursToBill", EmitDefaultValue = false)]
		public double? HoursToBill { get; set; }

		/// <summary>
		/// Gets or Sets HoursWorked
		/// </summary>
		[DataMember(Name = "HoursWorked", EmitDefaultValue = false)]
		public double? HoursWorked { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorUpdaterResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorUpdaterResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorUpdaterResourceID { get; set; }

		/// <summary>
		/// Gets or Sets InternalBillingCodeID
		/// </summary>
		[DataMember(Name = "InternalBillingCodeID", EmitDefaultValue = false)]
		public int? InternalBillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets InternalNotes
		/// </summary>
		[DataMember(Name = "InternalNotes", EmitDefaultValue = false)]
		public string InternalNotes { get; set; }

		/// <summary>
		/// Gets or Sets IsNonBillable
		/// </summary>
		[DataMember(Name = "IsNonBillable", EmitDefaultValue = false)]
		public bool? IsNonBillable { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedDateTime
		/// </summary>
		[DataMember(Name = "LastModifiedDateTime", EmitDefaultValue = false)]
		public DateTime? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedUserID
		/// </summary>
		[DataMember(Name = "LastModifiedUserID", EmitDefaultValue = false)]
		public int? LastModifiedUserID { get; set; }

		/// <summary>
		/// Gets or Sets OffsetHours
		/// </summary>
		[DataMember(Name = "OffsetHours", EmitDefaultValue = false)]
		public double? OffsetHours { get; set; }

		/// <summary>
		/// Gets or Sets ResourceID
		/// </summary>
		[DataMember(Name = "ResourceID", EmitDefaultValue = false)]
		public int? ResourceID { get; set; }

		/// <summary>
		/// Gets or Sets RoleID
		/// </summary>
		[DataMember(Name = "RoleID", EmitDefaultValue = false)]
		public int? RoleID { get; set; }

		/// <summary>
		/// Gets or Sets ShowOnInvoice
		/// </summary>
		[DataMember(Name = "ShowOnInvoice", EmitDefaultValue = false)]
		public bool? ShowOnInvoice { get; set; }

		/// <summary>
		/// Gets or Sets StartDateTime
		/// </summary>
		[DataMember(Name = "StartDateTime", EmitDefaultValue = false)]
		public DateTime? StartDateTime { get; set; }

		/// <summary>
		/// Gets or Sets SummaryNotes
		/// </summary>
		[DataMember(Name = "SummaryNotes", EmitDefaultValue = false)]
		public string SummaryNotes { get; set; }

		/// <summary>
		/// Gets or Sets TaskID
		/// </summary>
		[DataMember(Name = "TaskID", EmitDefaultValue = false)]
		public int? TaskID { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets TimeEntryType
		/// </summary>
		[DataMember(Name = "TimeEntryType", EmitDefaultValue = false)]
		public int? TimeEntryType { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
