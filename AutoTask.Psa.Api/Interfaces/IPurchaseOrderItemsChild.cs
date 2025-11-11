namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IPurchaseOrderItemsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PurchaseOrderItemModel</returns>
	[Post("/V1.0/PurchaseOrders/{parentId}/Items")]
	Task<PurchaseOrderItemModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] PurchaseOrderItemModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PurchaseOrderItemModel</returns>
	[Patch("/V1.0/PurchaseOrders/{parentId}/Items")]
	Task<PurchaseOrderItemModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] PurchaseOrderItemModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PurchaseOrderItemModel</returns>
	[Get("/V1.0/PurchaseOrders/{parentId}/Items")]
	Task<PurchaseOrderItemModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/PurchaseOrders/{parentId}/Items/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/PurchaseOrders/{parentId}/Items/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PurchaseOrderItemModel</returns>
	[Get("/V1.0/PurchaseOrders/{parentId}/Items/{id}")]
	Task<PurchaseOrderItemModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/PurchaseOrders/{parentId}/Items/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PurchaseOrderItemModel</returns>
	[Put("/V1.0/PurchaseOrders/{parentId}/Items")]
	Task<PurchaseOrderItemModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] PurchaseOrderItemModel entity, CancellationToken cancellationToken);
}
