namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IPurchaseOrders
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PurchaseOrderModel</returns>
	[Post("/V1.0/PurchaseOrders")]
	Task<PurchaseOrderModel> CreateAsync([Body] PurchaseOrderModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PurchaseOrderModel</returns>
	[Patch("/V1.0/PurchaseOrders")]
	Task<PurchaseOrderModel> PatchAsync([Body] PurchaseOrderModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of PurchaseOrderModel</returns>
	[Post("/V1.0/PurchaseOrders/query")]
	Task<QueryActionResult<PurchaseOrderModel>> QueryAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/PurchaseOrders/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/PurchaseOrders/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/PurchaseOrders/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <returns>Task of PurchaseOrderModel</returns>
	[Get("/V1.0/PurchaseOrders/{id}")]
	Task<PurchaseOrderModel> GetAsync([AliasAs("id")] long id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/PurchaseOrders/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PurchaseOrderModel</returns>
	[Put("/V1.0/PurchaseOrders")]
	Task<PurchaseOrderModel> UpdateAsync([Body] PurchaseOrderModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of PurchaseOrderModel</returns>
	[Get("/V1.0/PurchaseOrders/query")]
	Task<QueryActionResult<PurchaseOrderModel>> QueryAsync([AliasAs("search")] string search);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/PurchaseOrders/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
}
