namespace AutoTask.Psa.Api.Data;

/// <summary>
/// PriceListRoleModel
/// </summary>
[DataContract]
public class PriceListRoleModel : EntityModelBase
{
	/// <summary>
	/// Gets or Sets CurrencyID
	/// </summary>
	[DataMember(Name = "CurrencyID")]
	public int? CurrencyID { get; set; }

	/// <summary>
	/// Gets or Sets HourlyRate
	/// </summary>
	[DataMember(Name = "HourlyRate")]
	public double? HourlyRate { get; set; }

	/// <summary>
	/// Gets or Sets RoleID
	/// </summary>
	[DataMember(Name = "RoleID")]
	public int? RoleID { get; set; }

	/// <summary>
	/// Gets or Sets UsesInternalCurrencyPrice
	/// </summary>
	[DataMember(Name = "UsesInternalCurrencyPrice")]
	public bool? UsesInternalCurrencyPrice { get; set; }
}
