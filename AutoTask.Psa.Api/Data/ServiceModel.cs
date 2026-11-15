namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ServiceModel
/// </summary>
[DataContract]
public class ServiceModel : ServiceCatalogueModelBase
{
	/// <summary>
	/// Gets or Sets MarkupRate
	/// </summary>
	[DataMember(Name = "MarkupRate")]
	public double? MarkupRate { get; set; }

	/// <summary>
	/// Gets or Sets VendorCompanyID
	/// </summary>
	[DataMember(Name = "VendorCompanyID")]
	public int? VendorCompanyID { get; set; }
}
