using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractRoleCostModel
	/// </summary>
	[DataContract]
	public partial class ContractRoleCostModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractRoleCostModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="Rate">Rate.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="RoleID">RoleID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractRoleCostModel(long? Id = default, int? ContractID = default, double? Rate = default, int? ResourceID = default, int? RoleID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ContractID = ContractID;
			this.Rate = Rate;
			this.ResourceID = ResourceID;
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
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets Rate
		/// </summary>
		[DataMember(Name = "Rate", EmitDefaultValue = false)]
		public double? Rate { get; set; }

		/// <summary>
		/// Gets or Sets ResourceID
		/// </summary>
		[DataMember(Name = "ResourceID", EmitDefaultValue = false)]
		public int? ResourceID { get; set; }

		/// <summary>
		/// Gets or Sets RoleID
		/// </summary>
		[DataMember(Name = "RoleID", EmitDefaultValue = false)]
		public int? RoleID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContractRoleCostInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
