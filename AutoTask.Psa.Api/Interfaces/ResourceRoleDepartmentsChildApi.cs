namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IResourceRoleDepartmentsChildApi
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ResourceRoleDepartmentModel</returns>
	[Post("/V1.0/Resources/{parentId}/RoleDepartments")]
	Task<ResourceRoleDepartmentModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] ResourceRoleDepartmentModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ResourceRoleDepartmentModel</returns>
	[Patch("/V1.0/Resources/{parentId}/RoleDepartments")]
	Task<ResourceRoleDepartmentModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] ResourceRoleDepartmentModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ResourceRoleDepartmentModel</returns>
	[Get("/V1.0/Resources/{parentId}/RoleDepartments")]
	Task<ResourceRoleDepartmentModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Resources/{parentId}/RoleDepartments/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Resources/{parentId}/RoleDepartments/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <param name="id"></param>
	/// <returns>Task of ResourceRoleDepartmentModel</returns>
	[Get("/V1.0/Resources/{parentId}/RoleDepartments/{id}")]
	Task<ResourceRoleDepartmentModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Resources/{parentId}/RoleDepartments/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ResourceRoleDepartmentModel</returns>
	[Put("/V1.0/Resources/{parentId}/RoleDepartments")]
	Task<ResourceRoleDepartmentModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] ResourceRoleDepartmentModel entity);
}
