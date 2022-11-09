namespace AutoTask.Psa.Api.Data;

/// <summary>
/// QueryCountResultModel
/// </summary>
[DataContract]
public class QueryCountResultModel
{
	/// <summary>
	/// Gets or Sets QueryCount
	/// </summary>
	[DataMember(Name = "QueryCount")]
	public int? QueryCount { get; set; }
}
