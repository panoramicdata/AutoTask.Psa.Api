using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// NotificationHistoryModel
	/// </summary>
	[DataContract]
	public partial class NotificationHistoryModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID")]
		public long? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets EntityNumber
		/// </summary>
		[DataMember(Name = "EntityNumber")]
		public string EntityNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets EntityTitle
		/// </summary>
		[DataMember(Name = "EntityTitle")]
		public string EntityTitle { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets InitiatingContactID
		/// </summary>
		[DataMember(Name = "InitiatingContactID")]
		public long? InitiatingContactID { get; set; }

		/// <summary>
		/// Gets or Sets InitiatingResourceID
		/// </summary>
		[DataMember(Name = "InitiatingResourceID")]
		public long? InitiatingResourceID { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive")]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsDeleted
		/// </summary>
		[DataMember(Name = "IsDeleted")]
		public bool? IsDeleted { get; set; }

		/// <summary>
		/// Gets or Sets IsTemplateJob
		/// </summary>
		[DataMember(Name = "IsTemplateJob")]
		public bool? IsTemplateJob { get; set; }

		/// <summary>
		/// Gets or Sets NotificationHistoryTypeID
		/// </summary>
		[DataMember(Name = "NotificationHistoryTypeID")]
		public int? NotificationHistoryTypeID { get; set; }

		/// <summary>
		/// Gets or Sets NotificationSentTime
		/// </summary>
		[DataMember(Name = "NotificationSentTime")]
		public DateTime? NotificationSentTime { get; set; }

		/// <summary>
		/// Gets or Sets OpportunityID
		/// </summary>
		[DataMember(Name = "OpportunityID")]
		public long? OpportunityID { get; set; }

		/// <summary>
		/// Gets or Sets ProjectID
		/// </summary>
		[DataMember(Name = "ProjectID")]
		public long? ProjectID { get; set; }

		/// <summary>
		/// Gets or Sets QuoteID
		/// </summary>
		[DataMember(Name = "QuoteID")]
		public long? QuoteID { get; set; }

		/// <summary>
		/// Gets or Sets RecipientDisplayName
		/// </summary>
		[DataMember(Name = "RecipientDisplayName")]
		public string RecipientDisplayName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RecipientEmailAddress
		/// </summary>
		[DataMember(Name = "RecipientEmailAddress")]
		public string RecipientEmailAddress { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets TaskID
		/// </summary>
		[DataMember(Name = "TaskID")]
		public long? TaskID { get; set; }

		/// <summary>
		/// Gets or Sets TemplateName
		/// </summary>
		[DataMember(Name = "TemplateName")]
		public string TemplateName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID")]
		public long? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets TimeEntryID
		/// </summary>
		[DataMember(Name = "TimeEntryID")]
		public long? TimeEntryID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
