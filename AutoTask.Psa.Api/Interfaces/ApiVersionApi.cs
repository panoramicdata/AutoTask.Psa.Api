using Refit;
using System.Threading.Tasks;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IApiVersionApi
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiVersionResultModel</returns>
		[Get("/VersionInformation")]
		Task<ApiVersionResultModel> ApiVersionApiVersionInformation(string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
	}
}
