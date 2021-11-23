namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IApiVersions
{
	/// <summary>
	/// Get
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ApiVersionResultModel</returns>
	[Get("/VersionInformation")]
	Task<ApiVersionsResultModel> GetAsync(CancellationToken cancellationToken);
}
