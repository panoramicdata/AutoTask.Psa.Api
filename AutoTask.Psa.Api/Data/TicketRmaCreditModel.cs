namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketRmaCreditModel
/// </summary>
[DataContract]
public class TicketRmaCreditModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets CreditAmount
	/// </summary>
	[DataMember(Name = "CreditAmount")]
	public double? CreditAmount { get; set; }

	/// <summary>
	/// Gets or Sets CreditDetails
	/// </summary>
	[DataMember(Name = "CreditDetails")]
	public string CreditDetails { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets InternalCurrencyCreditAmount
	/// </summary>
	[DataMember(Name = "InternalCurrencyCreditAmount")]
	public double? InternalCurrencyCreditAmount { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }
}
