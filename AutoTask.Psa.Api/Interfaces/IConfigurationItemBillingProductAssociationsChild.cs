namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IConfigurationItemBillingProductAssociationsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ConfigurationItemBillingProductAssociationModel</returns>
	[Post("/V1.0/ConfigurationItems/{parentId}/BillingProductAssociations")]
	Task<ConfigurationItemBillingProductAssociationModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] ConfigurationItemBillingProductAssociationModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OperationResultModel</returns>
	[Delete("/V1.0/ConfigurationItems/{parentId}/BillingProductAssociations/{id}")]
	Task<OperationResultModel> DeleteAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ConfigurationItemBillingProductAssociationModel</returns>
	[Patch("/V1.0/ConfigurationItems/{parentId}/BillingProductAssociations")]
	Task<ConfigurationItemBillingProductAssociationModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] ConfigurationItemBillingProductAssociationModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ConfigurationItemBillingProductAssociationModel</returns>
	[Get("/V1.0/ConfigurationItems/{parentId}/BillingProductAssociations")]
	Task<ConfigurationItemBillingProductAssociationModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/ConfigurationItems/{parentId}/BillingProductAssociations/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/ConfigurationItems/{parentId}/BillingProductAssociations/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ConfigurationItemBillingProductAssociationModel</returns>
	[Get("/V1.0/ConfigurationItems/{parentId}/BillingProductAssociations/{id}")]
	Task<ConfigurationItemBillingProductAssociationModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/ConfigurationItems/{parentId}/BillingProductAssociations/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ConfigurationItemBillingProductAssociationModel</returns>
	[Put("/V1.0/ConfigurationItems/{parentId}/BillingProductAssociations")]
	Task<ConfigurationItemBillingProductAssociationModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] ConfigurationItemBillingProductAssociationModel entity, CancellationToken cancellationToken);
}
