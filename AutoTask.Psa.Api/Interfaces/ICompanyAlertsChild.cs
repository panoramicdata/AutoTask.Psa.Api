namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICompanyAlertsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyAlertModel</returns>
	[Post("/V1.0/Companies/{parentId}/Alerts")]
	Task<CompanyAlertModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] CompanyAlertModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyAlertModel</returns>
	[Patch("/V1.0/Companies/{parentId}/Alerts")]
	Task<CompanyAlertModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] CompanyAlertModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyAlertModel</returns>
	[Get("/V1.0/Companies/{parentId}/Alerts")]
	Task<CompanyAlertModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Companies/{parentId}/Alerts/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Companies/{parentId}/Alerts/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <param name="id"></param>
	/// <returns>Task of CompanyAlertModel</returns>
	[Get("/V1.0/Companies/{parentId}/Alerts/{id}")]
	Task<CompanyAlertModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Companies/{parentId}/Alerts/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of CompanyAlertModel</returns>
	[Put("/V1.0/Companies/{parentId}/Alerts")]
	Task<CompanyAlertModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] CompanyAlertModel entity);
}
