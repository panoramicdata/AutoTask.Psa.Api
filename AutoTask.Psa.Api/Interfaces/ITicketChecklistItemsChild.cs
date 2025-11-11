namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ITicketChecklistItemsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketChecklistItemModel</returns>
	[Post("/V1.0/Tickets/{parentId}/ChecklistItems")]
	Task<TicketChecklistItemModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] TicketChecklistItemModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/Tickets/{parentId}/ChecklistItems/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketChecklistItemModel</returns>
	[Patch("/V1.0/Tickets/{parentId}/ChecklistItems")]
	Task<TicketChecklistItemModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] TicketChecklistItemModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketChecklistItemModel</returns>
	[Get("/V1.0/Tickets/{parentId}/ChecklistItems")]
	Task<TicketChecklistItemModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Tickets/{parentId}/ChecklistItems/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Tickets/{parentId}/ChecklistItems/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketChecklistItemModel</returns>
	[Get("/V1.0/Tickets/{parentId}/ChecklistItems/{id}")]
	Task<TicketChecklistItemModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Tickets/{parentId}/ChecklistItems/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketChecklistItemModel</returns>
	[Put("/V1.0/Tickets/{parentId}/ChecklistItems")]
	Task<TicketChecklistItemModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] TicketChecklistItemModel entity, CancellationToken cancellationToken);
}
