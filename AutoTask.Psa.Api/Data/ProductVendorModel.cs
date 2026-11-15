namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ProductVendorModel
/// </summary>
[DataContract]
public class ProductVendorModel : ParentedEntityModelBase
{
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
}
