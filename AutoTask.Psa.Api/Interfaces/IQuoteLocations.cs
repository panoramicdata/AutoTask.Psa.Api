namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IQuoteLocations
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QuoteLocationModel</returns>
	[Post("/V1.0/QuoteLocations")]
	Task<QuoteLocationModel> CreateAsync([Body] QuoteLocationModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QuoteLocationModel</returns>
	[Patch("/V1.0/QuoteLocations")]
	Task<QuoteLocationModel> PatchAsync([Body] QuoteLocationModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of QuoteLocationModel</returns>
	[Post("/V1.0/QuoteLocations/query")]
	Task<QueryActionResult<QuoteLocationModel>> QueryAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/QuoteLocations/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/QuoteLocations/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/QuoteLocations/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <returns>Task of QuoteLocationModel</returns>
	[Get("/V1.0/QuoteLocations/{id}")]
	Task<QuoteLocationModel> GetAsync([AliasAs("id")] long id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/QuoteLocations/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QuoteLocationModel</returns>
	[Put("/V1.0/QuoteLocations")]
	Task<QuoteLocationModel> UpdateAsync([Body] QuoteLocationModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of QuoteLocationModel</returns>
	[Get("/V1.0/QuoteLocations/query")]
	Task<QueryActionResult<QuoteLocationModel>> QueryAsync([AliasAs("search")] string search);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/QuoteLocations/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
}
