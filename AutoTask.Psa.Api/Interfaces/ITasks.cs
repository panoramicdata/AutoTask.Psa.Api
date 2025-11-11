namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ITasks
{
	/// <summary>
	/// Query Tasks
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TaskModel</returns>
	[Post("/V1.0/Tasks/query")]
	Task<QueryActionResult<TaskModel>> QueryAsync([Body] QueryModel queryModel);

	/// <summary>
	/// Count Tasks
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/Tasks/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

	/// <summary>
	/// Get Task entity info
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Tasks/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync();

	/// <summary>
	/// Get Task field info
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Tasks/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync();

	/// <summary>
	/// Get a single task
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TaskModel</returns>
	[Get("/V1.0/Tasks/{id}")]
	Task<TaskModel> GetAsync([AliasAs("id")] long id);

	/// <summary>
	/// Get Task user defined fields
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Tasks/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

	/// <summary>
	/// Query Tasks
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TaskModel</returns>
	[Get("/V1.0/Tasks/query")]
	Task<QueryActionResult<TaskModel>> QueryAsync([AliasAs("search")] string search);

	/// <summary>
	/// Count Tasks by query
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/Tasks/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
}
