namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ParameterExpression
/// </summary>
[DataContract]
public partial class ParameterExpression
{
	/// <summary>
	/// Gets or Sets NodeType
	/// </summary>
	[DataMember(Name = "NodeType")]
	public NodeTypeEnum? NodeType { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="ParameterExpression" /> class.
	/// </summary>
	[JsonConstructor]
	public ParameterExpression()
	{
	}

	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[DataMember(Name = "Type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets IsByRef
	/// </summary>
	[DataMember(Name = "IsByRef")]
	public bool? IsByRef { get; set; }

	/// <summary>
	/// Gets or Sets CanReduce
	/// </summary>
	[DataMember(Name = "CanReduce")]
	public bool? CanReduce { get; private set; }
}
