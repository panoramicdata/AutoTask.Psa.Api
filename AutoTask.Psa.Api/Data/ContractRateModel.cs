using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractRateModel
	/// </summary>
	[DataContract]
	public partial class ContractRateModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractRateModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ContractHourlyRate">ContractHourlyRate.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="InternalCurrencyContractHourlyRate">InternalCurrencyContractHourlyRate.</param>
		/// <param name="RoleID">RoleID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractRateModel(long? Id = default, double? ContractHourlyRate = default, int? ContractID = default, double? InternalCurrencyContractHourlyRate = default, int? RoleID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ContractHourlyRate = ContractHourlyRate;
			this.ContractID = ContractID;
			this.InternalCurrencyContractHourlyRate = InternalCurrencyContractHourlyRate;
			this.RoleID = RoleID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ContractHourlyRate
		/// </summary>
		[DataMember(Name = "ContractHourlyRate", EmitDefaultValue = false)]
		public double? ContractHourlyRate { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyContractHourlyRate
		/// </summary>
		[DataMember(Name = "InternalCurrencyContractHourlyRate", EmitDefaultValue = false)]
		public double? InternalCurrencyContractHourlyRate { get; set; }

		/// <summary>
		/// Gets or Sets RoleID
		/// </summary>
		[DataMember(Name = "RoleID", EmitDefaultValue = false)]
		public int? RoleID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContractRateInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
