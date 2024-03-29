namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ApiVersionResultModel
/// </summary>
[DataContract]
public class ApiVersionsResultModel
{
	/// <summary>
	/// Gets or Sets ApiVersions
	/// </summary>
	[DataMember(Name = "ApiVersions")]
	public List<string> ApiVersions { get; set; } = new();
}
