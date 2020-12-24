using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CollectionItem
	/// </summary>
	[DataContract]
	public partial class CollectionItem
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CollectionItem" /> class.
		/// </summary>
		/// <param name="IntegerValue">IntegerValue.</param>
		/// <param name="StringValue">StringValue.</param>
		public CollectionItem(int? IntegerValue = default, string StringValue = default)
		{
			this.IntegerValue = IntegerValue;
			this.StringValue = StringValue;
		}

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
