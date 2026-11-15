namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractExclusionBillingCodeModel
/// </summary>
[DataContract]
public class ContractExclusionBillingCodeModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets BillingCodeID
	/// </summary>
	[DataMember(Name = "BillingCodeID")]
	public long? BillingCodeID { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public long? ContractID { get; set; }
}
