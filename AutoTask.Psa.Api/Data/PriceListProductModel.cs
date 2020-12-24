using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// PriceListProductModel
	/// </summary>
	[DataContract]
	public partial class PriceListProductModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PriceListProductModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CurrencyID">CurrencyID.</param>
		/// <param name="ProductID">ProductID.</param>
		/// <param name="UnitPrice">UnitPrice.</param>
		/// <param name="UsesInternalCurrencyPrice">UsesInternalCurrencyPrice.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public PriceListProductModel(long? Id = default, int? CurrencyID = default, int? ProductID = default, double? UnitPrice = default, bool? UsesInternalCurrencyPrice = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CurrencyID = CurrencyID;
			this.ProductID = ProductID;
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
		/// Gets or Sets CurrencyID
		/// </summary>
		[DataMember(Name = "CurrencyID", EmitDefaultValue = false)]
		public int? CurrencyID { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public int? ProductID { get; set; }

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
