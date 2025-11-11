namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TaxModel
/// </summary>
[DataContract]
public class TaxModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets IsCompounded
	/// </summary>
	[DataMember(Name = "IsCompounded")]
	public bool? IsCompounded { get; set; }

	/// <summary>
	/// Gets or Sets TaxCategoryID
	/// </summary>
	[DataMember(Name = "TaxCategoryID")]
	public int? TaxCategoryID { get; set; }

	/// <summary>
	/// Gets or Sets TaxName
	/// </summary>
	[DataMember(Name = "TaxName")]
	public string TaxName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TaxRate
	/// </summary>
	[DataMember(Name = "TaxRate")]
	public double? TaxRate { get; set; }

	/// <summary>
	/// Gets or Sets TaxRegionID
	/// </summary>
	[DataMember(Name = "TaxRegionID")]
	public int? TaxRegionID { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
