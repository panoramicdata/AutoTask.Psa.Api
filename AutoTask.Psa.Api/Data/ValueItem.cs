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
		/// Initializes a new instance of the <see cref="ValueItem" /> class.
		/// </summary>
		/// <param name="ElementList">ElementList.</param>
		/// <param name="BoolValue">BoolValue.</param>
		/// <param name="IntegerValue">IntegerValue.</param>
		/// <param name="StringValue">StringValue.</param>
		public ValueItem(List<CollectionItem> ElementList = default, bool? BoolValue = default, int? IntegerValue = default, string StringValue = default)
		{
			this.ElementList = ElementList;
			this.BoolValue = BoolValue;
			this.IntegerValue = IntegerValue;
			this.StringValue = StringValue;
		}

		/// <summary>
		/// Gets or Sets ElementList
		/// </summary>
		[DataMember(Name = "ElementList", EmitDefaultValue = false)]
		public List<CollectionItem> ElementList { get; set; }

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
		public string StringValue { get; set; }
	}
}
