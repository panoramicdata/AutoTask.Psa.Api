namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IUserDefinedFieldDefinitionsApi
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldDefinitionModel</returns>
	[Post("/V1.0/UserDefinedFieldDefinitions")]
	Task<UserDefinedFieldDefinitionModel> CreateAsync([Body] UserDefinedFieldDefinitionModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldDefinitionModel</returns>
	[Patch("/V1.0/UserDefinedFieldDefinitions")]
	Task<UserDefinedFieldDefinitionModel> PatchAsync([Body] UserDefinedFieldDefinitionModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of UserDefinedFieldDefinitionModel</returns>
	[Post("/V1.0/UserDefinedFieldDefinitions/query")]
	Task<UserDefinedFieldDefinitionModel> QueryAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/UserDefinedFieldDefinitions/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/UserDefinedFieldDefinitions/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/UserDefinedFieldDefinitions/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <returns>Task of UserDefinedFieldDefinitionModel</returns>
	[Get("/V1.0/UserDefinedFieldDefinitions/{id}")]
	Task<UserDefinedFieldDefinitionModel> GetAsync([AliasAs("id")] long id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/UserDefinedFieldDefinitions/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldDefinitionModel</returns>
	[Put("/V1.0/UserDefinedFieldDefinitions")]
	Task<UserDefinedFieldDefinitionModel> UpdateAsync([Body] UserDefinedFieldDefinitionModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of UserDefinedFieldDefinitionModel</returns>
	[Get("/V1.0/UserDefinedFieldDefinitions/query")]
	Task<UserDefinedFieldDefinitionModel> StringQueryAsync([AliasAs("search")] string search);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/UserDefinedFieldDefinitions/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
}
