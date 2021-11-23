namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IActionTypesApi
{
	/// <summary>
	/// Create
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="entity"></param>
	/// <returns>Task of ActionTypeModel</returns>
	[Post("/V1.0/ActionTypes")]
	Task<ActionTypeModel> CreateAsync([Body] ActionTypeModel entity);

	/// <summary>
	/// Delete
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/ActionTypes/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("id")] long id);

	/// <summary>
	/// Patch
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="entity"></param>
	/// <returns>Task of ActionTypeModel</returns>
	[Patch("/V1.0/ActionTypes")]
	Task<ActionTypeModel> PatchAsync([Body] ActionTypeModel entity);

	/// <summary>
	/// Action Types query
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of ActionTypeModel</returns>
	[Post("/V1.0/ActionTypes/query")]
	Task<QueryActionResult<ActionTypeModel>> QueryAsync([Body] QueryModel queryModel);

	/// <summary>
	/// Query Count
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/ActionTypes/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

	/// <summary>
	/// Get entity information
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/ActionTypes/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync();

	/// <summary>
	/// Get field information
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/ActionTypes/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync();

	/// <summary>
	/// Get one ActionType
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <returns>Task of ActionTypeModel</returns>
	[Get("/V1.0/ActionTypes/{id}")]
	Task<ActionTypeModel> GetAsync([AliasAs("id")] long id);

	/// <summary>
	/// Get UDF info
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/ActionTypes/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

	/// <summary>
	/// Update
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="entity"></param>
	/// <returns>Task of ActionTypeModel</returns>
	[Put("/V1.0/ActionTypes")]
	Task<ActionTypeModel> UpdateAsync([Body] ActionTypeModel entity);

	/// <summary>
	/// String query
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of ActionTypeModel</returns>
	[Get("/V1.0/ActionTypes/query")]
	Task<ActionTypeModel> StringQueryAsync([AliasAs("search")] string search);

	/// <summary>
	/// String count
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/ActionTypes/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
}
