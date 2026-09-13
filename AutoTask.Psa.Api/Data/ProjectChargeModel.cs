namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ProjectChargeModel
/// </summary>
public class ProjectChargeModel : ChargeModelBase
{
	/// <summary>
	/// Gets or Sets BillingCodeID
	/// </summary>
	[DataMember(Name = "BillingCodeID")]
	public long? BillingCodeID { get; set; }

	/// <summary>
	/// Gets or Sets ContractServiceBundleID
	/// </summary>
	[DataMember(Name = "ContractServiceBundleID")]
	public long? ContractServiceBundleID { get; set; }

	/// <summary>
	/// Gets or Sets ContractServiceID
	/// </summary>
	[DataMember(Name = "ContractServiceID")]
	public long? ContractServiceID { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public long? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets EstimatedCost
	/// </summary>
	[DataMember(Name = "EstimatedCost")]
	public double? EstimatedCost { get; set; }

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public long? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets ProjectID
	/// </summary>
	[DataMember(Name = "ProjectID")]
	public long? ProjectID { get; set; }

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public long? Status { get; set; }

	/// <summary>
	/// Gets or Sets StatusLastModifiedBy
	/// </summary>
	[DataMember(Name = "StatusLastModifiedBy")]
	public long? StatusLastModifiedBy { get; set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }
}
