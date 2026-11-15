namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractChargeModel
/// </summary>
public class ContractChargeModel : ContractLinkedChargeModelBase
{
	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public long? ContractID { get; set; }
}
