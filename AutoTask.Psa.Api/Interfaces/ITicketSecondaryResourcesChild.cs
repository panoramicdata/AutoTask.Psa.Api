namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ITicketSecondaryResourcesChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of TicketSecondaryResourceModel</returns>
	[Post("/V1.0/Tickets/{parentId}/SecondaryResources")]
	Task<TicketSecondaryResourceModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] TicketSecondaryResourceModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <param name="id"></param>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/Tickets/{parentId}/SecondaryResources/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of TicketSecondaryResourceModel</returns>
	[Get("/V1.0/Tickets/{parentId}/SecondaryResources")]
	Task<TicketSecondaryResourceModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Tickets/{parentId}/SecondaryResources/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Tickets/{parentId}/SecondaryResources/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <param name="id"></param>
	/// <returns>Task of TicketSecondaryResourceModel</returns>
	[Get("/V1.0/Tickets/{parentId}/SecondaryResources/{id}")]
	Task<TicketSecondaryResourceModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Tickets/{parentId}/SecondaryResources/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId);
}
