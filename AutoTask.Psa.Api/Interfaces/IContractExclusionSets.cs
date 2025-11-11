namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IContractExclusionSets
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetModel</returns>
	[Post("/V1.0/ContractExclusionSets")]
	Task<ContractExclusionSetModel> CreateAsync([Body] ContractExclusionSetModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/ContractExclusionSets/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("id")] long id, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetModel</returns>
	[Patch("/V1.0/ContractExclusionSets")]
	Task<ContractExclusionSetModel> PatchAsync([Body] ContractExclusionSetModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetModel</returns>
	[Post("/V1.0/ContractExclusionSets/query")]
	Task<QueryActionResult<ContractExclusionSetModel>> QueryAsync([Body] QueryModel queryModel, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/ContractExclusionSets/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/ContractExclusionSets/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/ContractExclusionSets/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetModel</returns>
	[Get("/V1.0/ContractExclusionSets/{id}")]
	Task<ContractExclusionSetModel> GetAsync([AliasAs("id")] long id, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/ContractExclusionSets/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetModel</returns>
	[Put("/V1.0/ContractExclusionSets")]
	Task<ContractExclusionSetModel> UpdateAsync([Body] ContractExclusionSetModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetModel</returns>
	[Get("/V1.0/ContractExclusionSets/query")]
	Task<QueryActionResult<ContractExclusionSetModel>> QueryAsync([AliasAs("search")] string search, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/ContractExclusionSets/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search, CancellationToken cancellationToken);
}
