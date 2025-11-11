namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IContractRoleCostsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractRoleCostModel</returns>
	[Post("/V1.0/Contracts/{parentId}/RoleCosts")]
	Task<ContractRoleCostModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] ContractRoleCostModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractRoleCostModel</returns>
	[Patch("/V1.0/Contracts/{parentId}/RoleCosts")]
	Task<ContractRoleCostModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] ContractRoleCostModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractRoleCostModel</returns>
	[Get("/V1.0/Contracts/{parentId}/RoleCosts")]
	Task<ContractRoleCostModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Contracts/{parentId}/RoleCosts/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Contracts/{parentId}/RoleCosts/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractRoleCostModel</returns>
	[Get("/V1.0/Contracts/{parentId}/RoleCosts/{id}")]
	Task<ContractRoleCostModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Contracts/{parentId}/RoleCosts/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractRoleCostModel</returns>
	[Put("/V1.0/Contracts/{parentId}/RoleCosts")]
	Task<ContractRoleCostModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] ContractRoleCostModel entity, CancellationToken cancellationToken);
}
