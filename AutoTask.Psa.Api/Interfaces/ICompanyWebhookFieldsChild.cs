namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICompanyWebhookFieldsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyWebhookFieldModel</returns>
	[Post("/V1.0/CompanyWebhooks/{parentId}/Fields")]
	Task<CompanyWebhookFieldModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] CompanyWebhookFieldModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <param name="id"></param>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/CompanyWebhooks/{parentId}/Fields/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyWebhookFieldModel</returns>
	[Patch("/V1.0/CompanyWebhooks/{parentId}/Fields")]
	Task<CompanyWebhookFieldModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] CompanyWebhookFieldModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyWebhookFieldModel</returns>
	[Get("/V1.0/CompanyWebhooks/{parentId}/Fields")]
	Task<CompanyWebhookFieldModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/CompanyWebhooks/{parentId}/Fields/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/CompanyWebhooks/{parentId}/Fields/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <param name="id"></param>
	/// <returns>Task of CompanyWebhookFieldModel</returns>
	[Get("/V1.0/CompanyWebhooks/{parentId}/Fields/{id}")]
	Task<CompanyWebhookFieldModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/CompanyWebhooks/{parentId}/Fields/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyWebhookFieldModel</returns>
	[Put("/V1.0/CompanyWebhooks/{parentId}/Fields")]
	Task<CompanyWebhookFieldModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] CompanyWebhookFieldModel entity);
}
