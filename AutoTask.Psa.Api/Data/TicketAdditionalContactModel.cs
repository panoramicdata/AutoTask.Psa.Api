namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketAdditionalContactModel
/// </summary>
[DataContract]
public class TicketAdditionalContactModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ContactID
	/// </summary>
	[DataMember(Name = "ContactID")]
	public int? ContactID { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }
}
