using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// UserDefinedField
	/// </summary>
	[DataContract]
	public partial class UserDefinedField
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserDefinedField" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Value">Value.</param>
		public UserDefinedField(string Name = default, string Value = default)
		{
			this.Name = Name;
			this.Value = Value;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public string Value { get; set; }
	}
}
