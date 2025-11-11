namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ITicketAttachmentsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketAttachmentModel</returns>
	[Post("/V1.0/Tickets/{parentId}/Attachments")]
	Task<TicketAttachmentModel> CreateAsync([Body] TicketAttachmentModel entity, [AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/Tickets/{parentId}/Attachments/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("id")] long? id, [AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketAttachmentModel</returns>
	[Get("/V1.0/Tickets/{parentId}/Attachments")]
	Task<TicketAttachmentModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketAttachmentModel</returns>
	[Get("/V1.0/Tickets/{parentId}/Attachments/{id}")]
	Task<TicketAttachmentModel> GetAsync([AliasAs("id")] long? id, [AliasAs("parentId")] long? parentId);
}
