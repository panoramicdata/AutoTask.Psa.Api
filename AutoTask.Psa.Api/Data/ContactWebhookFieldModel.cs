using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContactWebhookFieldModel
	/// </summary>
	[DataContract]
	public partial class ContactWebhookFieldModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactWebhookFieldModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="FieldID">FieldID.</param>
		/// <param name="IsDisplayAlwaysField">IsDisplayAlwaysField.</param>
		/// <param name="IsSubscribedField">IsSubscribedField.</param>
		/// <param name="WebhookID">WebhookID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContactWebhookFieldModel(long? Id = default, int? FieldID = default, bool? IsDisplayAlwaysField = default, bool? IsSubscribedField = default, int? WebhookID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.FieldID = FieldID;
			this.IsDisplayAlwaysField = IsDisplayAlwaysField;
			this.IsSubscribedField = IsSubscribedField;
			this.WebhookID = WebhookID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets FieldID
		/// </summary>
		[DataMember(Name = "FieldID", EmitDefaultValue = false)]
		public int? FieldID { get; set; }

		/// <summary>
		/// Gets or Sets IsDisplayAlwaysField
		/// </summary>
		[DataMember(Name = "IsDisplayAlwaysField", EmitDefaultValue = false)]
		public bool? IsDisplayAlwaysField { get; set; }

		/// <summary>
		/// Gets or Sets IsSubscribedField
		/// </summary>
		[DataMember(Name = "IsSubscribedField", EmitDefaultValue = false)]
		public bool? IsSubscribedField { get; set; }

		/// <summary>
		/// Gets or Sets WebhookID
		/// </summary>
		[DataMember(Name = "WebhookID", EmitDefaultValue = false)]
		public int? WebhookID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContactWebhookFieldInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
