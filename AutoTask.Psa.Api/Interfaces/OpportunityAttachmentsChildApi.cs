using Refit;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IOpportunityAttachmentsChildApi
	{
		#region Asynchronous Operations

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="restModelInput"></param>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of OpportunityAttachmentModel</returns>
		[Post("/V1.0/Opportunities/{parentId}/Attachments")]
		System.Threading.Tasks.Task<OpportunityAttachmentModel> OpportunityAttachmentsChildCreateEntity([Header("UserAgent")] string userAgent, [Body] OpportunityAttachmentModel restModelInput, [AliasAs("parentId")] long? parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of OperationResultModel</returns>
		[Delete("/V1.0/Opportunities/{parentId}/Attachments/{id}")]
		System.Threading.Tasks.Task<OperationResultModel> OpportunityAttachmentsChildDeleteEntity([Header("UserAgent")] string userAgent, [AliasAs("id")] long? id, [AliasAs("parentId")] long? parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of OpportunityAttachmentModel</returns>
		[Get("/V1.0/Opportunities/{parentId}/Attachments")]
		System.Threading.Tasks.Task<OpportunityAttachmentModel> OpportunityAttachmentsChildQuery([Header("UserAgent")] string userAgent, [AliasAs("parentId")] long? parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <param name="parentId"></param>
		/// <param name="ApiIntegrationCode">API Integration Code</param>
		/// <param name="UserName">User Name</param>
		/// <param name="Secret">Secret</param>
		/// <param name="ImpersonationResourceId">Impersonation Resource Key (optional)</param>
		/// <returns>Task of OpportunityAttachmentModel</returns>
		[Get("/V1.0/Opportunities/{parentId}/Attachments/{id}")]
		System.Threading.Tasks.Task<OpportunityAttachmentModel> OpportunityAttachmentsChildQueryItem([Header("UserAgent")] string userAgent, [AliasAs("id")] long? id, [AliasAs("parentId")] long? parentId, string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);
		#endregion Asynchronous Operations
	}
}
