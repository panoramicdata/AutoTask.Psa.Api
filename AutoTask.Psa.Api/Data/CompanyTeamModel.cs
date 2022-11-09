namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CompanyTeamModel
/// </summary>
[DataContract]
public class CompanyTeamModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
