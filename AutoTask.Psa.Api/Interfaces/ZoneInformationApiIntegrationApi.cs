using AutoTask.Psa.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IZoneInformationApiIntegrationApi
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="user"></param>
		/// <returns>Task of ZoneInformationResultModel</returns>
		[Get("/V1.0/ZoneInformation")]
		Task<ZoneInformationResultModel> ZoneInformationApiIntegrationQueryZoneInformation([AliasAs("user")] string user);
	}
}
