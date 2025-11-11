namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IConfigurationItemNotesChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ConfigurationItemNoteModel</returns>
	[Post("/V1.0/ConfigurationItems/{parentId}/Notes")]
	Task<ConfigurationItemNoteModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] ConfigurationItemNoteModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ConfigurationItemNoteModel</returns>
	[Patch("/V1.0/ConfigurationItems/{parentId}/Notes")]
	Task<ConfigurationItemNoteModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] ConfigurationItemNoteModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ConfigurationItemNoteModel</returns>
	[Get("/V1.0/ConfigurationItems/{parentId}/Notes")]
	Task<ConfigurationItemNoteModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/ConfigurationItems/{parentId}/Notes/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/ConfigurationItems/{parentId}/Notes/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ConfigurationItemNoteModel</returns>
	[Get("/V1.0/ConfigurationItems/{parentId}/Notes/{id}")]
	Task<ConfigurationItemNoteModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/ConfigurationItems/{parentId}/Notes/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ConfigurationItemNoteModel</returns>
	[Put("/V1.0/ConfigurationItems/{parentId}/Notes")]
	Task<ConfigurationItemNoteModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] ConfigurationItemNoteModel entity, CancellationToken cancellationToken);
}
