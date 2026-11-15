namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ConfigurationItemBillingProductAssociationModel
/// </summary>
[DataContract]
public class ConfigurationItemBillingProductAssociationModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets BillingProductID
	/// </summary>
	[DataMember(Name = "BillingProductID")]
	public int? BillingProductID { get; set; }

	/// <summary>
	/// Gets or Sets ConfigurationItemID
	/// </summary>
	[DataMember(Name = "ConfigurationItemID")]
	public int? ConfigurationItemID { get; set; }

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
}
