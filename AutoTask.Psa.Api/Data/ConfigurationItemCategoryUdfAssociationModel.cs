namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ConfigurationItemCategoryUdfAssociationModel
/// </summary>
[DataContract]
public class ConfigurationItemCategoryUdfAssociationModel : ParentedEntityModelBase
{
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
}
