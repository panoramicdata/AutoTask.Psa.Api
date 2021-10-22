using AutoTask.Psa.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IServiceBundles
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ServiceBundleModel</returns>
		[Post("/V1.0/ServiceBundles")]
		Task<ServiceBundleModel> CreateAsync([Body] ServiceBundleModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <returns>Task of OperationResultModel</returns>
		[Delete("/V1.0/ServiceBundles/{id}")]
		Task<OperationResultModel> DeleteAsync([AliasAs("id")] long id);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ServiceBundleModel</returns>
		[Patch("/V1.0/ServiceBundles")]
		Task<ServiceBundleModel> PatchAsync([Body] ServiceBundleModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <returns>Task of ServiceBundleModel</returns>
		[Post("/V1.0/ServiceBundles/query")]
		Task<ServiceBundleModel> QueryAsync([Body] QueryModel queryModel);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Post("/V1.0/ServiceBundles/query/count")]
		Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/ServiceBundles/entityInformation")]
		Task<EntityInformationResultModel> GetEntityInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/ServiceBundles/entityInformation/fields")]
		Task<FieldInformationResultModel> GetFieldInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <returns>Task of ServiceBundleModel</returns>
		[Get("/V1.0/ServiceBundles/{id}")]
		Task<ServiceBundleModel> GetAsync([AliasAs("id")] long id);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/ServiceBundles/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ServiceBundleModel</returns>
		[Put("/V1.0/ServiceBundles")]
		Task<ServiceBundleModel> UpdateAsync([Body] ServiceBundleModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Task of ServiceBundleModel</returns>
		[Get("/V1.0/ServiceBundles/query")]
		Task<QueryActionResult<ServiceBundleModel>> QueryAsync([AliasAs("search")] string search);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Get("/V1.0/ServiceBundles/query/count")]
		Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
	}
}
