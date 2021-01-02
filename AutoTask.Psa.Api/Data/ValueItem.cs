using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ValueItem
	/// </summary>
	[DataContract]
	public partial class ValueItem
	{
		/// <summary>
		/// Gets or Sets ElementList
		/// </summary>
		[DataMember(Name = "ElementList", EmitDefaultValue = false)]
		public List<CollectionItem> ElementList { get; set; } = new();

		/// <summary>
		/// Gets or Sets BoolValue
		/// </summary>
		[DataMember(Name = "BoolValue", EmitDefaultValue = false)]
		public bool? BoolValue { get; set; }

		/// <summary>
		/// Gets or Sets IntegerValue
		/// </summary>
		[DataMember(Name = "IntegerValue", EmitDefaultValue = false)]
		public int? IntegerValue { get; set; }

		/// <summary>
		/// Gets or Sets StringValue
		/// </summary>
		[DataMember(Name = "StringValue", EmitDefaultValue = false)]
		public string StringValue { get; set; } = string.Empty;
	}
}
