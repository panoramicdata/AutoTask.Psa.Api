namespace AutoTask.Psa.Api.Data;

/// <summary>
/// InternalLocationModel
/// </summary>
[DataContract]
public class InternalLocationModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AdditionalAddressInfo
	/// </summary>
	[DataMember(Name = "AdditionalAddressInfo")]
	public string AdditionalAddressInfo { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Address1
	/// </summary>
	[DataMember(Name = "Address1")]
	public string Address1 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Address2
	/// </summary>
	[DataMember(Name = "Address2")]
	public string Address2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets City
	/// </summary>
	[DataMember(Name = "City")]
	public string City { get; set; } = string.Empty;

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
	/// Gets or Sets PostalCode
	/// </summary>
	[DataMember(Name = "PostalCode")]
	public string PostalCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets State
	/// </summary>
	[DataMember(Name = "State")]
	public string State { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TimeZone
	/// </summary>
	[DataMember(Name = "TimeZone")]
	public string TimeZone { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
