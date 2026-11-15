namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Properties common to the service and service bundle entities.
/// </summary>
[DataContract]
public abstract class ServiceCatalogueModelBase : DescribedNamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets BillingCodeID
	/// </summary>
	[DataMember(Name = "BillingCodeID")]
	public int? BillingCodeID { get; set; }

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
	/// Gets or Sets InvoiceDescription
	/// </summary>
	[DataMember(Name = "InvoiceDescription")]
	public string InvoiceDescription { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets LastModifiedDate
	/// </summary>
	[DataMember(Name = "LastModifiedDate")]
	public DateTime? LastModifiedDate { get; set; }

	/// <summary>
	/// Gets or Sets PeriodType
	/// </summary>
	[DataMember(Name = "PeriodType")]
	public int? PeriodType { get; set; }

	/// <summary>
	/// Gets or Sets ServiceLevelAgreementID
	/// </summary>
	[DataMember(Name = "ServiceLevelAgreementID")]
	public long? ServiceLevelAgreementID { get; set; }

	/// <summary>
	/// Gets or Sets UnitCost
	/// </summary>
	[DataMember(Name = "UnitCost")]
	public double? UnitCost { get; set; }

	/// <summary>
	/// Gets or Sets UnitPrice
	/// </summary>
	[DataMember(Name = "UnitPrice")]
	public double? UnitPrice { get; set; }

	/// <summary>
	/// Gets or Sets UpdateResourceID
	/// </summary>
	[DataMember(Name = "UpdateResourceID")]
	public int? UpdateResourceID { get; set; }
}
