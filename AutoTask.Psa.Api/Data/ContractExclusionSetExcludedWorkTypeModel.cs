namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractExclusionSetExcludedWorkTypeModel
/// </summary>
[DataContract]
public partial class ContractExclusionSetExcludedWorkTypeModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ContractExclusionSetID
	/// </summary>
	[DataMember(Name = "ContractExclusionSetID")]
	public int? ContractExclusionSetID { get; set; }

	/// <summary>
	/// Gets or Sets ExcludedWorkTypeID
	/// </summary>
	[DataMember(Name = "ExcludedWorkTypeID")]
	public int? ExcludedWorkTypeID { get; set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
