using Refit;
using System.Threading.Tasks;
using AutoTask.Psa.Api.Data;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IPriceListProductTiersApi
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of PriceListProductTierModel</returns>
		[Patch("/V1.0/PriceListProductTiers")]
		Task<PriceListProductTierModel> PatchAsync([Body] PriceListProductTierModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <returns>Task of PriceListProductTierModel</returns>
		[Post("/V1.0/PriceListProductTiers/query")]
		Task<PriceListProductTierModel> QueryAsync([Body] QueryModel queryModel);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Post("/V1.0/PriceListProductTiers/query/count")]
		Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/PriceListProductTiers/entityInformation")]
		Task<EntityInformationResultModel> GetEntityInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/PriceListProductTiers/entityInformation/fields")]
		Task<FieldInformationResultModel> GetFieldInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <returns>Task of PriceListProductTierModel</returns>
		[Get("/V1.0/PriceListProductTiers/{id}")]
		Task<PriceListProductTierModel> GetAsync([AliasAs("id")] long id);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/PriceListProductTiers/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of PriceListProductTierModel</returns>
		[Put("/V1.0/PriceListProductTiers")]
		Task<PriceListProductTierModel> UpdateAsync([Body] PriceListProductTierModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Task of PriceListProductTierModel</returns>
		[Get("/V1.0/PriceListProductTiers/query")]
		Task<PriceListProductTierModel> StringQueryAsync([AliasAs("search")] string search);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Get("/V1.0/PriceListProductTiers/query/count")]
		Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
	}
}
