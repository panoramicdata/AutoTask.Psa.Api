
using AutoTask.Psa.Api.Data;
using Refit;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IActionTypesApi
	{
		#region Asynchronous Operations

		/// <summary>
		///
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="restModelInput"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ActionTypeModel</returns>
		[Post("/V1.0/ActionTypes")]
		Task<ActionTypeModel> ActionTypesCreateEntity(
			[Header("UserAgent")] string userAgent,
			[Body] ActionTypeModel restModelInput,
			string ApiIntegrationCode,
			string UserName,
			string Secret,
			string ImpersonationResourceId = null);

		/// <summary>
		/// Get one ActionType
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of OperationResultModel</returns>
		[Delete("/V1.0/ActionTypes/{id}")]
		Task<OperationResultModel> ActionTypesDeleteEntity([Header("UserAgent")] string userAgent, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		/// Action Types
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="restModelInput"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ActionTypeModel</returns>
		[Patch("/V1.0/ActionTypes")]
		Task<ActionTypeModel> ActionTypesPatchEntity([Header("UserAgent")] string userAgent, [Body] ActionTypeModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		/// Action Types query
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ActionTypeModel</returns>
		[Post("/V1.0/ActionTypes/query")]
		Task<ActionTypeModel> ActionTypesQuery([Header("UserAgent")] string userAgent, [Body] QueryModel queryModel, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		/// Query Count
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Post("/V1.0/ActionTypes/query/count")]
		Task<QueryCountResultModel> ActionTypesQueryCount([Header("UserAgent")] string userAgent, [Body] QueryModel queryModel, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		/// Get ActionType entity information
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/ActionTypes/entityInformation")]
		Task<EntityInformationResultModel> ActionTypesQueryEntityInformation([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		/// Get ActionType fields
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/ActionTypes/entityInformation/fields")]
		Task<FieldInformationResultModel> ActionTypesQueryFieldDefinitions([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		/// Get one ActionType
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ActionTypeModel</returns>
		[Get("/V1.0/ActionTypes/{id}")]
		Task<ActionTypeModel> ActionTypesQueryItem([Header("UserAgent")] string userAgent, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/ActionTypes/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> ActionTypesQueryUserDefinedFieldDefinitions([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="restModelInput"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ActionTypeModel</returns>
		[Put("/V1.0/ActionTypes")]
		Task<ActionTypeModel> ActionTypesUpdateEntity([Header("UserAgent")] string userAgent, [Body] ActionTypeModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ActionTypeModel</returns>
		[Get("/V1.0/ActionTypes/query")]
		Task<ActionTypeModel> ActionTypesUrlParameterQuery([Header("UserAgent")] string userAgent, [AliasAs("search")] string search, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Get("/V1.0/ActionTypes/query/count")]
		Task<QueryCountResultModel> ActionTypesUrlParameterQueryCount([Header("UserAgent")] string userAgent, [AliasAs("search")] string search, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
		#endregion Asynchronous Operations
	}
}
