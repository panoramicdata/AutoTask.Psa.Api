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
