namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IConfigurationItemCategoryUdfAssociationsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ConfigurationItemCategoryUdfAssociationModel</returns>
	[Post("/V1.0/ConfigurationItemCategories/{parentId}/UdfAssociations")]
	Task<ConfigurationItemCategoryUdfAssociationModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] ConfigurationItemCategoryUdfAssociationModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <param name="id"></param>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/ConfigurationItemCategories/{parentId}/UdfAssociations/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ConfigurationItemCategoryUdfAssociationModel</returns>
	[Patch("/V1.0/ConfigurationItemCategories/{parentId}/UdfAssociations")]
	Task<ConfigurationItemCategoryUdfAssociationModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] ConfigurationItemCategoryUdfAssociationModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ConfigurationItemCategoryUdfAssociationModel</returns>
	[Get("/V1.0/ConfigurationItemCategories/{parentId}/UdfAssociations")]
	Task<ConfigurationItemCategoryUdfAssociationModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/ConfigurationItemCategories/{parentId}/UdfAssociations/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/ConfigurationItemCategories/{parentId}/UdfAssociations/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <param name="id"></param>
	/// <returns>Task of ConfigurationItemCategoryUdfAssociationModel</returns>
	[Get("/V1.0/ConfigurationItemCategories/{parentId}/UdfAssociations/{id}")]
	Task<ConfigurationItemCategoryUdfAssociationModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/ConfigurationItemCategories/{parentId}/UdfAssociations/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ConfigurationItemCategoryUdfAssociationModel</returns>
	[Put("/V1.0/ConfigurationItemCategories/{parentId}/UdfAssociations")]
	Task<ConfigurationItemCategoryUdfAssociationModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] ConfigurationItemCategoryUdfAssociationModel entity);
}