namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IPriceListWorkTypeModifiers
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PriceListWorkTypeModifierModel</returns>
	[Patch("/V1.0/PriceListWorkTypeModifiers")]
	Task<PriceListWorkTypeModifierModel> PatchAsync([Body] PriceListWorkTypeModifierModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of PriceListWorkTypeModifierModel</returns>
	[Post("/V1.0/PriceListWorkTypeModifiers/query")]
	Task<QueryActionResult<PriceListWorkTypeModifierModel>> QueryAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/PriceListWorkTypeModifiers/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/PriceListWorkTypeModifiers/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/PriceListWorkTypeModifiers/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <returns>Task of PriceListWorkTypeModifierModel</returns>
	[Get("/V1.0/PriceListWorkTypeModifiers/{id}")]
	Task<PriceListWorkTypeModifierModel> GetAsync([AliasAs("id")] long id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/PriceListWorkTypeModifiers/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of PriceListWorkTypeModifierModel</returns>
	[Put("/V1.0/PriceListWorkTypeModifiers")]
	Task<PriceListWorkTypeModifierModel> UpdateAsync([Body] PriceListWorkTypeModifierModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of PriceListWorkTypeModifierModel</returns>
	[Get("/V1.0/PriceListWorkTypeModifiers/query")]
	Task<QueryActionResult<PriceListWorkTypeModifierModel>> QueryAsync([AliasAs("search")] string search);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/PriceListWorkTypeModifiers/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
}
