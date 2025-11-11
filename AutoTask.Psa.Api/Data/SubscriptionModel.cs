namespace AutoTask.Psa.Api.Data;

/// <summary>
/// SubscriptionModel
/// </summary>
[DataContract]
public class SubscriptionModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ConfigurationItemID
	/// </summary>
	[DataMember(Name = "ConfigurationItemID")]
	public int? ConfigurationItemID { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets EffectiveDate
	/// </summary>
	[DataMember(Name = "EffectiveDate")]
	public DateTime? EffectiveDate { get; set; }

	/// <summary>
	/// Gets or Sets ExpirationDate
	/// </summary>
	[DataMember(Name = "ExpirationDate")]
	public DateTime? ExpirationDate { get; set; }

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets MaterialCodeID
	/// </summary>
	[DataMember(Name = "MaterialCodeID")]
	public int? MaterialCodeID { get; set; }

	/// <summary>
	/// Gets or Sets OrganizationalLevelAssociationID
	/// </summary>
	[DataMember(Name = "OrganizationalLevelAssociationID")]
	public int? OrganizationalLevelAssociationID { get; set; }

	/// <summary>
	/// Gets or Sets PeriodCost
	/// </summary>
	[DataMember(Name = "PeriodCost")]
	public double? PeriodCost { get; set; }

	/// <summary>
	/// Gets or Sets PeriodPrice
	/// </summary>
	[DataMember(Name = "PeriodPrice")]
	public double? PeriodPrice { get; set; }

	/// <summary>
	/// Gets or Sets PeriodType
	/// </summary>
	[DataMember(Name = "PeriodType")]
	public int? PeriodType { get; set; }

	/// <summary>
	/// Gets or Sets PurchaseOrderNumber
	/// </summary>
	[DataMember(Name = "PurchaseOrderNumber")]
	public string PurchaseOrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

	/// <summary>
	/// Gets or Sets SubscriptionName
	/// </summary>
	[DataMember(Name = "SubscriptionName")]
	public string SubscriptionName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TotalCost
	/// </summary>
	[DataMember(Name = "TotalCost")]
	public double? TotalCost { get; set; }

	/// <summary>
	/// Gets or Sets TotalPrice
	/// </summary>
	[DataMember(Name = "TotalPrice")]
	public double? TotalPrice { get; set; }

	/// <summary>
	/// Gets or Sets VendorID
	/// </summary>
	[DataMember(Name = "VendorID")]
	public int? VendorID { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
