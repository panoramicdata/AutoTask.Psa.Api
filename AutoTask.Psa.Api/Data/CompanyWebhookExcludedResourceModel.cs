using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CompanyWebhookExcludedResourceModel
	/// </summary>
	[DataContract]
	public partial class CompanyWebhookExcludedResourceModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CompanyWebhookExcludedResourceModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="WebhookID">WebhookID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public CompanyWebhookExcludedResourceModel(long? Id = default, int? ResourceID = default, int? WebhookID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ResourceID = ResourceID;
			this.WebhookID = WebhookID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ResourceID
		/// </summary>
		[DataMember(Name = "ResourceID", EmitDefaultValue = false)]
		public int? ResourceID { get; set; }

		/// <summary>
		/// Gets or Sets WebhookID
		/// </summary>
		[DataMember(Name = "WebhookID", EmitDefaultValue = false)]
		public int? WebhookID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncAccountWebhookExcludedResourceInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
