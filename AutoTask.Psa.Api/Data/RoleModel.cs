namespace AutoTask.Psa.Api.Data;

/// <summary>
/// RoleModel
/// </summary>
[DataContract]
public class RoleModel
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
	/// Gets or Sets HourlyFactor
	/// </summary>
	[DataMember(Name = "HourlyFactor")]
	public double? HourlyFactor { get; set; }

	/// <summary>
	/// Gets or Sets HourlyRate
	/// </summary>
	[DataMember(Name = "HourlyRate")]
	public double? HourlyRate { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets IsExcludedFromNewContracts
	/// </summary>
	[DataMember(Name = "IsExcludedFromNewContracts")]
	public bool? IsExcludedFromNewContracts { get; set; }

	/// <summary>
	/// Gets or Sets IsSystemRole
	/// </summary>
	[DataMember(Name = "IsSystemRole")]
	public bool? IsSystemRole { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets QuoteItemDefaultTaxCategoryId
	/// </summary>
	[DataMember(Name = "QuoteItemDefaultTaxCategoryId")]
	public int? QuoteItemDefaultTaxCategoryId { get; set; }

	/// <summary>
	/// Gets or Sets RoleType
	/// </summary>
	[DataMember(Name = "RoleType")]
	public int? RoleType { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
