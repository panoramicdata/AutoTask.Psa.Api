namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ITicketRmaCreditsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketRmaCreditModel</returns>
	[Post("/V1.0/Tickets/{parentId}/RmaCredits")]
	Task<TicketRmaCreditModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] TicketRmaCreditModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/Tickets/{parentId}/RmaCredits/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketRmaCreditModel</returns>
	[Patch("/V1.0/Tickets/{parentId}/RmaCredits")]
	Task<TicketRmaCreditModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] TicketRmaCreditModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketRmaCreditModel</returns>
	[Get("/V1.0/Tickets/{parentId}/RmaCredits")]
	Task<TicketRmaCreditModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Tickets/{parentId}/RmaCredits/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Tickets/{parentId}/RmaCredits/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketRmaCreditModel</returns>
	[Get("/V1.0/Tickets/{parentId}/RmaCredits/{id}")]
	Task<TicketRmaCreditModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Tickets/{parentId}/RmaCredits/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TicketRmaCreditModel</returns>
	[Put("/V1.0/Tickets/{parentId}/RmaCredits")]
	Task<TicketRmaCreditModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] TicketRmaCreditModel entity, CancellationToken cancellationToken);
}
