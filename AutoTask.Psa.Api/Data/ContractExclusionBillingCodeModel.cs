using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractExclusionBillingCodeModel
	/// </summary>
	[DataContract]
	public partial class ContractExclusionBillingCodeModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractExclusionBillingCodeModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BillingCodeID">BillingCodeID.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractExclusionBillingCodeModel(long? Id = default, long? BillingCodeID = default, long? ContractID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BillingCodeID = BillingCodeID;
			this.ContractID = ContractID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BillingCodeID
		/// </summary>
		[DataMember(Name = "BillingCodeID", EmitDefaultValue = false)]
		public long? BillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public long? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContractExclusionAllocationCodeInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
