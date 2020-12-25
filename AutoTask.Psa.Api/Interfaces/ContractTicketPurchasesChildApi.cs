using Refit;
using System.Threading.Tasks;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IContractTicketPurchasesChildApi
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
		/// <returns>Task of ContractTicketPurchaseModel</returns>
		[Post("/V1.0/Contracts/{parentId}/TicketPurchases")]
		Task<ContractTicketPurchaseModel> ContractTicketPurchasesChildCreateEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [Body] ContractTicketPurchaseModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		/// <returns>Task of ContractTicketPurchaseModel</returns>
		[Patch("/V1.0/Contracts/{parentId}/TicketPurchases")]
		Task<ContractTicketPurchaseModel> ContractTicketPurchasesChildPatchEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [Body] ContractTicketPurchaseModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ContractTicketPurchaseModel</returns>
		[Get("/V1.0/Contracts/{parentId}/TicketPurchases")]
		Task<ContractTicketPurchaseModel> ContractTicketPurchasesChildQuery([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/Contracts/{parentId}/TicketPurchases/entityInformation")]
		Task<EntityInformationResultModel> ContractTicketPurchasesChildQueryEntityInformation([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/Contracts/{parentId}/TicketPurchases/entityInformation/fields")]
		Task<FieldInformationResultModel> ContractTicketPurchasesChildQueryFieldDefinitions([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		/// <returns>Task of ContractTicketPurchaseModel</returns>
		[Get("/V1.0/Contracts/{parentId}/TicketPurchases/{id}")]
		Task<ContractTicketPurchaseModel> ContractTicketPurchasesChildQueryItem([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/Contracts/{parentId}/TicketPurchases/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> ContractTicketPurchasesChildQueryUserDefinedFieldDefinitions([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		/// <returns>Task of ContractTicketPurchaseModel</returns>
		[Put("/V1.0/Contracts/{parentId}/TicketPurchases")]
		Task<ContractTicketPurchaseModel> ContractTicketPurchasesChildUpdateEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [Body] ContractTicketPurchaseModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
		#endregion Asynchronous Operations
	}
}
