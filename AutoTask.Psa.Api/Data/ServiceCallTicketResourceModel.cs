namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ServiceCallTicketResourceModel
/// </summary>
[DataContract]
public class ServiceCallTicketResourceModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public int? ResourceID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceCallTicketID
	/// </summary>
	[DataMember(Name = "ServiceCallTicketID")]
	public int? ServiceCallTicketID { get; set; }
}
