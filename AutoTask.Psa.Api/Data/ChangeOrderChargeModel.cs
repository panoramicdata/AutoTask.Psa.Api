namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ChangeOrderChargeModel
/// </summary>
public class ChangeOrderChargeModel : ChargeModelBase
{
	/// <summary>
	/// Gets or Sets BillingCodeID
	/// </summary>
	[DataMember(Name = "BillingCodeID")]
	public int? BillingCodeID { get; set; }

	/// <summary>
	/// Gets or Sets ChangeOrderHours
	/// </summary>
	[DataMember(Name = "ChangeOrderHours")]
	public double? ChangeOrderHours { get; set; }

	/// <summary>
	/// Gets or Sets ContractServiceBundleID
	/// </summary>
	[DataMember(Name = "ContractServiceBundleID")]
	public int? ContractServiceBundleID { get; set; }

	/// <summary>
	/// Gets or Sets ContractServiceID
	/// </summary>
	[DataMember(Name = "ContractServiceID")]
	public int? ContractServiceID { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public int? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

	/// <summary>
	/// Gets or Sets StatusLastModifiedBy
	/// </summary>
	[DataMember(Name = "StatusLastModifiedBy")]
	public int? StatusLastModifiedBy { get; set; }

	/// <summary>
	/// Gets or Sets TaskID
	/// </summary>
	[DataMember(Name = "TaskID")]
	public int? TaskID { get; set; }
}
