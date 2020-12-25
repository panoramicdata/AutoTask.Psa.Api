using Refit;
using System.Threading.Tasks;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IExpenseItemsChildApi
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
		/// <returns>Task of ExpenseItemModel</returns>
		[Post("/V1.0/Expenses/{parentId}/Items")]
		Task<ExpenseItemModel> ExpenseItemsChildCreateEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [Body] ExpenseItemModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		/// <returns>Task of ExpenseItemModel</returns>
		[Patch("/V1.0/Expenses/{parentId}/Items")]
		Task<ExpenseItemModel> ExpenseItemsChildPatchEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [Body] ExpenseItemModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ExpenseItemModel</returns>
		[Get("/V1.0/Expenses/{parentId}/Items")]
		Task<ExpenseItemModel> ExpenseItemsChildQuery([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/Expenses/{parentId}/Items/entityInformation")]
		Task<EntityInformationResultModel> ExpenseItemsChildQueryEntityInformation([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/Expenses/{parentId}/Items/entityInformation/fields")]
		Task<FieldInformationResultModel> ExpenseItemsChildQueryFieldDefinitions([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		/// <returns>Task of ExpenseItemModel</returns>
		[Get("/V1.0/Expenses/{parentId}/Items/{id}")]
		Task<ExpenseItemModel> ExpenseItemsChildQueryItem([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/Expenses/{parentId}/Items/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> ExpenseItemsChildQueryUserDefinedFieldDefinitions([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		/// <returns>Task of ExpenseItemModel</returns>
		[Put("/V1.0/Expenses/{parentId}/Items")]
		Task<ExpenseItemModel> ExpenseItemsChildUpdateEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [Body] ExpenseItemModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
		#endregion Asynchronous Operations
	}
}
