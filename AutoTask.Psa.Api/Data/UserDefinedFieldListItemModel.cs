using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// UserDefinedFieldListItemModel
	/// </summary>
	[DataContract]
	public partial class UserDefinedFieldListItemModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate", EmitDefaultValue = false)]
		public DateTime? CreateDate { get; set; }

		/// <summary>
		/// Gets or Sets UdfFieldId
		/// </summary>
		[DataMember(Name = "UdfFieldId", EmitDefaultValue = false)]
		public long? UdfFieldId { get; set; }

		/// <summary>
		/// Gets or Sets ValueForDisplay
		/// </summary>
		[DataMember(Name = "ValueForDisplay", EmitDefaultValue = false)]
		public string ValueForDisplay { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ValueForExport
		/// </summary>
		[DataMember(Name = "ValueForExport", EmitDefaultValue = false)]
		public string ValueForExport { get; set; } = string.Empty;

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
