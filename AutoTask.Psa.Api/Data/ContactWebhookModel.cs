using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContactWebhookModel
	/// </summary>
	[DataContract]
	public partial class ContactWebhookModel
	{
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
