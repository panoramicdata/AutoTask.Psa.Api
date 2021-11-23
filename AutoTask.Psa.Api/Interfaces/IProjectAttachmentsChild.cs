namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IProjectAttachmentsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="entity"></param>
	/// <param name="parentId"></param>
	/// <returns>Task of ProjectAttachmentModel</returns>
	[Post("/V1.0/Projects/{parentId}/Attachments")]
	Task<ProjectAttachmentModel> CreateAsync([Body] ProjectAttachmentModel entity, [AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <param name="parentId"></param>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/Projects/{parentId}/Attachments/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("id")] long? id, [AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ProjectAttachmentModel</returns>
	[Get("/V1.0/Projects/{parentId}/Attachments")]
	Task<ProjectAttachmentModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <param name="parentId"></param>
	/// <returns>Task of ProjectAttachmentModel</returns>
	[Get("/V1.0/Projects/{parentId}/Attachments/{id}")]
	Task<ProjectAttachmentModel> GetAsync([AliasAs("id")] long? id, [AliasAs("parentId")] long? parentId);
}
