namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IContractServiceBundlesChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractServiceBundleModel</returns>
	[Post("/V1.0/Contracts/{parentId}/ServiceBundles")]
	Task<ContractServiceBundleModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] ContractServiceBundleModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractServiceBundleModel</returns>
	[Patch("/V1.0/Contracts/{parentId}/ServiceBundles")]
	Task<ContractServiceBundleModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] ContractServiceBundleModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractServiceBundleModel</returns>
	[Get("/V1.0/Contracts/{parentId}/ServiceBundles")]
	Task<ContractServiceBundleModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Contracts/{parentId}/ServiceBundles/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Contracts/{parentId}/ServiceBundles/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractServiceBundleModel</returns>
	[Get("/V1.0/Contracts/{parentId}/ServiceBundles/{id}")]
	Task<ContractServiceBundleModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Contracts/{parentId}/ServiceBundles/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractServiceBundleModel</returns>
	[Put("/V1.0/Contracts/{parentId}/ServiceBundles")]
	Task<ContractServiceBundleModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] ContractServiceBundleModel entity, CancellationToken cancellationToken);
}
