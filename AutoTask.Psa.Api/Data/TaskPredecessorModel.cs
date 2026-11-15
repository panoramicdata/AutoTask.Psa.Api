namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TaskPredecessorModel
/// </summary>
[DataContract]
public class TaskPredecessorModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets LagDays
	/// </summary>
	[DataMember(Name = "LagDays")]
	public int? LagDays { get; set; }

	/// <summary>
	/// Gets or Sets PredecessorTaskID
	/// </summary>
	[DataMember(Name = "PredecessorTaskID")]
	public int? PredecessorTaskID { get; set; }

	/// <summary>
	/// Gets or Sets SuccessorTaskID
	/// </summary>
	[DataMember(Name = "SuccessorTaskID")]
	public int? SuccessorTaskID { get; set; }
}
