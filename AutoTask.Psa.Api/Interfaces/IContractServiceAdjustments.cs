namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IContractServiceAdjustments
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ContractServiceAdjustmentModel</returns>
	[Post("/V1.0/ContractServiceAdjustments")]
	Task<ContractServiceAdjustmentModel> CreateAsync([Body] ContractServiceAdjustmentModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/ContractServiceAdjustments/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/ContractServiceAdjustments/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/ContractServiceAdjustments/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync(CancellationToken cancellationToken);
}
