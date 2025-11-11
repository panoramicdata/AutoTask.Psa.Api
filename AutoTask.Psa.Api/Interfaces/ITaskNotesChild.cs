namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ITaskNotesChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TaskNoteModel</returns>
	[Post("/V1.0/Tasks/{parentId}/Notes")]
	Task<TaskNoteModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] TaskNoteModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TaskNoteModel</returns>
	[Patch("/V1.0/Tasks/{parentId}/Notes")]
	Task<TaskNoteModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] TaskNoteModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TaskNoteModel</returns>
	[Get("/V1.0/Tasks/{parentId}/Notes")]
	Task<TaskNoteModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Tasks/{parentId}/Notes/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Tasks/{parentId}/Notes/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TaskNoteModel</returns>
	[Get("/V1.0/Tasks/{parentId}/Notes/{id}")]
	Task<TaskNoteModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Tasks/{parentId}/Notes/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of TaskNoteModel</returns>
	[Put("/V1.0/Tasks/{parentId}/Notes")]
	Task<TaskNoteModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] TaskNoteModel entity, CancellationToken cancellationToken);
}
