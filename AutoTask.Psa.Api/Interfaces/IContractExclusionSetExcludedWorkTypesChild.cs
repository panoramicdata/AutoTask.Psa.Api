namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IContractExclusionSetExcludedWorkTypesChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetExcludedWorkTypeModel</returns>
	[Post("/V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes")]
	Task<ContractExclusionSetExcludedWorkTypeModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] ContractExclusionSetExcludedWorkTypeModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetExcludedWorkTypeModel</returns>
	[Get("/V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes")]
	Task<ContractExclusionSetExcludedWorkTypeModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractExclusionSetExcludedWorkTypeModel</returns>
	[Get("/V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes/{id}")]
	Task<ContractExclusionSetExcludedWorkTypeModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);
}
