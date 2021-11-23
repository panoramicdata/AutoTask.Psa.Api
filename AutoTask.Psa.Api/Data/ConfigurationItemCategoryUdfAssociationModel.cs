namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ConfigurationItemCategoryUdfAssociationModel
/// </summary>
[DataContract]
public partial class ConfigurationItemCategoryUdfAssociationModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ConfigurationItemCategoryID
	/// </summary>
	[DataMember(Name = "ConfigurationItemCategoryID")]
	public int? ConfigurationItemCategoryID { get; set; }

	/// <summary>
	/// Gets or Sets IsRequired
	/// </summary>
	[DataMember(Name = "IsRequired")]
	public bool? IsRequired { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFieldDefinitionID
	/// </summary>
	[DataMember(Name = "UserDefinedFieldDefinitionID")]
	public int? UserDefinedFieldDefinitionID { get; set; }

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
