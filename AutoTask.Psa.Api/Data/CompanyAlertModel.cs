namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CompanyAlertModel
/// </summary>
[DataContract]
public class CompanyAlertModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets AlertText
	/// </summary>
	[DataMember(Name = "AlertText")]
	public string AlertText { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets AlertTypeID
	/// </summary>
	[DataMember(Name = "AlertTypeID")]
	public int? AlertTypeID { get; set; }

	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }
}
