namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ServiceCallTaskModel
/// </summary>
[DataContract]
public class ServiceCallTaskModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ServiceCallID
	/// </summary>
	[DataMember(Name = "ServiceCallID")]
	public int? ServiceCallID { get; set; }

	/// <summary>
	/// Gets or Sets TaskID
	/// </summary>
	[DataMember(Name = "TaskID")]
	public int? TaskID { get; set; }
}
