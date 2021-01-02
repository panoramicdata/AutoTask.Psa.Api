using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CompanyAlertModel
	/// </summary>
	[DataContract]
	public partial class CompanyAlertModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AlertText
		/// </summary>
		[DataMember(Name = "AlertText", EmitDefaultValue = false)]
		public string AlertText { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets AlertTypeID
		/// </summary>
		[DataMember(Name = "AlertTypeID", EmitDefaultValue = false)]
		public int? AlertTypeID { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

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
