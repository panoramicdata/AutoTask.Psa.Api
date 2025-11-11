namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICompanySiteConfigurations
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanySiteConfigurationModel</returns>
	[Post("/V1.0/CompanySiteConfigurations/query")]
	Task<QueryActionResult<CompanySiteConfigurationModel>> QueryAsync([Body] QueryModel queryModel, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/CompanySiteConfigurations/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/CompanySiteConfigurations/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/CompanySiteConfigurations/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanySiteConfigurationModel</returns>
	[Get("/V1.0/CompanySiteConfigurations/{id}")]
	Task<CompanySiteConfigurationModel> GetAsync([AliasAs("id")] long id, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/CompanySiteConfigurations/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanySiteConfigurationModel</returns>
	[Get("/V1.0/CompanySiteConfigurations/query")]
	Task<QueryActionResult<CompanySiteConfigurationModel>> QueryAsync([AliasAs("search")] string search, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/CompanySiteConfigurations/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search, CancellationToken cancellationToken);
}
