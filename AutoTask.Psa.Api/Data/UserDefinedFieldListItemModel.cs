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
		/// Initializes a new instance of the <see cref="UserDefinedFieldListItemModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CreateDate">CreateDate.</param>
		/// <param name="UdfFieldId">UdfFieldId.</param>
		/// <param name="ValueForDisplay">ValueForDisplay.</param>
		/// <param name="ValueForExport">ValueForExport.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public UserDefinedFieldListItemModel(long? Id = default, DateTime? CreateDate = default, long? UdfFieldId = default, string ValueForDisplay = default, string ValueForExport = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CreateDate = CreateDate;
			this.UdfFieldId = UdfFieldId;
			this.ValueForDisplay = ValueForDisplay;
			this.ValueForExport = ValueForExport;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		public string ValueForDisplay { get; set; }

		/// <summary>
		/// Gets or Sets ValueForExport
		/// </summary>
		[DataMember(Name = "ValueForExport", EmitDefaultValue = false)]
		public string ValueForExport { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncUserDefinedFieldListItemInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
