namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IContractExclusionSetExcludedRoles
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetExcludedRoleModel</returns>
	[Post("/V1.0/ContractExclusionSetExcludedRoles/query")]
	Task<QueryActionResult<ContractExclusionSetExcludedRoleModel>> QueryAsync([Body] QueryModel queryModel, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/ContractExclusionSetExcludedRoles/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/ContractExclusionSetExcludedRoles/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/ContractExclusionSetExcludedRoles/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetExcludedRoleModel</returns>
	[Get("/V1.0/ContractExclusionSetExcludedRoles/{id}")]
	Task<ContractExclusionSetExcludedRoleModel> GetAsync([AliasAs("id")] long id, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/ContractExclusionSetExcludedRoles/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetExcludedRoleModel</returns>
	[Get("/V1.0/ContractExclusionSetExcludedRoles/query")]
	Task<QueryActionResult<ContractExclusionSetExcludedRoleModel>> QueryAsync([AliasAs("search")] string search, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/ContractExclusionSetExcludedRoles/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search, CancellationToken cancellationToken);
}
