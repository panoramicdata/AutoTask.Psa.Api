namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ResourceRoleQueueModel
/// </summary>
[DataContract]
public class ResourceRoleQueueModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets QueueID
	/// </summary>
	[DataMember(Name = "QueueID")]
	public int? QueueID { get; set; }

	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public int? ResourceID { get; set; }
}
