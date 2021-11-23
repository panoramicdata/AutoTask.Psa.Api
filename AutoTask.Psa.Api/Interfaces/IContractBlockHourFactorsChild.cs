namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IContractBlockHourFactorsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ContractBlockHourFactorModel</returns>
	[Post("/V1.0/Contracts/{parentId}/BlockHourFactors")]
	Task<ContractBlockHourFactorModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] ContractBlockHourFactorModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ContractBlockHourFactorModel</returns>
	[Patch("/V1.0/Contracts/{parentId}/BlockHourFactors")]
	Task<ContractBlockHourFactorModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] ContractBlockHourFactorModel entity);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ContractBlockHourFactorModel</returns>
	[Get("/V1.0/Contracts/{parentId}/BlockHourFactors")]
	Task<ContractBlockHourFactorModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Contracts/{parentId}/BlockHourFactors/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Contracts/{parentId}/BlockHourFactors/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <param name="id"></param>
	/// <returns>Task of ContractBlockHourFactorModel</returns>
	[Get("/V1.0/Contracts/{parentId}/BlockHourFactors/{id}")]
	Task<ContractBlockHourFactorModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Contracts/{parentId}/BlockHourFactors/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentId"></param>
	/// <returns>Task of ContractBlockHourFactorModel</returns>
	[Put("/V1.0/Contracts/{parentId}/BlockHourFactors")]
	Task<ContractBlockHourFactorModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] ContractBlockHourFactorModel entity);
}
