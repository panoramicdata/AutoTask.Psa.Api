using Refit;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IServiceCallTaskResourcesChildApi
	{
		#region Asynchronous Operations

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="restModelInput"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ServiceCallTaskResourceModel</returns>
		[Post("/V1.0/ServiceCallTasks/{parentId}/Resources")]
		System.Threading.Tasks.Task<ServiceCallTaskResourceModel> ServiceCallTaskResourcesChildCreateEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [Body] ServiceCallTaskResourceModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="id"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of OperationResultModel</returns>
		[Delete("/V1.0/ServiceCallTasks/{parentId}/Resources/{id}")]
		System.Threading.Tasks.Task<OperationResultModel> ServiceCallTaskResourcesChildDeleteEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ServiceCallTaskResourceModel</returns>
		[Get("/V1.0/ServiceCallTasks/{parentId}/Resources")]
		System.Threading.Tasks.Task<ServiceCallTaskResourceModel> ServiceCallTaskResourcesChildQuery([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/ServiceCallTasks/{parentId}/Resources/entityInformation")]
		System.Threading.Tasks.Task<EntityInformationResultModel> ServiceCallTaskResourcesChildQueryEntityInformation([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/ServiceCallTasks/{parentId}/Resources/entityInformation/fields")]
		System.Threading.Tasks.Task<FieldInformationResultModel> ServiceCallTaskResourcesChildQueryFieldDefinitions([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="id"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ServiceCallTaskResourceModel</returns>
		[Get("/V1.0/ServiceCallTasks/{parentId}/Resources/{id}")]
		System.Threading.Tasks.Task<ServiceCallTaskResourceModel> ServiceCallTaskResourcesChildQueryItem([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/ServiceCallTasks/{parentId}/Resources/entityInformation/userDefinedFields")]
		System.Threading.Tasks.Task<UserDefinedFieldInformationResultModel> ServiceCallTaskResourcesChildQueryUserDefinedFieldDefinitions([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
		#endregion Asynchronous Operations
	}
}
