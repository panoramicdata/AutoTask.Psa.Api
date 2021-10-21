using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CompanyWebhookUdfFieldModel
	/// </summary>
	[DataContract]
	public partial class CompanyWebhookUdfFieldModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets IsDisplayAlwaysField
		/// </summary>
		[DataMember(Name = "IsDisplayAlwaysField")]
		public bool? IsDisplayAlwaysField { get; set; }

		/// <summary>
		/// Gets or Sets IsSubscribedField
		/// </summary>
		[DataMember(Name = "IsSubscribedField")]
		public bool? IsSubscribedField { get; set; }

		/// <summary>
		/// Gets or Sets UdfFieldID
		/// </summary>
		[DataMember(Name = "UdfFieldID")]
		public int? UdfFieldID { get; set; }

		/// <summary>
		/// Gets or Sets WebhookID
		/// </summary>
		[DataMember(Name = "WebhookID")]
		public int? WebhookID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId")]
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
