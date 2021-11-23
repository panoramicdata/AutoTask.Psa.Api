namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICompanyWebhookUdfFieldsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyWebhookUdfFieldModel</returns>
	[Post("/V1.0/CompanyWebhooks/{parentId}/UdfFields")]
	Task<CompanyWebhookUdfFieldModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] CompanyWebhookUdfFieldModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <param name="id"></param>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/CompanyWebhooks/{parentId}/UdfFields/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyWebhookUdfFieldModel</returns>
	[Patch("/V1.0/CompanyWebhooks/{parentId}/UdfFields")]
	Task<CompanyWebhookUdfFieldModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] CompanyWebhookUdfFieldModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyWebhookUdfFieldModel</returns>
	[Get("/V1.0/CompanyWebhooks/{parentId}/UdfFields")]
	Task<CompanyWebhookUdfFieldModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/CompanyWebhooks/{parentId}/UdfFields/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/CompanyWebhooks/{parentId}/UdfFields/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <param name="id"></param>
	/// <returns>Task of CompanyWebhookUdfFieldModel</returns>
	[Get("/V1.0/CompanyWebhooks/{parentId}/UdfFields/{id}")]
	Task<CompanyWebhookUdfFieldModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/CompanyWebhooks/{parentId}/UdfFields/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyWebhookUdfFieldModel</returns>
	[Put("/V1.0/CompanyWebhooks/{parentId}/UdfFields")]
	Task<CompanyWebhookUdfFieldModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] CompanyWebhookUdfFieldModel entity);
}
