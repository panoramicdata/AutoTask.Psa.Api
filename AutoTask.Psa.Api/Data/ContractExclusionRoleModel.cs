using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractExclusionRoleModel
	/// </summary>
	[DataContract]
	public partial class ContractExclusionRoleModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractExclusionRoleModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="RoleID">RoleID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractExclusionRoleModel(long? Id = default, long? ContractID = default, long? RoleID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ContractID = ContractID;
			this.RoleID = RoleID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public long? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets RoleID
		/// </summary>
		[DataMember(Name = "RoleID", EmitDefaultValue = false)]
		public long? RoleID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContractExclusionRoleInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
