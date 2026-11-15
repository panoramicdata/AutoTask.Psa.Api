namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Properties common to the contract service unit and contract service bundle unit entities.
/// </summary>
[DataContract]
public abstract class ContractServiceUnitModelBase : EntityModelBase
{
	/// <summary>
	/// Gets or Sets ApproveAndPostDate
	/// </summary>
	[DataMember(Name = "ApproveAndPostDate")]
	public DateTime? ApproveAndPostDate { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets Cost
	/// </summary>
	[DataMember(Name = "Cost")]
	public double? Cost { get; set; }

	/// <summary>
	/// Gets or Sets EndDate
	/// </summary>
	[DataMember(Name = "EndDate")]
	public DateTime? EndDate { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyPrice
	/// </summary>
	[DataMember(Name = "InternalCurrencyPrice")]
	public double? InternalCurrencyPrice { get; set; }

	/// <summary>
	/// Gets or Sets OrganizationalLevelAssociationID
	/// </summary>
	[DataMember(Name = "OrganizationalLevelAssociationID")]
	public int? OrganizationalLevelAssociationID { get; set; }

	/// <summary>
	/// Gets or Sets Price
	/// </summary>
	[DataMember(Name = "Price")]
	public double? Price { get; set; }

	/// <summary>
	/// Gets or Sets StartDate
	/// </summary>
	[DataMember(Name = "StartDate")]
	public DateTime? StartDate { get; set; }

	/// <summary>
	/// Gets or Sets Units
	/// </summary>
	[DataMember(Name = "Units")]
	public int? Units { get; set; }
}
