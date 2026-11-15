namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContactBillingProductAssociationModel
/// </summary>
[DataContract]
public class ContactBillingProductAssociationModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets BillingProductID
	/// </summary>
	[DataMember(Name = "BillingProductID")]
	public int? BillingProductID { get; set; }

	/// <summary>
	/// Gets or Sets ContactID
	/// </summary>
	[DataMember(Name = "ContactID")]
	public int? ContactID { get; set; }

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
