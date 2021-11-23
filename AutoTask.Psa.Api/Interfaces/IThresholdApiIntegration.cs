namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IThresholdApiIntegration
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ThresholdStatusResultModel</returns>
	[Get("/V1.0/ThresholdInformation")]
	Task<ThresholdStatusResultModel> ThresholdApiIntegrationQueryThresholdInformation();
}
