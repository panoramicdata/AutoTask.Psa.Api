using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ExpressionFuncAccountAlertInt64
	/// </summary>
	[DataContract]
	public partial class ExpressionFunc
	{
		/// <summary>
		/// Gets or Sets NodeType
		/// </summary>
		[DataMember(Name = "NodeType")]
		public NodeTypeEnum? NodeType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ExpressionFunc" /> class.
		/// </summary>
		[JsonConstructor]
		public ExpressionFunc()
		{
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "Type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Parameters
		/// </summary>
		[DataMember(Name = "Parameters")]
		public List<ParameterExpression> Parameters { get; set; } = new();

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Body
		/// </summary>
		[DataMember(Name = "Body")]
		public Expression Body { get; set; } = new();

		/// <summary>
		/// Gets or Sets ReturnType
		/// </summary>
		[DataMember(Name = "ReturnType")]
		public string ReturnType { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets TailCall
		/// </summary>
		[DataMember(Name = "TailCall")]
		public bool? TailCall { get; set; }

		/// <summary>
		/// Gets or Sets CanReduce
		/// </summary>
		[DataMember(Name = "CanReduce")]
		public bool? CanReduce { get; set; }
	}
}
