namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ResourceSkillModel
/// </summary>
[DataContract]
public class ResourceSkillModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ResourceID
	/// </summary>
	[DataMember(Name = "ResourceID")]
	public long? ResourceID { get; set; }

	/// <summary>
	/// Gets or Sets SkillDescription
	/// </summary>
	[DataMember(Name = "SkillDescription")]
	public string SkillDescription { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SkillID
	/// </summary>
	[DataMember(Name = "SkillID")]
	public long? SkillID { get; set; }

	/// <summary>
	/// Gets or Sets SkillLevel
	/// </summary>
	[DataMember(Name = "SkillLevel")]
	public long? SkillLevel { get; set; }
}
