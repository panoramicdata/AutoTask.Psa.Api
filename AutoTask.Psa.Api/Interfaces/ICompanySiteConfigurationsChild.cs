namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICompanySiteConfigurationsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanySiteConfigurationModel</returns>
	[Patch("/V1.0/Companies/{parentId}/SiteConfigurations")]
	Task<CompanySiteConfigurationModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] CompanySiteConfigurationModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanySiteConfigurationModel</returns>
	[Get("/V1.0/Companies/{parentId}/SiteConfigurations")]
	Task<CompanySiteConfigurationModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Companies/{parentId}/SiteConfigurations/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Companies/{parentId}/SiteConfigurations/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanySiteConfigurationModel</returns>
	[Get("/V1.0/Companies/{parentId}/SiteConfigurations/{id}")]
	Task<CompanySiteConfigurationModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Companies/{parentId}/SiteConfigurations/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanySiteConfigurationModel</returns>
	[Put("/V1.0/Companies/{parentId}/SiteConfigurations")]
	Task<CompanySiteConfigurationModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] CompanySiteConfigurationModel entity, CancellationToken cancellationToken);
}
