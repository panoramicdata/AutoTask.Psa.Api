using Refit;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IConfigurationItemNotesChildApi
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
		/// <returns>Task of ConfigurationItemNoteModel</returns>
		[Post("/V1.0/ConfigurationItems/{parentId}/Notes")]
		System.Threading.Tasks.Task<ConfigurationItemNoteModel> ConfigurationItemNotesChildCreateEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [Body] ConfigurationItemNoteModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		/// <returns>Task of ConfigurationItemNoteModel</returns>
		[Patch("/V1.0/ConfigurationItems/{parentId}/Notes")]
		System.Threading.Tasks.Task<ConfigurationItemNoteModel> ConfigurationItemNotesChildPatchEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [Body] ConfigurationItemNoteModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of ConfigurationItemNoteModel</returns>
		[Get("/V1.0/ConfigurationItems/{parentId}/Notes")]
		System.Threading.Tasks.Task<ConfigurationItemNoteModel> ConfigurationItemNotesChildQuery([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/ConfigurationItems/{parentId}/Notes/entityInformation")]
		System.Threading.Tasks.Task<EntityInformationResultModel> ConfigurationItemNotesChildQueryEntityInformation([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/ConfigurationItems/{parentId}/Notes/entityInformation/fields")]
		System.Threading.Tasks.Task<FieldInformationResultModel> ConfigurationItemNotesChildQueryFieldDefinitions([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		/// <returns>Task of ConfigurationItemNoteModel</returns>
		[Get("/V1.0/ConfigurationItems/{parentId}/Notes/{id}")]
		System.Threading.Tasks.Task<ConfigurationItemNoteModel> ConfigurationItemNotesChildQueryItem([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		[Get("/V1.0/ConfigurationItems/{parentId}/Notes/entityInformation/userDefinedFields")]
		System.Threading.Tasks.Task<UserDefinedFieldInformationResultModel> ConfigurationItemNotesChildQueryUserDefinedFieldDefinitions([Header("UserAgent")] string userAgent, [AliasAs("parentId")] string parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

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
		/// <returns>Task of ConfigurationItemNoteModel</returns>
		[Put("/V1.0/ConfigurationItems/{parentId}/Notes")]
		System.Threading.Tasks.Task<ConfigurationItemNoteModel> ConfigurationItemNotesChildUpdateEntity([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, [Body] ConfigurationItemNoteModel restModelInput, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
		#endregion Asynchronous Operations
	}
}
