namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ITicketCategoryFieldDefaults
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of TicketCategoryFieldDefaultsModel</returns>
	[Post("/V1.0/TicketCategoryFieldDefaults/query")]
	Task<QueryActionResult<TicketCategoryFieldDefaultsModel>> QueryAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="queryModel"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/TicketCategoryFieldDefaults/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/TicketCategoryFieldDefaults/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/TicketCategoryFieldDefaults/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <returns>Task of TicketCategoryFieldDefaultsModel</returns>
	[Get("/V1.0/TicketCategoryFieldDefaults/{id}")]
	Task<TicketCategoryFieldDefaultsModel> GetAsync([AliasAs("id")] long id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/TicketCategoryFieldDefaults/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of TicketCategoryFieldDefaultsModel</returns>
	[Get("/V1.0/TicketCategoryFieldDefaults/query")]
	Task<QueryActionResult<TicketCategoryFieldDefaultsModel>> QueryAsync([AliasAs("search")] string search);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="search"></param>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/TicketCategoryFieldDefaults/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
}
