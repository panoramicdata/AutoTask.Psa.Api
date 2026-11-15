namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractExclusionSetExcludedWorkTypeModel
/// </summary>
[DataContract]
public class ContractExclusionSetExcludedWorkTypeModel : ParentedEntityModelBase
{
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
}
