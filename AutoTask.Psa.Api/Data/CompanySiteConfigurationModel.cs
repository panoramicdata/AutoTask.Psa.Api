namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CompanySiteConfigurationModel
/// </summary>
[DataContract]
public class CompanySiteConfigurationModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets LocationName
	/// </summary>
	[DataMember(Name = "LocationName")]
	public string LocationName { get; set; } = string.Empty;
}
