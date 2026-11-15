namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketAdditionalConfigurationItemModel
/// </summary>
[DataContract]
public class TicketAdditionalConfigurationItemModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ConfigurationItemID
	/// </summary>
	[DataMember(Name = "ConfigurationItemID")]
	public int? ConfigurationItemID { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }
}
