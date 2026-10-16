namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TaxCategoryModel
/// </summary>
[DataContract]
public class TaxCategoryModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];

	/// <summary>
	/// Creates a new <see cref="TaxCategoryModel"/> with the supplied scalar values.
	/// </summary>
	public static TaxCategoryModel Create(long? id, string description, bool? isActive, string name, IEnumerable<UserDefinedField>? userDefinedFields = null)
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
