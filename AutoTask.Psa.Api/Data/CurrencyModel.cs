namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CurrencyModel
/// </summary>
[DataContract]
public class CurrencyModel : DescribedNamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets CurrencyNegativeFormat
	/// </summary>
	[DataMember(Name = "CurrencyNegativeFormat")]
	public string CurrencyNegativeFormat { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CurrencyPositiveFormat
	/// </summary>
	[DataMember(Name = "CurrencyPositiveFormat")]
	public string CurrencyPositiveFormat { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DisplaySymbol
	/// </summary>
	[DataMember(Name = "DisplaySymbol")]
	public int? DisplaySymbol { get; set; }

	/// <summary>
	/// Gets or Sets ExchangeRate
	/// </summary>
	[DataMember(Name = "ExchangeRate")]
	public double? ExchangeRate { get; set; }

	/// <summary>
	/// Gets or Sets IsInternalCurrency
	/// </summary>
	[DataMember(Name = "IsInternalCurrency")]
	public bool? IsInternalCurrency { get; set; }

	/// <summary>
	/// Gets or Sets LastModifiedDateTime
	/// </summary>
	[DataMember(Name = "LastModifiedDateTime")]
	public DateTime? LastModifiedDateTime { get; set; }

	/// <summary>
	/// Gets or Sets UpdateResourceId
	/// </summary>
	[DataMember(Name = "UpdateResourceId")]
	public int? UpdateResourceId { get; set; }
}
