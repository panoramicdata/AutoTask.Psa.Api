using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// Filter
	/// </summary>
	[DataContract]
	public partial class Filter
	{
		/// <summary>
		/// Gets or Sets Op
		/// </summary>
		[DataMember(Name = "op", EmitDefaultValue = false)]
		public string? Op { get; set; }

		/// <summary>
		/// Gets or Sets Field
		/// </summary>
		[DataMember(Name = "field", EmitDefaultValue = false)]
		public string? Field { get; set; }

		/// <summary>
		/// Gets or Sets Udf
		/// </summary>
		[DataMember(Name = "udf", EmitDefaultValue = false)]
		public bool? Udf { get; set; }

		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public object? Value { get; set; }

		/// <summary>
		/// Gets or Sets Items
		/// </summary>
		[DataMember(Name = "items", EmitDefaultValue = false)]
		public List<Filter>? Items { get; set; }
	}
}
