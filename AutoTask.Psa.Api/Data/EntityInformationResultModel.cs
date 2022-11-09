namespace AutoTask.Psa.Api.Data;

/// <summary>
/// EntityInformationResultModel
/// </summary>
[DataContract]
public class EntityInformationResultModel
{
	/// <summary>
	/// Gets or Sets Info
	/// </summary>
	[DataMember(Name = "Info")]
	public EntityInformationModel Info { get; set; } = new();
}
