namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketChargeModel
/// </summary>
public class TicketChargeModel : ContractLinkedChargeModelBase
{
	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public long? TicketID { get; set; }
}
