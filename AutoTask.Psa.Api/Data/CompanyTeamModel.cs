namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CompanyTeamModel
/// </summary>
[DataContract]
public class CompanyTeamModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public long? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets IsAssociatedAsComanaged
	/// </summary>
	[DataMember(Name = "IsAssociatedAsComanaged")]
	public bool? IsAssociatedAsComanaged { get; set; }

	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public long? ResourceID { get; set; }
}
