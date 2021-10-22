using AutoTask.Psa.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IServiceCallTicketResourcesChild
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of ServiceCallTicketResourceModel</returns>
		[Post("/V1.0/ServiceCallTickets/{parentId}/Resources")]
		Task<ServiceCallTicketResourceModel> CreateAsync([AliasAs("parentId")] long? parentId, [Body] ServiceCallTicketResourceModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="id"></param>
		/// <returns>Task of OperationResultModel</returns>
		[Delete("/V1.0/ServiceCallTickets/{parentId}/Resources/{id}")]
		Task<OperationResultModel> DeleteAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of ServiceCallTicketResourceModel</returns>
		[Get("/V1.0/ServiceCallTickets/{parentId}/Resources")]
		Task<ServiceCallTicketResourceModel> QueryAsync([AliasAs("parentId")] long? parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/ServiceCallTickets/{parentId}/Resources/entityInformation")]
		Task<EntityInformationResultModel> GetEntityInfoAsync([AliasAs("parentId")] string parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/ServiceCallTickets/{parentId}/Resources/entityInformation/fields")]
		Task<FieldInformationResultModel> GetFieldInfoAsync([AliasAs("parentId")] string parentId);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <param name="id"></param>
		/// <returns>Task of ServiceCallTicketResourceModel</returns>
		[Get("/V1.0/ServiceCallTickets/{parentId}/Resources/{id}")]
		Task<ServiceCallTicketResourceModel> GetAsync([AliasAs("parentId")] long? parentId, [AliasAs("id")] long? id);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="parentId"></param>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/ServiceCallTickets/{parentId}/Resources/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync([AliasAs("parentId")] string parentId);
	}
}
