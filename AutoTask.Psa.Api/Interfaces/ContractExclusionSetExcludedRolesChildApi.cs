using Refit;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IContractExclusionSetExcludedRolesChildApi
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
		/// <returns>Task of ContractExclusionSetExcludedRoleModel</returns>
		[Post("/V1.0/ContractExclusionSets/{parentId}/ExcludedRoles")]
		System.Threading.Tasks.Task<ContractExclusionSetExcludedRoleModel> ContractExclusionSetExcludedRolesChildCreateEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [Body] ContractExclusionSetExcludedRoleModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Delete("/V1.0/ContractExclusionSets/{parentId}/ExcludedRoles/{id}")]
		System.Threading.Tasks.Task<OperationResultModel> ContractExclusionSetExcludedRolesChildDeleteEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ContractExclusionSetExcludedRoleModel</returns>
		[Get("/V1.0/ContractExclusionSets/{parentId}/ExcludedRoles")]
		System.Threading.Tasks.Task<ContractExclusionSetExcludedRoleModel> ContractExclusionSetExcludedRolesChildQuery([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/ContractExclusionSets/{parentId}/ExcludedRoles/entityInformation")]
		System.Threading.Tasks.Task<EntityInformationResultModel> ContractExclusionSetExcludedRolesChildQueryEntityInformation([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/ContractExclusionSets/{parentId}/ExcludedRoles/entityInformation/fields")]
		System.Threading.Tasks.Task<FieldInformationResultModel> ContractExclusionSetExcludedRolesChildQueryFieldDefinitions([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		/// <returns>Task of ContractExclusionSetExcludedRoleModel</returns>
		[Get("/V1.0/ContractExclusionSets/{parentId}/ExcludedRoles/{id}")]
		System.Threading.Tasks.Task<ContractExclusionSetExcludedRoleModel> ContractExclusionSetExcludedRolesChildQueryItem([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/ContractExclusionSets/{parentId}/ExcludedRoles/entityInformation/userDefinedFields")]
		System.Threading.Tasks.Task<UserDefinedFieldInformationResultModel> ContractExclusionSetExcludedRolesChildQueryUserDefinedFieldDefinitions([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
		#endregion Asynchronous Operations
	}
}
