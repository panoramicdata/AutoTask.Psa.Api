namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketCategoryModel
/// </summary>
[DataContract]
public partial class TicketCategoryModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets DisplayColorRGB
	/// </summary>
	[DataMember(Name = "DisplayColorRGB")]
	public int? DisplayColorRGB { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

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
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Nickname
	/// </summary>
	[DataMember(Name = "Nickname")]
	public string Nickname { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
