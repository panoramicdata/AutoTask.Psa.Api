namespace AutoTask.Psa.Api.Data;

/// <summary>
/// InternalLocationModel
/// </summary>
[DataContract]
public class InternalLocationModel : AddressModelBase
{
	/// <summary>
	/// Gets or Sets AdditionalAddressInfo
	/// </summary>
	[DataMember(Name = "AdditionalAddressInfo")]
	public string AdditionalAddressInfo { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Country
	/// </summary>
	[DataMember(Name = "Country")]
	public string Country { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets HolidaySetId
	/// </summary>
	[DataMember(Name = "HolidaySetId")]
	public long? HolidaySetId { get; set; }

	/// <summary>
	/// Gets or Sets IsDefault
	/// </summary>
	[DataMember(Name = "IsDefault")]
	public bool? IsDefault { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TimeZone
	/// </summary>
	[DataMember(Name = "TimeZone")]
	public string TimeZone { get; set; } = string.Empty;
}
