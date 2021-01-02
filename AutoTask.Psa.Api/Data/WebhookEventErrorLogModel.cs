using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// WebhookEventErrorLogModel
	/// </summary>
	[DataContract]
	public partial class WebhookEventErrorLogModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AccountWebhookID
		/// </summary>
		[DataMember(Name = "AccountWebhookID", EmitDefaultValue = false)]
		public int? AccountWebhookID { get; set; }

		/// <summary>
		/// Gets or Sets ContactWebhookID
		/// </summary>
		[DataMember(Name = "ContactWebhookID", EmitDefaultValue = false)]
		public int? ContactWebhookID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDateTime
		/// </summary>
		[DataMember(Name = "CreateDateTime", EmitDefaultValue = false)]
		public DateTime? CreateDateTime { get; set; }

		/// <summary>
		/// Gets or Sets ErrorMessage
		/// </summary>
		[DataMember(Name = "ErrorMessage", EmitDefaultValue = false)]
		public string ErrorMessage { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Payload
		/// </summary>
		[DataMember(Name = "Payload", EmitDefaultValue = false)]
		public string Payload { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets SequenceNumber
		/// </summary>
		[DataMember(Name = "SequenceNumber", EmitDefaultValue = false)]
		public int? SequenceNumber { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
