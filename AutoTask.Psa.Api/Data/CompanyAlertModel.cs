namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CompanyAlertModel
/// </summary>
[DataContract]
public class CompanyAlertModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
