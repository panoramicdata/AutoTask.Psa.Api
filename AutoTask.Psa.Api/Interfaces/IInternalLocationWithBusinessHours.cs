namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IInternalLocationWithBusinessHours
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
	[Post("/V1.0/InternalLocationWithBusinessHours")]
	Task<InternalLocationWithBusinessHoursModel> CreateAsync([Body] InternalLocationWithBusinessHoursModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
	[Patch("/V1.0/InternalLocationWithBusinessHours")]
	Task<InternalLocationWithBusinessHoursModel> PatchAsync([Body] InternalLocationWithBusinessHoursModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
	[Post("/V1.0/InternalLocationWithBusinessHours/query")]
	Task<QueryActionResult<InternalLocationWithBusinessHoursModel>> QueryAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/InternalLocationWithBusinessHours/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/InternalLocationWithBusinessHours/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/InternalLocationWithBusinessHours/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
	[Get("/V1.0/InternalLocationWithBusinessHours/{id}")]
	Task<InternalLocationWithBusinessHoursModel> GetAsync([AliasAs("id")] long id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/InternalLocationWithBusinessHours/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
	[Put("/V1.0/InternalLocationWithBusinessHours")]
	Task<InternalLocationWithBusinessHoursModel> UpdateAsync([Body] InternalLocationWithBusinessHoursModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of InternalLocationWithBusinessHoursModel</returns>
	[Get("/V1.0/InternalLocationWithBusinessHours/query")]
	Task<QueryActionResult<InternalLocationWithBusinessHoursModel>> QueryAsync([AliasAs("search")] string search);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/InternalLocationWithBusinessHours/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
}
