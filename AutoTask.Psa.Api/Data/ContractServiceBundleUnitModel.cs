namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractServiceBundleUnitModel
/// </summary>
[DataContract]
public partial class ContractServiceBundleUnitModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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
	/// Gets or Sets ContractServiceBundleID
	/// </summary>
	[DataMember(Name = "ContractServiceBundleID")]
	public int? ContractServiceBundleID { get; set; }

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
	/// Gets or Sets ServiceBundleID
	/// </summary>
	[DataMember(Name = "ServiceBundleID")]
	public int? ServiceBundleID { get; set; }

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

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public long? SoapParentPropertyId { get; private set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
