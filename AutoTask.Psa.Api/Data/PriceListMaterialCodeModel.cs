using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// PriceListMaterialCodeModel
	/// </summary>
	[DataContract]
	public partial class PriceListMaterialCodeModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PriceListMaterialCodeModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BillingCodeID">BillingCodeID.</param>
		/// <param name="CurrencyID">CurrencyID.</param>
		/// <param name="UnitPrice">UnitPrice.</param>
		/// <param name="UsesInternalCurrencyPrice">UsesInternalCurrencyPrice.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public PriceListMaterialCodeModel(long? Id = default, int? BillingCodeID = default, int? CurrencyID = default, double? UnitPrice = default, bool? UsesInternalCurrencyPrice = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BillingCodeID = BillingCodeID;
			this.CurrencyID = CurrencyID;
			this.UnitPrice = UnitPrice;
			this.UsesInternalCurrencyPrice = UsesInternalCurrencyPrice;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BillingCodeID
		/// </summary>
		[DataMember(Name = "BillingCodeID", EmitDefaultValue = false)]
		public int? BillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyID
		/// </summary>
		[DataMember(Name = "CurrencyID", EmitDefaultValue = false)]
		public int? CurrencyID { get; set; }

		/// <summary>
		/// Gets or Sets UnitPrice
		/// </summary>
		[DataMember(Name = "UnitPrice", EmitDefaultValue = false)]
		public double? UnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets UsesInternalCurrencyPrice
		/// </summary>
		[DataMember(Name = "UsesInternalCurrencyPrice", EmitDefaultValue = false)]
		public bool? UsesInternalCurrencyPrice { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
