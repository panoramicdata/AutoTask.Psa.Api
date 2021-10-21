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
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets DeactivationUrl
		/// </summary>
		[DataMember(Name = "DeactivationUrl")]
		public string DeactivationUrl { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive")]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsReady
		/// </summary>
		[DataMember(Name = "IsReady")]
		public bool? IsReady { get; set; }

		/// <summary>
		/// Gets or Sets IsSubscribedToCreateEvents
		/// </summary>
		[DataMember(Name = "IsSubscribedToCreateEvents")]
		public bool? IsSubscribedToCreateEvents { get; set; }

		/// <summary>
		/// Gets or Sets IsSubscribedToDeleteEvents
		/// </summary>
		[DataMember(Name = "IsSubscribedToDeleteEvents")]
		public bool? IsSubscribedToDeleteEvents { get; set; }

		/// <summary>
		/// Gets or Sets IsSubscribedToUpdateEvents
		/// </summary>
		[DataMember(Name = "IsSubscribedToUpdateEvents")]
		public bool? IsSubscribedToUpdateEvents { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets NotificationEmailAddress
		/// </summary>
		[DataMember(Name = "NotificationEmailAddress")]
		public string NotificationEmailAddress { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets OwnerResourceID
		/// </summary>
		[DataMember(Name = "OwnerResourceID")]
		public int? OwnerResourceID { get; set; }

		/// <summary>
		/// Gets or Sets SecretKey
		/// </summary>
		[DataMember(Name = "SecretKey")]
		public string SecretKey { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets SendThresholdExceededNotification
		/// </summary>
		[DataMember(Name = "SendThresholdExceededNotification")]
		public bool? SendThresholdExceededNotification { get; set; }

		/// <summary>
		/// Gets or Sets WebhookGUID
		/// </summary>
		[DataMember(Name = "WebhookGUID")]
		public string WebhookGUID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets WebhookUrl
		/// </summary>
		[DataMember(Name = "WebhookUrl")]
		public string WebhookUrl { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
