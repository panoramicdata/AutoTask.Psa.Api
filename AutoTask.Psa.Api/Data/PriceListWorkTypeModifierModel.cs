namespace AutoTask.Psa.Api.Data;

/// <summary>
/// PriceListWorkTypeModifierModel
/// </summary>
[DataContract]
public class PriceListWorkTypeModifierModel : EntityModelBase
{
	/// <summary>
	/// Gets or Sets CurrencyID
	/// </summary>
	[DataMember(Name = "CurrencyID")]
	public int? CurrencyID { get; set; }

	/// <summary>
	/// Gets or Sets ModifierType
	/// </summary>
	[DataMember(Name = "ModifierType")]
	public int? ModifierType { get; set; }

	/// <summary>
	/// Gets or Sets ModifierValue
	/// </summary>
	[DataMember(Name = "ModifierValue")]
	public double? ModifierValue { get; set; }

	/// <summary>
	/// Gets or Sets UsesInternalCurrencyPrice
	/// </summary>
	[DataMember(Name = "UsesInternalCurrencyPrice")]
	public bool? UsesInternalCurrencyPrice { get; set; }

	/// <summary>
	/// Gets or Sets WorkTypeModifierID
	/// </summary>
	[DataMember(Name = "WorkTypeModifierID")]
	public int? WorkTypeModifierID { get; set; }
}
