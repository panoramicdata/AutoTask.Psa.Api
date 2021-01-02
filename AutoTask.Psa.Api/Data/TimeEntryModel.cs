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
		public string InternalNotes { get; set; } = string.Empty;

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
		public string SummaryNotes { get; set; } = string.Empty;

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
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
