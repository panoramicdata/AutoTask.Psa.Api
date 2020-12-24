using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractExclusionSetExcludedRoleModel
	/// </summary>
	[DataContract]
	public partial class ContractExclusionSetExcludedRoleModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractExclusionSetExcludedRoleModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ContractExclusionSetID">ContractExclusionSetID.</param>
		/// <param name="ExcludedRoleID">ExcludedRoleID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractExclusionSetExcludedRoleModel(long? Id = default, int? ContractExclusionSetID = default, int? ExcludedRoleID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ContractExclusionSetID = ContractExclusionSetID;
			this.ExcludedRoleID = ExcludedRoleID;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		/// Gets or Sets ExcludedRoleID
		/// </summary>
		[DataMember(Name = "ExcludedRoleID", EmitDefaultValue = false)]
		public int? ExcludedRoleID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContractExclusionSetExcludedRoleInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
