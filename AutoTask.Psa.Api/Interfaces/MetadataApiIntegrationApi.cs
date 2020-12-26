using Refit;
using System.Threading.Tasks;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMetadataApiIntegrationApi
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of GlobalEntityInformationResultModel</returns>
		[Get("/V1.0/EntityInformation")]
		Task<GlobalEntityInformationResultModel> GetEntityInfoAsync(string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
	}
}
