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
		/// Initializes a new instance of the <see cref="WebhookEventErrorLogModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AccountWebhookID">AccountWebhookID.</param>
		/// <param name="ContactWebhookID">ContactWebhookID.</param>
		/// <param name="CreateDateTime">CreateDateTime.</param>
		/// <param name="ErrorMessage">ErrorMessage.</param>
		/// <param name="Payload">Payload.</param>
		/// <param name="SequenceNumber">SequenceNumber.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public WebhookEventErrorLogModel(long? Id = default, int? AccountWebhookID = default, int? ContactWebhookID = default, DateTime? CreateDateTime = default, string ErrorMessage = default, string Payload = default, int? SequenceNumber = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AccountWebhookID = AccountWebhookID;
			this.ContactWebhookID = ContactWebhookID;
			this.CreateDateTime = CreateDateTime;
			this.ErrorMessage = ErrorMessage;
			this.Payload = Payload;
			this.SequenceNumber = SequenceNumber;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		public string ErrorMessage { get; set; }

		/// <summary>
		/// Gets or Sets Payload
		/// </summary>
		[DataMember(Name = "Payload", EmitDefaultValue = false)]
		public string Payload { get; set; }

		/// <summary>
		/// Gets or Sets SequenceNumber
		/// </summary>
		[DataMember(Name = "SequenceNumber", EmitDefaultValue = false)]
		public int? SequenceNumber { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
