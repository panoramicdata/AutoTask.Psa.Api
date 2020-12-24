using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CompanyWebhookModel
	/// </summary>
	[DataContract]
	public partial class CompanyWebhookModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CompanyWebhookModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="DeactivationUrl">DeactivationUrl.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsReady">IsReady.</param>
		/// <param name="IsSubscribedToCreateEvents">IsSubscribedToCreateEvents.</param>
		/// <param name="IsSubscribedToDeleteEvents">IsSubscribedToDeleteEvents.</param>
		/// <param name="IsSubscribedToUpdateEvents">IsSubscribedToUpdateEvents.</param>
		/// <param name="Name">Name.</param>
		/// <param name="NotificationEmailAddress">NotificationEmailAddress.</param>
		/// <param name="OwnerResourceID">OwnerResourceID.</param>
		/// <param name="SecretKey">SecretKey.</param>
		/// <param name="SendThresholdExceededNotification">SendThresholdExceededNotification.</param>
		/// <param name="WebhookGUID">WebhookGUID.</param>
		/// <param name="WebhookUrl">WebhookUrl.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public CompanyWebhookModel(long? Id = default, string DeactivationUrl = default, bool? IsActive = default, bool? IsReady = default, bool? IsSubscribedToCreateEvents = default, bool? IsSubscribedToDeleteEvents = default, bool? IsSubscribedToUpdateEvents = default, string Name = default, string NotificationEmailAddress = default, int? OwnerResourceID = default, string SecretKey = default, bool? SendThresholdExceededNotification = default, string WebhookGUID = default, string WebhookUrl = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.DeactivationUrl = DeactivationUrl;
			this.IsActive = IsActive;
			this.IsReady = IsReady;
			this.IsSubscribedToCreateEvents = IsSubscribedToCreateEvents;
			this.IsSubscribedToDeleteEvents = IsSubscribedToDeleteEvents;
			this.IsSubscribedToUpdateEvents = IsSubscribedToUpdateEvents;
			this.Name = Name;
			this.NotificationEmailAddress = NotificationEmailAddress;
			this.OwnerResourceID = OwnerResourceID;
			this.SecretKey = SecretKey;
			this.SendThresholdExceededNotification = SendThresholdExceededNotification;
			this.WebhookGUID = WebhookGUID;
			this.WebhookUrl = WebhookUrl;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets DeactivationUrl
		/// </summary>
		[DataMember(Name = "DeactivationUrl", EmitDefaultValue = false)]
		public string DeactivationUrl { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsReady
		/// </summary>
		[DataMember(Name = "IsReady", EmitDefaultValue = false)]
		public bool? IsReady { get; set; }

		/// <summary>
		/// Gets or Sets IsSubscribedToCreateEvents
		/// </summary>
		[DataMember(Name = "IsSubscribedToCreateEvents", EmitDefaultValue = false)]
		public bool? IsSubscribedToCreateEvents { get; set; }

		/// <summary>
		/// Gets or Sets IsSubscribedToDeleteEvents
		/// </summary>
		[DataMember(Name = "IsSubscribedToDeleteEvents", EmitDefaultValue = false)]
		public bool? IsSubscribedToDeleteEvents { get; set; }

		/// <summary>
		/// Gets or Sets IsSubscribedToUpdateEvents
		/// </summary>
		[DataMember(Name = "IsSubscribedToUpdateEvents", EmitDefaultValue = false)]
		public bool? IsSubscribedToUpdateEvents { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets NotificationEmailAddress
		/// </summary>
		[DataMember(Name = "NotificationEmailAddress", EmitDefaultValue = false)]
		public string NotificationEmailAddress { get; set; }

		/// <summary>
		/// Gets or Sets OwnerResourceID
		/// </summary>
		[DataMember(Name = "OwnerResourceID", EmitDefaultValue = false)]
		public int? OwnerResourceID { get; set; }

		/// <summary>
		/// Gets or Sets SecretKey
		/// </summary>
		[DataMember(Name = "SecretKey", EmitDefaultValue = false)]
		public string SecretKey { get; set; }

		/// <summary>
		/// Gets or Sets SendThresholdExceededNotification
		/// </summary>
		[DataMember(Name = "SendThresholdExceededNotification", EmitDefaultValue = false)]
		public bool? SendThresholdExceededNotification { get; set; }

		/// <summary>
		/// Gets or Sets WebhookGUID
		/// </summary>
		[DataMember(Name = "WebhookGUID", EmitDefaultValue = false)]
		public string WebhookGUID { get; set; }

		/// <summary>
		/// Gets or Sets WebhookUrl
		/// </summary>
		[DataMember(Name = "WebhookUrl", EmitDefaultValue = false)]
		public string WebhookUrl { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
