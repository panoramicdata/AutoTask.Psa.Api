using Refit;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IContractsApi
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
		/// <returns>Task of ContractModel</returns>
		[Post("/V1.0/Contracts")]
		System.Threading.Tasks.Task<ContractModel> ContractsCreateEntity([Header("UserAgent")] string userAgent, [Body] ContractModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="restModelInput"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ContractModel</returns>
		[Patch("/V1.0/Contracts")]
		System.Threading.Tasks.Task<ContractModel> ContractsPatchEntity([Header("UserAgent")] string userAgent, [Body] ContractModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ContractModel</returns>
		[Post("/V1.0/Contracts/query")]
		System.Threading.Tasks.Task<ContractModel> ContractsQuery([Header("UserAgent")] string userAgent, [Body] QueryModel queryModel, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Post("/V1.0/Contracts/query/count")]
		System.Threading.Tasks.Task<QueryCountResultModel> ContractsQueryCount([Header("UserAgent")] string userAgent, [Body] QueryModel queryModel, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/Contracts/entityInformation")]
		System.Threading.Tasks.Task<EntityInformationResultModel> ContractsQueryEntityInformation([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/Contracts/entityInformation/fields")]
		System.Threading.Tasks.Task<FieldInformationResultModel> ContractsQueryFieldDefinitions([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ContractModel</returns>
		[Get("/V1.0/Contracts/{id}")]
		System.Threading.Tasks.Task<ContractModel> ContractsQueryItem([Header("UserAgent")] string userAgent, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/Contracts/entityInformation/userDefinedFields")]
		System.Threading.Tasks.Task<UserDefinedFieldInformationResultModel> ContractsQueryUserDefinedFieldDefinitions([Header("UserAgent")] string userAgent, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="restModelInput"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ContractModel</returns>
		[Put("/V1.0/Contracts")]
		System.Threading.Tasks.Task<ContractModel> ContractsUpdateEntity([Header("UserAgent")] string userAgent, [Body] ContractModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ContractModel</returns>
		[Get("/V1.0/Contracts/query")]
		System.Threading.Tasks.Task<ContractModel> ContractsUrlParameterQuery([Header("UserAgent")] string userAgent, [AliasAs("search")] string search, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/Contracts/query/count")]
		System.Threading.Tasks.Task<QueryCountResultModel> ContractsUrlParameterQueryCount([Header("UserAgent")] string userAgent, [AliasAs("search")] string search, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
		#endregion Asynchronous Operations
	}
}
