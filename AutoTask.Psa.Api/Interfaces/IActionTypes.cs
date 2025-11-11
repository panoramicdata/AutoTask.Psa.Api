namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IActionTypes
{
	/// <summary>
	/// Create
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ActionTypeModel</returns>
	[Post("/V1.0/ActionTypes")]
	Task<ActionTypeModel> CreateAsync([Body] ActionTypeModel entity, CancellationToken cancellationToken);

	/// <summary>
	/// Delete
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/ActionTypes/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("id")] long id, CancellationToken cancellationToken);

	/// <summary>
	/// Patch
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ActionTypeModel</returns>
	[Patch("/V1.0/ActionTypes")]
	Task<ActionTypeModel> PatchAsync([Body] ActionTypeModel entity, CancellationToken cancellationToken);

	/// <summary>
	/// Action Types query
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ActionTypeModel</returns>
	[Post("/V1.0/ActionTypes/query")]
	Task<QueryActionResult<ActionTypeModel>> QueryAsync([Body] QueryModel queryModel, CancellationToken cancellationToken);

	/// <summary>
	/// Query Count
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/ActionTypes/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel, CancellationToken cancellationToken);

	/// <summary>
	/// Get entity information
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/ActionTypes/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get field information
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/ActionTypes/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get one ActionType
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ActionTypeModel</returns>
	[Get("/V1.0/ActionTypes/{id}")]
	Task<ActionTypeModel> GetAsync([AliasAs("id")] long id, CancellationToken cancellationToken);

	/// <summary>
	/// Get UDF info
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/ActionTypes/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Update
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ActionTypeModel</returns>
	[Put("/V1.0/ActionTypes")]
	Task<ActionTypeModel> UpdateAsync([Body] ActionTypeModel entity, CancellationToken cancellationToken);

	/// <summary>
	/// String query
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ActionTypeModel</returns>
	[Get("/V1.0/ActionTypes/query")]
	Task<QueryActionResult<ActionTypeModel>> QueryAsync([AliasAs("search")] string search, CancellationToken cancellationToken);

	/// <summary>
	/// String count
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/ActionTypes/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search, CancellationToken cancellationToken);
}
