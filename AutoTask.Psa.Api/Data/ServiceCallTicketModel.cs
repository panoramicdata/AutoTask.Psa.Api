namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ServiceCallTicketModel
/// </summary>
[DataContract]
public class ServiceCallTicketModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ServiceCallID
	/// </summary>
	[DataMember(Name = "ServiceCallID")]
	public int? ServiceCallID { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }
}
