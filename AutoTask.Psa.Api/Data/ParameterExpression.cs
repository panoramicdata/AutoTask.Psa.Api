using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ParameterExpression
	/// </summary>
	[DataContract]
	public partial class ParameterExpression
	{
		/// <summary>
		/// Gets or Sets NodeType
		/// </summary>
		[DataMember(Name = "NodeType", EmitDefaultValue = false)]
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
		[DataMember(Name = "Type", EmitDefaultValue = false)]
		public string Type { get; private set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; private set; }

		/// <summary>
		/// Gets or Sets IsByRef
		/// </summary>
		[DataMember(Name = "IsByRef", EmitDefaultValue = false)]
		public bool? IsByRef { get; private set; }

		/// <summary>
		/// Gets or Sets CanReduce
		/// </summary>
		[DataMember(Name = "CanReduce", EmitDefaultValue = false)]
		public bool? CanReduce { get; private set; }
	}
}
