using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// PriceListWorkTypeModifierModel
	/// </summary>
	[DataContract]
	public partial class PriceListWorkTypeModifierModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PriceListWorkTypeModifierModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CurrencyID">CurrencyID.</param>
		/// <param name="ModifierType">ModifierType.</param>
		/// <param name="ModifierValue">ModifierValue.</param>
		/// <param name="UsesInternalCurrencyPrice">UsesInternalCurrencyPrice.</param>
		/// <param name="WorkTypeModifierID">WorkTypeModifierID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public PriceListWorkTypeModifierModel(long? Id = default, int? CurrencyID = default, int? ModifierType = default, double? ModifierValue = default, bool? UsesInternalCurrencyPrice = default, int? WorkTypeModifierID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CurrencyID = CurrencyID;
			this.ModifierType = ModifierType;
			this.ModifierValue = ModifierValue;
			this.UsesInternalCurrencyPrice = UsesInternalCurrencyPrice;
			this.WorkTypeModifierID = WorkTypeModifierID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyID
		/// </summary>
		[DataMember(Name = "CurrencyID", EmitDefaultValue = false)]
		public int? CurrencyID { get; set; }

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
		/// Gets or Sets UsesInternalCurrencyPrice
		/// </summary>
		[DataMember(Name = "UsesInternalCurrencyPrice", EmitDefaultValue = false)]
		public bool? UsesInternalCurrencyPrice { get; set; }

		/// <summary>
		/// Gets or Sets WorkTypeModifierID
		/// </summary>
		[DataMember(Name = "WorkTypeModifierID", EmitDefaultValue = false)]
		public int? WorkTypeModifierID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
