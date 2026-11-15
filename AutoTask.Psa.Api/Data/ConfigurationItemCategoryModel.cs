namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ConfigurationItemCategoryModel
/// </summary>
[DataContract]
public class ConfigurationItemCategoryModel : NamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets DisplayColorRGB
	/// </summary>
	[DataMember(Name = "DisplayColorRGB")]
	public int? DisplayColorRGB { get; set; }

	/// <summary>
	/// Gets or Sets IsClientPortalDefault
	/// </summary>
	[DataMember(Name = "IsClientPortalDefault")]
	public bool? IsClientPortalDefault { get; set; }

	/// <summary>
	/// Gets or Sets IsGlobalDefault
	/// </summary>
	[DataMember(Name = "IsGlobalDefault")]
	public bool? IsGlobalDefault { get; set; }

	/// <summary>
	/// Gets or Sets Nickname
	/// </summary>
	[DataMember(Name = "Nickname")]
	public string Nickname { get; set; } = string.Empty;
}
