using Refit;
using System.Threading.Tasks;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IOrganizationalLevelAssociationApi
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of OrganizationalLevelAssociationModel</returns>
		[Post("/V1.0/OrganizationalLevelAssociations")]
		Task<OrganizationalLevelAssociationModel> CreateAsync([Body] OrganizationalLevelAssociationModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of OrganizationalLevelAssociationModel</returns>
		[Patch("/V1.0/OrganizationalLevelAssociations")]
		Task<OrganizationalLevelAssociationModel> PatchAsync([Body] OrganizationalLevelAssociationModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <returns>Task of OrganizationalLevelAssociationModel</returns>
		[Post("/V1.0/OrganizationalLevelAssociations/query")]
		Task<OrganizationalLevelAssociationModel> QueryAsync([Body] QueryModel queryModel);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Post("/V1.0/OrganizationalLevelAssociations/query/count")]
		Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/OrganizationalLevelAssociations/entityInformation")]
		Task<EntityInformationResultModel> GetEntityInfoAsync(string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/OrganizationalLevelAssociations/entityInformation/fields")]
		Task<FieldInformationResultModel> GetFieldInfoAsync(string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <returns>Task of OrganizationalLevelAssociationModel</returns>
		[Get("/V1.0/OrganizationalLevelAssociations/{id}")]
		Task<OrganizationalLevelAssociationModel> GetAsync([AliasAs("id")] long id);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/OrganizationalLevelAssociations/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync(string ApiIntegrationCode, string UserName, string Secret, string ImpersonationResourceId = null);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of OrganizationalLevelAssociationModel</returns>
		[Put("/V1.0/OrganizationalLevelAssociations")]
		Task<OrganizationalLevelAssociationModel> UpdateAsync([Body] OrganizationalLevelAssociationModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Task of OrganizationalLevelAssociationModel</returns>
		[Get("/V1.0/OrganizationalLevelAssociations/query")]
		Task<OrganizationalLevelAssociationModel> QueryAsync([AliasAs("search")] string search);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Get("/V1.0/OrganizationalLevelAssociations/query/count")]
		Task<QueryCountResultModel> CountAsync([AliasAs("search")] string search);
	}
}
