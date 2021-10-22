using AutoTask.Psa.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace AutoTask.Psa.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IConfigurationItemCategoriesApi
	{
		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ConfigurationItemCategoryModel</returns>
		[Post("/V1.0/ConfigurationItemCategories")]
		Task<ConfigurationItemCategoryModel> CreateAsync([Body] ConfigurationItemCategoryModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ConfigurationItemCategoryModel</returns>
		[Patch("/V1.0/ConfigurationItemCategories")]
		Task<ConfigurationItemCategoryModel> PatchAsync([Body] ConfigurationItemCategoryModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <returns>Task of ConfigurationItemCategoryModel</returns>
		[Post("/V1.0/ConfigurationItemCategories/query")]
		Task<ConfigurationItemCategoryModel> QueryAsync([Body] QueryModel queryModel);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="queryModel"></param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Post("/V1.0/ConfigurationItemCategories/query/count")]
		Task<QueryCountResultModel> CountAsync([Body] QueryModel queryModel);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of EntityInformationResultModel</returns>
		[Get("/V1.0/ConfigurationItemCategories/entityInformation")]
		Task<EntityInformationResultModel> GetEntityInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of FieldInformationResultModel</returns>
		[Get("/V1.0/ConfigurationItemCategories/entityInformation/fields")]
		Task<FieldInformationResultModel> GetFieldInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <returns>Task of ConfigurationItemCategoryModel</returns>
		[Get("/V1.0/ConfigurationItemCategories/{id}")]
		Task<ConfigurationItemCategoryModel> GetAsync([AliasAs("id")] long id);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of UserDefinedFieldInformationResultModel</returns>
		[Get("/V1.0/ConfigurationItemCategories/entityInformation/userDefinedFields")]
		Task<UserDefinedFieldInformationResultModel> GetUdfInfoAsync();

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ConfigurationItemCategoryModel</returns>
		[Put("/V1.0/ConfigurationItemCategories")]
		Task<ConfigurationItemCategoryModel> UpdateAsync([Body] ConfigurationItemCategoryModel entity);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Task of ConfigurationItemCategoryModel</returns>
		[Get("/V1.0/ConfigurationItemCategories/query")]
		Task<ConfigurationItemCategoryModel> StringQueryAsync([AliasAs("search")] string search);

		/// <summary>
		///
		/// </summary>
		/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Task of QueryCountResultModel</returns>
		[Get("/V1.0/ConfigurationItemCategories/query/count")]
		Task<QueryCountResultModel> StringCountAsync([AliasAs("search")] string search);
	}
}
