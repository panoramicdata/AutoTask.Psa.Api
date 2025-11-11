namespace AutoTask.Psa.Api.Data;

/// <summary>
/// UserDefinedFieldListItemModel
/// </summary>
[DataContract]
public class UserDefinedFieldListItemModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets CreateDate
	/// </summary>
	[DataMember(Name = "CreateDate")]
	public DateTime? CreateDate { get; set; }

	/// <summary>
	/// Gets or Sets UdfFieldId
	/// </summary>
	[DataMember(Name = "UdfFieldId")]
	public long? UdfFieldId { get; set; }

	/// <summary>
	/// Gets or Sets ValueForDisplay
	/// </summary>
	[DataMember(Name = "ValueForDisplay")]
	public string ValueForDisplay { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ValueForExport
	/// </summary>
	[DataMember(Name = "ValueForExport")]
	public string ValueForExport { get; set; } = string.Empty;

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
