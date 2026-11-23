namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractServiceUnitModel
/// </summary>
[DataContract]
public class ContractServiceUnitModel : ContractServiceUnitModelBase
{
	/// <summary>
	/// Gets or Sets ContractServiceID
	/// </summary>
	[DataMember(Name = "ContractServiceID")]
	public int? ContractServiceID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceID
	/// </summary>
	[DataMember(Name = "ServiceID")]
	public int? ServiceID { get; set; }

	/// <summary>
	/// Gets or Sets VendorCompanyID
	/// </summary>
	[DataMember(Name = "VendorCompanyID")]
	public int? VendorCompanyID { get; set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public long? SoapParentPropertyId { get; set; }
}
