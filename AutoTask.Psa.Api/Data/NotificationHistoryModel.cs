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
		/// Initializes a new instance of the <see cref="NotificationHistoryModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="EntityNumber">EntityNumber.</param>
		/// <param name="EntityTitle">EntityTitle.</param>
		/// <param name="InitiatingContactID">InitiatingContactID.</param>
		/// <param name="InitiatingResourceID">InitiatingResourceID.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsDeleted">IsDeleted.</param>
		/// <param name="IsTemplateJob">IsTemplateJob.</param>
		/// <param name="NotificationHistoryTypeID">NotificationHistoryTypeID.</param>
		/// <param name="NotificationSentTime">NotificationSentTime.</param>
		/// <param name="OpportunityID">OpportunityID.</param>
		/// <param name="ProjectID">ProjectID.</param>
		/// <param name="QuoteID">QuoteID.</param>
		/// <param name="RecipientDisplayName">RecipientDisplayName.</param>
		/// <param name="RecipientEmailAddress">RecipientEmailAddress.</param>
		/// <param name="TaskID">TaskID.</param>
		/// <param name="TemplateName">TemplateName.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="TimeEntryID">TimeEntryID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public NotificationHistoryModel(long? Id = default, long? CompanyID = default, string EntityNumber = default, string EntityTitle = default, long? InitiatingContactID = default, long? InitiatingResourceID = default, bool? IsActive = default, bool? IsDeleted = default, bool? IsTemplateJob = default, int? NotificationHistoryTypeID = default, DateTime? NotificationSentTime = default, long? OpportunityID = default, long? ProjectID = default, long? QuoteID = default, string RecipientDisplayName = default, string RecipientEmailAddress = default, long? TaskID = default, string TemplateName = default, long? TicketID = default, long? TimeEntryID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CompanyID = CompanyID;
			this.EntityNumber = EntityNumber;
			this.EntityTitle = EntityTitle;
			this.InitiatingContactID = InitiatingContactID;
			this.InitiatingResourceID = InitiatingResourceID;
			this.IsActive = IsActive;
			this.IsDeleted = IsDeleted;
			this.IsTemplateJob = IsTemplateJob;
			this.NotificationHistoryTypeID = NotificationHistoryTypeID;
			this.NotificationSentTime = NotificationSentTime;
			this.OpportunityID = OpportunityID;
			this.ProjectID = ProjectID;
			this.QuoteID = QuoteID;
			this.RecipientDisplayName = RecipientDisplayName;
			this.RecipientEmailAddress = RecipientEmailAddress;
			this.TaskID = TaskID;
			this.TemplateName = TemplateName;
			this.TicketID = TicketID;
			this.TimeEntryID = TimeEntryID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public long? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets EntityNumber
		/// </summary>
		[DataMember(Name = "EntityNumber", EmitDefaultValue = false)]
		public string EntityNumber { get; set; }

		/// <summary>
		/// Gets or Sets EntityTitle
		/// </summary>
		[DataMember(Name = "EntityTitle", EmitDefaultValue = false)]
		public string EntityTitle { get; set; }

		/// <summary>
		/// Gets or Sets InitiatingContactID
		/// </summary>
		[DataMember(Name = "InitiatingContactID", EmitDefaultValue = false)]
		public long? InitiatingContactID { get; set; }

		/// <summary>
		/// Gets or Sets InitiatingResourceID
		/// </summary>
		[DataMember(Name = "InitiatingResourceID", EmitDefaultValue = false)]
		public long? InitiatingResourceID { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsDeleted
		/// </summary>
		[DataMember(Name = "IsDeleted", EmitDefaultValue = false)]
		public bool? IsDeleted { get; set; }

		/// <summary>
		/// Gets or Sets IsTemplateJob
		/// </summary>
		[DataMember(Name = "IsTemplateJob", EmitDefaultValue = false)]
		public bool? IsTemplateJob { get; set; }

		/// <summary>
		/// Gets or Sets NotificationHistoryTypeID
		/// </summary>
		[DataMember(Name = "NotificationHistoryTypeID", EmitDefaultValue = false)]
		public int? NotificationHistoryTypeID { get; set; }

		/// <summary>
		/// Gets or Sets NotificationSentTime
		/// </summary>
		[DataMember(Name = "NotificationSentTime", EmitDefaultValue = false)]
		public DateTime? NotificationSentTime { get; set; }

		/// <summary>
		/// Gets or Sets OpportunityID
		/// </summary>
		[DataMember(Name = "OpportunityID", EmitDefaultValue = false)]
		public long? OpportunityID { get; set; }

		/// <summary>
		/// Gets or Sets ProjectID
		/// </summary>
		[DataMember(Name = "ProjectID", EmitDefaultValue = false)]
		public long? ProjectID { get; set; }

		/// <summary>
		/// Gets or Sets QuoteID
		/// </summary>
		[DataMember(Name = "QuoteID", EmitDefaultValue = false)]
		public long? QuoteID { get; set; }

		/// <summary>
		/// Gets or Sets RecipientDisplayName
		/// </summary>
		[DataMember(Name = "RecipientDisplayName", EmitDefaultValue = false)]
		public string RecipientDisplayName { get; set; }

		/// <summary>
		/// Gets or Sets RecipientEmailAddress
		/// </summary>
		[DataMember(Name = "RecipientEmailAddress", EmitDefaultValue = false)]
		public string RecipientEmailAddress { get; set; }

		/// <summary>
		/// Gets or Sets TaskID
		/// </summary>
		[DataMember(Name = "TaskID", EmitDefaultValue = false)]
		public long? TaskID { get; set; }

		/// <summary>
		/// Gets or Sets TemplateName
		/// </summary>
		[DataMember(Name = "TemplateName", EmitDefaultValue = false)]
		public string TemplateName { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public long? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets TimeEntryID
		/// </summary>
		[DataMember(Name = "TimeEntryID", EmitDefaultValue = false)]
		public long? TimeEntryID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
