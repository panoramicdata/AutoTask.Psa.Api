namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ServiceBundleModel
/// </summary>
[DataContract]
public class ServiceBundleModel : ServiceCatalogueModelBase
{
	/// <summary>
	/// Gets or Sets PercentageDiscount
	/// </summary>
	[DataMember(Name = "PercentageDiscount")]
	public double? PercentageDiscount { get; set; }

	/// <summary>
	/// Gets or Sets UnitDiscount
	/// </summary>
	[DataMember(Name = "UnitDiscount")]
	public double? UnitDiscount { get; set; }
}
