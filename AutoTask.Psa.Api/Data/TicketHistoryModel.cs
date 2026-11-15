namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketHistoryModel
/// </summary>
[DataContract]
public class TicketHistoryModel : EntityModelBase
{
	/// <summary>
	/// Gets or Sets Action
	/// </summary>
	[DataMember(Name = "Action")]
	public string Action { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Date
	/// </summary>
	[DataMember(Name = "Date")]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Gets or Sets Detail
	/// </summary>
	[DataMember(Name = "Detail")]
	public string Detail { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public int? ResourceID { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public long? SoapParentPropertyId { get; private set; }
}
