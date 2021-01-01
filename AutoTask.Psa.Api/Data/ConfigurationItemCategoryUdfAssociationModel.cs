using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ConfigurationItemCategoryUdfAssociationModel
	/// </summary>
	[DataContract]
	public partial class ConfigurationItemCategoryUdfAssociationModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ConfigurationItemCategoryID
		/// </summary>
		[DataMember(Name = "ConfigurationItemCategoryID", EmitDefaultValue = false)]
		public int? ConfigurationItemCategoryID { get; set; }

		/// <summary>
		/// Gets or Sets IsRequired
		/// </summary>
		[DataMember(Name = "IsRequired", EmitDefaultValue = false)]
		public bool? IsRequired { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFieldDefinitionID
		/// </summary>
		[DataMember(Name = "UserDefinedFieldDefinitionID", EmitDefaultValue = false)]
		public int? UserDefinedFieldDefinitionID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncInstalledProductCategoryUdfAssociationInt64 SoapParentPropertyId { get; private set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
