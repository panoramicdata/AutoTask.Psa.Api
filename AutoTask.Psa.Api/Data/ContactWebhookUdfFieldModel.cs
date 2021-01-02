using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContactWebhookUdfFieldModel
	/// </summary>
	[DataContract]
	public partial class ContactWebhookUdfFieldModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

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
		/// Gets or Sets UdfFieldID
		/// </summary>
		[DataMember(Name = "UdfFieldID", EmitDefaultValue = false)]
		public int? UdfFieldID { get; set; }

		/// <summary>
		/// Gets or Sets WebhookID
		/// </summary>
		[DataMember(Name = "WebhookID", EmitDefaultValue = false)]
		public int? WebhookID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
