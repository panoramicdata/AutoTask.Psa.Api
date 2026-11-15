namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketCategoryModel
/// </summary>
[DataContract]
public class TicketCategoryModel : NamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets DisplayColorRGB
	/// </summary>
	[DataMember(Name = "DisplayColorRGB")]
	public int? DisplayColorRGB { get; set; }

	/// <summary>
	/// Gets or Sets IsApiOnly
	/// </summary>
	[DataMember(Name = "IsApiOnly")]
	public bool? IsApiOnly { get; set; }

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
