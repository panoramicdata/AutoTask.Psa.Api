namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CompanyLocationModel
/// </summary>
[DataContract]
public class CompanyLocationModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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
	/// Gets or Sets AlternatePhone1
	/// </summary>
	[DataMember(Name = "AlternatePhone1")]
	public string AlternatePhone1 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets AlternatePhone2
	/// </summary>
	[DataMember(Name = "AlternatePhone2")]
	public string AlternatePhone2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets City
	/// </summary>
	[DataMember(Name = "City")]
	public string City { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets CountryID
	/// </summary>
	[DataMember(Name = "CountryID")]
	public int? CountryID { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Fax
	/// </summary>
	[DataMember(Name = "Fax")]
	public string Fax { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets IsPrimary
	/// </summary>
	[DataMember(Name = "IsPrimary")]
	public bool? IsPrimary { get; set; }

	/// <summary>
	/// Gets or Sets IsTaxExempt
	/// </summary>
	[DataMember(Name = "IsTaxExempt")]
	public bool? IsTaxExempt { get; set; }

	/// <summary>
	/// Gets or Sets OverrideAccountTaxSettings
	/// </summary>
	[DataMember(Name = "OverrideAccountTaxSettings")]
	public bool? OverrideAccountTaxSettings { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Phone
	/// </summary>
	[DataMember(Name = "Phone")]
	public string Phone { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets PostalCode
	/// </summary>
	[DataMember(Name = "PostalCode")]
	public string PostalCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RoundtripDistance
	/// </summary>
	[DataMember(Name = "RoundtripDistance")]
	public double? RoundtripDistance { get; set; }

	/// <summary>
	/// Gets or Sets State
	/// </summary>
	[DataMember(Name = "State")]
	public string State { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TaxRegionID
	/// </summary>
	[DataMember(Name = "TaxRegionID")]
	public int? TaxRegionID { get; set; }

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
