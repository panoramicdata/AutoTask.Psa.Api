namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ProductVendorModel
/// </summary>
[DataContract]
public class ProductVendorModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets IsDefault
	/// </summary>
	[DataMember(Name = "IsDefault")]
	public bool? IsDefault { get; set; }

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets VendorCost
	/// </summary>
	[DataMember(Name = "VendorCost")]
	public double? VendorCost { get; set; }

	/// <summary>
	/// Gets or Sets VendorID
	/// </summary>
	[DataMember(Name = "VendorID")]
	public int? VendorID { get; set; }

	/// <summary>
	/// Gets or Sets VendorPartNumber
	/// </summary>
	[DataMember(Name = "VendorPartNumber")]
	public string VendorPartNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
