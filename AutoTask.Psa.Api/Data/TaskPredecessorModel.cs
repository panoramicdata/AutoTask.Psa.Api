namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TaskPredecessorModel
/// </summary>
[DataContract]
public partial class TaskPredecessorModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
