using Refit;
using System.Threading.Tasks;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IInternalLocationWithBusinessHoursApi
	{
		#region Asynchronous Operations

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="restModelInput"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
		[Post("/V1.0/InternalLocationWithBusinessHours")]
		Task<InternalLocationWithBusinessHoursModel> InternalLocationWithBusinessHoursCreateEntity([Header("UserAgent")] string userAgent, [Body] InternalLocationWithBusinessHoursModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="restModelInput"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
		[Patch("/V1.0/InternalLocationWithBusinessHours")]
		Task<InternalLocationWithBusinessHoursModel> InternalLocationWithBusinessHoursPatchEntity([Header("UserAgent")] string userAgent, [Body] InternalLocationWithBusinessHoursModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
		[Post("/V1.0/InternalLocationWithBusinessHours/query")]
		Task<InternalLocationWithBusinessHoursModel> InternalLocationWithBusinessHoursQuery([Header("UserAgent")] string userAgent, [Body] QueryModel queryModel, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Post("/V1.0/InternalLocationWithBusinessHours/query/count")]
		Task<QueryCountResultModel> InternalLocationWithBusinessHoursQueryCount([Header("UserAgent")] string userAgent, [Body] QueryModel queryModel, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/InternalLocationWithBusinessHours/entityInformation")]
		Task<EntityInformationResultModel> InternalLocationWithBusinessHoursQueryEntityInformation([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/InternalLocationWithBusinessHours/entityInformation/fields")]
		Task<FieldInformationResultModel> InternalLocationWithBusinessHoursQueryFieldDefinitions([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
		[Get("/V1.0/InternalLocationWithBusinessHours/{id}")]
		Task<InternalLocationWithBusinessHoursModel> InternalLocationWithBusinessHoursQueryItem([Header("UserAgent")] string userAgent, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/InternalLocationWithBusinessHours/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> InternalLocationWithBusinessHoursQueryUserDefinedFieldDefinitions([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="restModelInput"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
		[Put("/V1.0/InternalLocationWithBusinessHours")]
		Task<InternalLocationWithBusinessHoursModel> InternalLocationWithBusinessHoursUpdateEntity([Header("UserAgent")] string userAgent, [Body] InternalLocationWithBusinessHoursModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
		[Get("/V1.0/InternalLocationWithBusinessHours/query")]
		Task<InternalLocationWithBusinessHoursModel> InternalLocationWithBusinessHoursUrlParameterQuery([Header("UserAgent")] string userAgent, [AliasAs("search")] string search, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/InternalLocationWithBusinessHours/query/count")]
		Task<QueryCountResultModel> InternalLocationWithBusinessHoursUrlParameterQueryCount([Header("UserAgent")] string userAgent, [AliasAs("search")] string search, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
		#endregion Asynchronous Operations
	}
}
