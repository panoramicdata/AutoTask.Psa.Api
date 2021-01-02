using Refit;
using System.Threading.Tasks;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ICompanyWebhookUdfFieldsApi
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <returns>Task of CompanyWebhookUdfFieldModel</returns>
		[Post("/V1.0/CompanyWebhookUdfFields/query")]
		Task<CompanyWebhookUdfFieldModel> QueryAsync([Body] QueryModel queryModel);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Post("/V1.0/CompanyWebhookUdfFields/query/count")]
		Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/CompanyWebhookUdfFields/entityInformation")]
		Task<EntityInformationResultModel> GetEntityInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/CompanyWebhookUdfFields/entityInformation/fields")]
		Task<FieldInformationResultModel> GetFieldInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <returns>Task of CompanyWebhookUdfFieldModel</returns>
		[Get("/V1.0/CompanyWebhookUdfFields/{id}")]
		Task<CompanyWebhookUdfFieldModel> GetAsync([AliasAs("id")] long id);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/CompanyWebhookUdfFields/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Task of CompanyWebhookUdfFieldModel</returns>
		[Get("/V1.0/CompanyWebhookUdfFields/query")]
		Task<CompanyWebhookUdfFieldModel> StringQueryAsync([AliasAs("search")] string search);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Get("/V1.0/CompanyWebhookUdfFields/query/count")]
		Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
	}
}
