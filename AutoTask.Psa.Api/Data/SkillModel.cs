namespace AutoTask.Psa.Api.Data;

/// <summary>
/// SkillModel
/// </summary>
[DataContract]
public class SkillModel : DescribedNamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets CategoryID
	/// </summary>
	[DataMember(Name = "CategoryID")]
	public long? CategoryID { get; set; }
}
