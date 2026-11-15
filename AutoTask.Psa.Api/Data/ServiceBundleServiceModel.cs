namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ServiceBundleServiceModel
/// </summary>
[DataContract]
public class ServiceBundleServiceModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ServiceBundleID
	/// </summary>
	[DataMember(Name = "ServiceBundleID")]
	public long? ServiceBundleID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceID
	/// </summary>
	[DataMember(Name = "ServiceID")]
	public long? ServiceID { get; set; }
}
