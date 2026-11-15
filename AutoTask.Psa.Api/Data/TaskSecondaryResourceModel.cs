namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TaskSecondaryResourceModel
/// </summary>
[DataContract]
public class TaskSecondaryResourceModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public int? ResourceID { get; set; }

	/// <summary>
	/// Gets or Sets RoleID
	/// </summary>
	[DataMember(Name = "RoleID")]
	public int? RoleID { get; set; }

	/// <summary>
	/// Gets or Sets TaskID
	/// </summary>
	[DataMember(Name = "TaskID")]
	public int? TaskID { get; set; }
}
