namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IZoneInformationApiIntegration
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ZoneInformationResultModel</returns>
	[Get("/V1.0/ZoneInformation")]
	Task<ZoneInformationResultModel> ZoneInformationApiIntegrationQueryZoneInformation([AliasAs("user")] string user, CancellationToken cancellationToken);
}
