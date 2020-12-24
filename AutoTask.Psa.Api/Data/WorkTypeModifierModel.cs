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
		/// Initializes a new instance of the <see cref="WorkTypeModifierModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ModifierType">ModifierType.</param>
		/// <param name="ModifierValue">ModifierValue.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public WorkTypeModifierModel(long? Id = default, int? ModifierType = default, double? ModifierValue = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ModifierType = ModifierType;
			this.ModifierValue = ModifierValue;
			this.UserDefinedFields = UserDefinedFields;
		}

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
