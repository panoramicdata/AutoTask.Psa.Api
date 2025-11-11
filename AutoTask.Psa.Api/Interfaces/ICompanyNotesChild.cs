namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICompanyNotesChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanyNoteModel</returns>
	[Post("/V1.0/Companies/{parentId}/Notes")]
	Task<CompanyNoteModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] CompanyNoteModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanyNoteModel</returns>
	[Patch("/V1.0/Companies/{parentId}/Notes")]
	Task<CompanyNoteModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] CompanyNoteModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanyNoteModel</returns>
	[Get("/V1.0/Companies/{parentId}/Notes")]
	Task<CompanyNoteModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Companies/{parentId}/Notes/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Companies/{parentId}/Notes/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanyNoteModel</returns>
	[Get("/V1.0/Companies/{parentId}/Notes/{id}")]
	Task<CompanyNoteModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Companies/{parentId}/Notes/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CompanyNoteModel</returns>
	[Put("/V1.0/Companies/{parentId}/Notes")]
	Task<CompanyNoteModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] CompanyNoteModel entity, CancellationToken cancellationToken);
}
