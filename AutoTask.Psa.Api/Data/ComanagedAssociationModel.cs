namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ComanagedAssociationModel
/// </summary>
[DataContract]
public class ComanagedAssociationModel : EntityModelBase
{
	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public int? ResourceID { get; set; }
}
