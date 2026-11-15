namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CountryModel
/// </summary>
[DataContract]
public class CountryModel : NamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets AddressFormatID
	/// </summary>
	[DataMember(Name = "AddressFormatID")]
	public long? AddressFormatID { get; set; }

	/// <summary>
	/// Gets or Sets CountryCode
	/// </summary>
	[DataMember(Name = "CountryCode")]
	public string CountryCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DisplayName
	/// </summary>
	[DataMember(Name = "DisplayName")]
	public string DisplayName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets InvoiceTemplateID
	/// </summary>
	[DataMember(Name = "InvoiceTemplateID")]
	public int? InvoiceTemplateID { get; set; }

	/// <summary>
	/// Gets or Sets IsDefaultCountry
	/// </summary>
	[DataMember(Name = "IsDefaultCountry")]
	public bool? IsDefaultCountry { get; set; }

	/// <summary>
	/// Gets or Sets QuoteTemplateID
	/// </summary>
	[DataMember(Name = "QuoteTemplateID")]
	public int? QuoteTemplateID { get; set; }
}
