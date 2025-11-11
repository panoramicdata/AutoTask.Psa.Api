namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IPurchaseOrderItemReceivingChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PurchaseOrderItemReceivingModel</returns>
	[Post("/V1.0/PurchaseOrderItems/{parentId}/Receiving")]
	Task<PurchaseOrderItemReceivingModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] PurchaseOrderItemReceivingModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PurchaseOrderItemReceivingModel</returns>
	[Get("/V1.0/PurchaseOrderItems/{parentId}/Receiving")]
	Task<PurchaseOrderItemReceivingModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/PurchaseOrderItems/{parentId}/Receiving/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/PurchaseOrderItems/{parentId}/Receiving/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PurchaseOrderItemReceivingModel</returns>
	[Get("/V1.0/PurchaseOrderItems/{parentId}/Receiving/{id}")]
	Task<PurchaseOrderItemReceivingModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/PurchaseOrderItems/{parentId}/Receiving/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);
}
