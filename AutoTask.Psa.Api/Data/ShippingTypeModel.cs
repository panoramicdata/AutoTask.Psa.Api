namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ShippingTypeModel
/// </summary>
[DataContract]
public class ShippingTypeModel : DescribedNamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets BillingCodeID
	/// </summary>
	[DataMember(Name = "BillingCodeID")]
	public int? BillingCodeID { get; set; }
}
