namespace AutoTask.Psa.Api.Data;

/// <summary>
/// QueryModel
/// </summary>
[DataContract]
public class QueryModel
{
	/// <summary>
	/// Gets or Sets MaxRecords
	/// </summary>
	[DataMember(Name = "MaxRecords")]
	public int? MaxRecords { get; set; }

	/// <summary>
	/// Gets or Sets IncludeFields
	/// </summary>
	[DataMember(Name = "IncludeFields")]
	public List<string>? IncludeFields { get; set; }

	/// <summary>
	/// Gets or Sets Filter
	/// </summary>
	[DataMember(Name = "Filter")]
	public List<Filter>? Filter { get; set; }

	/// <summary>
	/// Gets or Sets Xml
	/// </summary>
	[DataMember(Name = "Xml")]
	public string? Xml { get; set; }
}
