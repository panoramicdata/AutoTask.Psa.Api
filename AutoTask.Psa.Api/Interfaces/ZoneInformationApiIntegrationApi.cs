using Refit;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IZoneInformationApiIntegrationApi
	{
		#region Asynchronous Operations

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="user"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ZoneInformationResultModel</returns>
		[Get("/V1.0/ZoneInformation")]
		System.Threading.Tasks.Task<ZoneInformationResultModel> ZoneInformationApiIntegrationQueryZoneInformation([Header("UserAgent")] string userAgent, [AliasAs("user")] string user, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
		#endregion Asynchronous Operations
	}
}
