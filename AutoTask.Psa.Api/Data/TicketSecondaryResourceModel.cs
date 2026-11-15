namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketSecondaryResourceModel
/// </summary>
[DataContract]
public class TicketSecondaryResourceModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public long? ResourceID { get; set; }

	/// <summary>
	/// Gets or Sets RoleID
	/// </summary>
	[DataMember(Name = "RoleID")]
	public long? RoleID { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public long? TicketID { get; set; }
}
