using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractBlockHourFactorModel
	/// </summary>
	[DataContract]
	public partial class ContractBlockHourFactorModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractBlockHourFactorModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BlockHourMultiplier">BlockHourMultiplier.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="RoleID">RoleID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractBlockHourFactorModel(long? Id = default, double? BlockHourMultiplier = default, int? ContractID = default, int? RoleID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BlockHourMultiplier = BlockHourMultiplier;
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
		/// Gets or Sets BlockHourMultiplier
		/// </summary>
		[DataMember(Name = "BlockHourMultiplier", EmitDefaultValue = false)]
		public double? BlockHourMultiplier { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets RoleID
		/// </summary>
		[DataMember(Name = "RoleID", EmitDefaultValue = false)]
		public int? RoleID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContractFactorInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
