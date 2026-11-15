namespace AutoTask.Psa.Api.Data;

/// <summary>
/// SurveyModel
/// </summary>
[DataContract]
public class SurveyModel : EntityModelBase
{
	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DisplayName
	/// </summary>
	[DataMember(Name = "DisplayName")]
	public string DisplayName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;
}
