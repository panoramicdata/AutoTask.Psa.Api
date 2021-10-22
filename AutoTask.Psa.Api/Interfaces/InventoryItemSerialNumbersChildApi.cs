using AutoTask.Psa.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IInventoryItemSerialNumbersChildApi
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of InventoryItemSerialNumberModel</returns>
		[Post("/V1.0/InventoryItems/{parentId}/SerialNumbers")]
		Task<InventoryItemSerialNumberModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] InventoryItemSerialNumberModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of InventoryItemSerialNumberModel</returns>
		[Patch("/V1.0/InventoryItems/{parentId}/SerialNumbers")]
		Task<InventoryItemSerialNumberModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] InventoryItemSerialNumberModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of InventoryItemSerialNumberModel</returns>
		[Get("/V1.0/InventoryItems/{parentId}/SerialNumbers")]
		Task<InventoryItemSerialNumberModel> QueryAsync([AliasAs("parentId")] long? parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/InventoryItems/{parentId}/SerialNumbers/entityInformation")]
		Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/InventoryItems/{parentId}/SerialNumbers/entityInformation/fields")]
		Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="id"></param>
		/// <returns>Task of InventoryItemSerialNumberModel</returns>
		[Get("/V1.0/InventoryItems/{parentId}/SerialNumbers/{id}")]
		Task<InventoryItemSerialNumberModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/InventoryItems/{parentId}/SerialNumbers/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of InventoryItemSerialNumberModel</returns>
		[Put("/V1.0/InventoryItems/{parentId}/SerialNumbers")]
		Task<InventoryItemSerialNumberModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] InventoryItemSerialNumberModel entity);
	}
}
