namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ITaxCategories
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TaxCategoryModel</returns>
	[Post("/V1.0/TaxCategories")]
	Task<TaxCategoryModel> CreateAsync([Body] TaxCategoryModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TaxCategoryModel</returns>
	[Patch("/V1.0/TaxCategories")]
	Task<TaxCategoryModel> PatchAsync([Body] TaxCategoryModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of TaxCategoryModel</returns>
	[Post("/V1.0/TaxCategories/query")]
	Task<QueryActionResult<TaxCategoryModel>> QueryAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/TaxCategories/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/TaxCategories/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/TaxCategories/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <returns>Task of TaxCategoryModel</returns>
	[Get("/V1.0/TaxCategories/{id}")]
	Task<TaxCategoryModel> GetAsync([AliasAs("id")] long id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/TaxCategories/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TaxCategoryModel</returns>
	[Put("/V1.0/TaxCategories")]
	Task<TaxCategoryModel> UpdateAsync([Body] TaxCategoryModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of TaxCategoryModel</returns>
	[Get("/V1.0/TaxCategories/query")]
	Task<QueryActionResult<TaxCategoryModel>> QueryAsync([AliasAs("search")] string search);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/TaxCategories/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
}
