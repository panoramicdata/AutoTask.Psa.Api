using AutoTask.Psa.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IContractTicketPurchasesChild
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of ContractTicketPurchaseModel</returns>
		[Post("/V1.0/Contracts/{parentId}/TicketPurchases")]
		Task<ContractTicketPurchaseModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] ContractTicketPurchaseModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of ContractTicketPurchaseModel</returns>
		[Patch("/V1.0/Contracts/{parentId}/TicketPurchases")]
		Task<ContractTicketPurchaseModel> PatchAsync([AliasAs("parentId")] long? parentId, [Body] ContractTicketPurchaseModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of ContractTicketPurchaseModel</returns>
		[Get("/V1.0/Contracts/{parentId}/TicketPurchases")]
		Task<ContractTicketPurchaseModel> QueryAsync([AliasAs("parentId")] long? parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/Contracts/{parentId}/TicketPurchases/entityInformation")]
		Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/Contracts/{parentId}/TicketPurchases/entityInformation/fields")]
		Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="id"></param>
		/// <returns>Task of ContractTicketPurchaseModel</returns>
		[Get("/V1.0/Contracts/{parentId}/TicketPurchases/{id}")]
		Task<ContractTicketPurchaseModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/Contracts/{parentId}/TicketPurchases/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of ContractTicketPurchaseModel</returns>
		[Put("/V1.0/Contracts/{parentId}/TicketPurchases")]
		Task<ContractTicketPurchaseModel> UpdateAsync([AliasAs("parentId")] long? parentId, [Body] ContractTicketPurchaseModel entity);
	}
}
