namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractMilestoneModel
/// </summary>
[DataContract]
public class ContractMilestoneModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets Amount
	/// </summary>
	[DataMember(Name = "Amount")]
	public double? Amount { get; set; }

	/// <summary>
	/// Gets or Sets BillingCodeID
	/// </summary>
	[DataMember(Name = "BillingCodeID")]
	public int? BillingCodeID { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDate
	/// </summary>
	[DataMember(Name = "CreateDate")]
	public DateTime? CreateDate { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public int? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets DateDue
	/// </summary>
	[DataMember(Name = "DateDue")]
	public DateTime? DateDue { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets InternalCurrencyAmount
	/// </summary>
	[DataMember(Name = "InternalCurrencyAmount")]
	public double? InternalCurrencyAmount { get; set; }

	/// <summary>
	/// Gets or Sets IsInitialPayment
	/// </summary>
	[DataMember(Name = "IsInitialPayment")]
	public bool? IsInitialPayment { get; set; }

	/// <summary>
	/// Gets or Sets OrganizationalLevelAssociationID
	/// </summary>
	[DataMember(Name = "OrganizationalLevelAssociationID")]
	public int? OrganizationalLevelAssociationID { get; set; }

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "Title")]
	public string Title { get; set; } = string.Empty;
}
