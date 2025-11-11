namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationalLevelAssociation
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OrganizationalLevelAssociationModel</returns>
	[Post("/V1.0/OrganizationalLevelAssociations")]
	Task<OrganizationalLevelAssociationModel> CreateAsync([Body] OrganizationalLevelAssociationModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OrganizationalLevelAssociationModel</returns>
	[Patch("/V1.0/OrganizationalLevelAssociations")]
	Task<OrganizationalLevelAssociationModel> PatchAsync([Body] OrganizationalLevelAssociationModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OrganizationalLevelAssociationModel</returns>
	[Post("/V1.0/OrganizationalLevelAssociations/query")]
	Task<QueryActionResult<OrganizationalLevelAssociationModel>> QueryAsync([Body] QueryModel queryModel, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Post("/V1.0/OrganizationalLevelAssociations/query/count")]
	Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/OrganizationalLevelAssociations/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/OrganizationalLevelAssociations/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OrganizationalLevelAssociationModel</returns>
	[Get("/V1.0/OrganizationalLevelAssociations/{id}")]
	Task<OrganizationalLevelAssociationModel> GetAsync([AliasAs("id")] long id, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/OrganizationalLevelAssociations/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OrganizationalLevelAssociationModel</returns>
	[Put("/V1.0/OrganizationalLevelAssociations")]
	Task<OrganizationalLevelAssociationModel> UpdateAsync([Body] OrganizationalLevelAssociationModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of OrganizationalLevelAssociationModel</returns>
	[Get("/V1.0/OrganizationalLevelAssociations/query")]
	Task<QueryActionResult<OrganizationalLevelAssociationModel>> QueryAsync([AliasAs("search")] string search, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QueryCountResultModel</returns>
	[Get("/V1.0/OrganizationalLevelAssociations/query/count")]
	Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search, CancellationToken cancellationToken);
}
