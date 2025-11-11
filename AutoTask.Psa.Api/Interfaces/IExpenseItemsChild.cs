namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IExpenseItemsChild
{
	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ExpenseItemModel</returns>
	[Post("/V1.0/Expenses/{parentId}/Items")]
	Task<ExpenseItemModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] ExpenseItemModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ExpenseItemModel</returns>
	[Patch("/V1.0/Expenses/{parentId}/Items")]
	Task<ExpenseItemModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] ExpenseItemModel entity, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ExpenseItemModel</returns>
	[Get("/V1.0/Expenses/{parentId}/Items")]
	Task<ExpenseItemModel> QueryAsync([AliasAs("parentId")] long? parentId);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of EntityInformationResultModel</returns>
	[Get("/V1.0/Expenses/{parentId}/Items/entityInformation")]
	Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of FieldInformationResultModel</returns>
	[Get("/V1.0/Expenses/{parentId}/Items/entityInformation/fields")]
	Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ExpenseItemModel</returns>
	[Get("/V1.0/Expenses/{parentId}/Items/{id}")]
	Task<ExpenseItemModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
	[Get("/V1.0/Expenses/{parentId}/Items/entityInformation/userDefinedFields")]
	Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId, CancellationToken cancellationToken);

	/// <summary>
	///
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ExpenseItemModel</returns>
	[Put("/V1.0/Expenses/{parentId}/Items")]
	Task<ExpenseItemModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] ExpenseItemModel entity, CancellationToken cancellationToken);
}
