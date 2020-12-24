using Refit;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IServiceCallTicketResourcesApi
	{
		#region Asynchronous Operations

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ServiceCallTicketResourceModel</returns>
		[Post("/V1.0/ServiceCallTicketResources/query")]
		System.Threading.Tasks.Task<ServiceCallTicketResourceModel> ServiceCallTicketResourcesQuery([Header("UserAgent")] string userAgent, [Body] QueryModel queryModel, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Post("/V1.0/ServiceCallTicketResources/query/count")]
		System.Threading.Tasks.Task<QueryCountResultModel> ServiceCallTicketResourcesQueryCount([Header("UserAgent")] string userAgent, [Body] QueryModel queryModel, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/ServiceCallTicketResources/entityInformation")]
		System.Threading.Tasks.Task<EntityInformationResultModel> ServiceCallTicketResourcesQueryEntityInformation([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/ServiceCallTicketResources/entityInformation/fields")]
		System.Threading.Tasks.Task<FieldInformationResultModel> ServiceCallTicketResourcesQueryFieldDefinitions([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ServiceCallTicketResourceModel</returns>
		[Get("/V1.0/ServiceCallTicketResources/{id}")]
		System.Threading.Tasks.Task<ServiceCallTicketResourceModel> ServiceCallTicketResourcesQueryItem([Header("UserAgent")] string userAgent, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/ServiceCallTicketResources/entityInformation/userDefinedFields")]
		System.Threading.Tasks.Task<UserDefinedFieldInformationResultModel> ServiceCallTicketResourcesQueryUserDefinedFieldDefinitions([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ServiceCallTicketResourceModel</returns>
		[Get("/V1.0/ServiceCallTicketResources/query")]
		System.Threading.Tasks.Task<ServiceCallTicketResourceModel> ServiceCallTicketResourcesUrlParameterQuery([Header("UserAgent")] string userAgent, [AliasAs("search")] string search, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Get("/V1.0/ServiceCallTicketResources/query/count")]
		System.Threading.Tasks.Task<QueryCountResultModel> ServiceCallTicketResourcesUrlParameterQueryCount([Header("UserAgent")] string userAgent, [AliasAs("search")] string search, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
		#endregion Asynchronous Operations
	}
}
