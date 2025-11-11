namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractRateModel
/// </summary>
[DataContract]
public class ContractRateModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ContractHourlyRate
	/// </summary>
	[DataMember(Name = "ContractHourlyRate")]
	public double? ContractHourlyRate { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyContractHourlyRate
	/// </summary>
	[DataMember(Name = "InternalCurrencyContractHourlyRate")]
	public double? InternalCurrencyContractHourlyRate { get; set; }

	/// <summary>
	/// Gets or Sets RoleID
	/// </summary>
	[DataMember(Name = "RoleID")]
	public int? RoleID { get; set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
