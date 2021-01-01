using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// WorkTypeModifierModel
	/// </summary>
	[DataContract]
	public partial class WorkTypeModifierModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ModifierType
		/// </summary>
		[DataMember(Name = "ModifierType", EmitDefaultValue = false)]
		public int? ModifierType { get; set; }

		/// <summary>
		/// Gets or Sets ModifierValue
		/// </summary>
		[DataMember(Name = "ModifierValue", EmitDefaultValue = false)]
		public double? ModifierValue { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
