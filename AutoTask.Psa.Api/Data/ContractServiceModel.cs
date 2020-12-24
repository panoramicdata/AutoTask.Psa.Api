using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractServiceModel
	/// </summary>
	[DataContract]
	public partial class ContractServiceModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractServiceModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="InternalCurrencyAdjustedPrice">InternalCurrencyAdjustedPrice.</param>
		/// <param name="InternalCurrencyUnitPrice">InternalCurrencyUnitPrice.</param>
		/// <param name="InternalDescription">InternalDescription.</param>
		/// <param name="InvoiceDescription">InvoiceDescription.</param>
		/// <param name="QuoteItemID">QuoteItemID.</param>
		/// <param name="ServiceID">ServiceID.</param>
		/// <param name="UnitCost">UnitCost.</param>
		/// <param name="UnitPrice">UnitPrice.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractServiceModel(long? Id = default, int? ContractID = default, double? InternalCurrencyAdjustedPrice = default, double? InternalCurrencyUnitPrice = default, string InternalDescription = default, string InvoiceDescription = default, long? QuoteItemID = default, int? ServiceID = default, double? UnitCost = default, double? UnitPrice = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ContractID = ContractID;
			this.InternalCurrencyAdjustedPrice = InternalCurrencyAdjustedPrice;
			this.InternalCurrencyUnitPrice = InternalCurrencyUnitPrice;
			this.InternalDescription = InternalDescription;
			this.InvoiceDescription = InvoiceDescription;
			this.QuoteItemID = QuoteItemID;
			this.ServiceID = ServiceID;
			this.UnitCost = UnitCost;
			this.UnitPrice = UnitPrice;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyAdjustedPrice
		/// </summary>
		[DataMember(Name = "InternalCurrencyAdjustedPrice", EmitDefaultValue = false)]
		public double? InternalCurrencyAdjustedPrice { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyUnitPrice
		/// </summary>
		[DataMember(Name = "InternalCurrencyUnitPrice", EmitDefaultValue = false)]
		public double? InternalCurrencyUnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets InternalDescription
		/// </summary>
		[DataMember(Name = "InternalDescription", EmitDefaultValue = false)]
		public string InternalDescription { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceDescription
		/// </summary>
		[DataMember(Name = "InvoiceDescription", EmitDefaultValue = false)]
		public string InvoiceDescription { get; set; }

		/// <summary>
		/// Gets or Sets QuoteItemID
		/// </summary>
		[DataMember(Name = "QuoteItemID", EmitDefaultValue = false)]
		public long? QuoteItemID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceID
		/// </summary>
		[DataMember(Name = "ServiceID", EmitDefaultValue = false)]
		public int? ServiceID { get; set; }

		/// <summary>
		/// Gets or Sets UnitCost
		/// </summary>
		[DataMember(Name = "UnitCost", EmitDefaultValue = false)]
		public double? UnitCost { get; set; }

		/// <summary>
		/// Gets or Sets UnitPrice
		/// </summary>
		[DataMember(Name = "UnitPrice", EmitDefaultValue = false)]
		public double? UnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContractServiceInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
