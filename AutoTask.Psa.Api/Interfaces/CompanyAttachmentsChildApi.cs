using Refit;
using System.Threading.Tasks;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ICompanyAttachmentsChildApi
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="entity"></param>
		/// <param name="parentId"></param>
		/// <returns>Task of CompanyAttachmentModel</returns>
		[Post("/V1.0/Companies/{parentId}/Attachments")]
		Task<CompanyAttachmentModel> CreateAsync([Body] CompanyAttachmentModel entity, [AliasAs("parentId")] long? parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <param name="parentId"></param>
		/// <returns>Task of OperationResultModel</returns>
		[Delete("/V1.0/Companies/{parentId}/Attachments/{id}")]
		Task<OperationResultModel> DeleteAsync([AliasAs("id")] long? id, [AliasAs("parentId")] long? parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of CompanyAttachmentModel</returns>
		[Get("/V1.0/Companies/{parentId}/Attachments")]
		Task<CompanyAttachmentModel> QueryAsync([AliasAs("parentId")] long? parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <param name="parentId"></param>
		/// <returns>Task of CompanyAttachmentModel</returns>
		[Get("/V1.0/Companies/{parentId}/Attachments/{id}")]
		Task<CompanyAttachmentModel> GetAsync([AliasAs("id")] long? id, [AliasAs("parentId")] long? parentId);
	}
}
