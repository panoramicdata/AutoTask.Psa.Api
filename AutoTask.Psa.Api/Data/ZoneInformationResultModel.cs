namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ZoneInformationResultModel
/// </summary>
[DataContract]
public partial class ZoneInformationResultModel
{
	/// <summary>
	/// Gets or Sets ZoneName
	/// </summary>
	[DataMember(Name = "ZoneName")]
	public string ZoneName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Url
	/// </summary>
	[DataMember(Name = "Url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets WebUrl
	/// </summary>
	[DataMember(Name = "WebUrl")]
	public string WebUrl { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CI
	/// </summary>
	[DataMember(Name = "CI")]
	public int? CI { get; set; }
}
