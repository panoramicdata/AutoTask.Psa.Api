namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractTicketPurchaseModel
/// </summary>
[DataContract]
public class ContractTicketPurchaseModel : ContractPaymentModelBase
{
	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public long? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets PerTicketRate
	/// </summary>
	[DataMember(Name = "PerTicketRate")]
	public double? PerTicketRate { get; set; }

	/// <summary>
	/// Gets or Sets TicketsPurchased
	/// </summary>
	[DataMember(Name = "TicketsPurchased")]
	public double? TicketsPurchased { get; set; }

	/// <summary>
	/// Gets or Sets TicketsUsed
	/// </summary>
	[DataMember(Name = "TicketsUsed")]
	public double? TicketsUsed { get; set; }
}
