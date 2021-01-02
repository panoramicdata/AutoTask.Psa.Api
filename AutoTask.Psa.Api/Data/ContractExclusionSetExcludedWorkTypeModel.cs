using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractExclusionSetExcludedWorkTypeModel
	/// </summary>
	[DataContract]
	public partial class ContractExclusionSetExcludedWorkTypeModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ContractExclusionSetID
		/// </summary>
		[DataMember(Name = "ContractExclusionSetID", EmitDefaultValue = false)]
		public int? ContractExclusionSetID { get; set; }

		/// <summary>
		/// Gets or Sets ExcludedWorkTypeID
		/// </summary>
		[DataMember(Name = "ExcludedWorkTypeID", EmitDefaultValue = false)]
		public int? ExcludedWorkTypeID { get; set; }

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
