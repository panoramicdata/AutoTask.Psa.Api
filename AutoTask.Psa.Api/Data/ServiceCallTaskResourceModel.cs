namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ServiceCallTaskResourceModel
/// </summary>
[DataContract]
public class ServiceCallTaskResourceModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public int? ResourceID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceCallTaskID
	/// </summary>
	[DataMember(Name = "ServiceCallTaskID")]
	public int? ServiceCallTaskID { get; set; }
}
