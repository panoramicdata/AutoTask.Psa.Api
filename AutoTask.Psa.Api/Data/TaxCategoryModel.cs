namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TaxCategoryModel
/// </summary>
[DataContract]
public class TaxCategoryModel : DescribedNamedEntityModelBase
{
	/// <summary>
	/// Creates a new <see cref="TaxCategoryModel"/> with no user defined fields.
	/// </summary>
	public static TaxCategoryModel Create(long? id, string description, bool? isActive, string name)
		=> Create(id, description, isActive, name, null);

	/// <summary>
	/// Creates a new <see cref="TaxCategoryModel"/> with the supplied scalar values.
	/// </summary>
	public static TaxCategoryModel Create(long? id, string description, bool? isActive, string name, IEnumerable<UserDefinedField>? userDefinedFields)
	{
		return new TaxCategoryModel
		{
			Id = id,
			Description = description,
			IsActive = isActive,
			Name = name,
			UserDefinedFields = userDefinedFields?.ToList() ?? []
		};
	}
}
