using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// QuoteItemModel
	/// </summary>
	[DataContract]
	public partial class QuoteItemModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QuoteItemModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AverageCost">AverageCost.</param>
		/// <param name="ChargeID">ChargeID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="ExpenseID">ExpenseID.</param>
		/// <param name="HighestCost">HighestCost.</param>
		/// <param name="InternalCurrencyLineDiscount">InternalCurrencyLineDiscount.</param>
		/// <param name="InternalCurrencyUnitDiscount">InternalCurrencyUnitDiscount.</param>
		/// <param name="InternalCurrencyUnitPrice">InternalCurrencyUnitPrice.</param>
		/// <param name="IsOptional">IsOptional.</param>
		/// <param name="IsTaxable">IsTaxable.</param>
		/// <param name="LaborID">LaborID.</param>
		/// <param name="LineDiscount">LineDiscount.</param>
		/// <param name="MarkupRate">MarkupRate.</param>
		/// <param name="Name">Name.</param>
		/// <param name="PercentageDiscount">PercentageDiscount.</param>
		/// <param name="PeriodType">PeriodType.</param>
		/// <param name="ProductID">ProductID.</param>
		/// <param name="Quantity">Quantity.</param>
		/// <param name="QuoteID">QuoteID.</param>
		/// <param name="QuoteItemType">QuoteItemType.</param>
		/// <param name="ServiceBundleID">ServiceBundleID.</param>
		/// <param name="ServiceID">ServiceID.</param>
		/// <param name="ShippingID">ShippingID.</param>
		/// <param name="TaxCategoryID">TaxCategoryID.</param>
		/// <param name="TotalEffectiveTax">TotalEffectiveTax.</param>
		/// <param name="UnitCost">UnitCost.</param>
		/// <param name="UnitDiscount">UnitDiscount.</param>
		/// <param name="UnitPrice">UnitPrice.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public QuoteItemModel(long? Id = default, double? AverageCost = default, int? ChargeID = default, string Description = default, int? ExpenseID = default, double? HighestCost = default, double? InternalCurrencyLineDiscount = default, double? InternalCurrencyUnitDiscount = default, double? InternalCurrencyUnitPrice = default, bool? IsOptional = default, bool? IsTaxable = default, int? LaborID = default, double? LineDiscount = default, double? MarkupRate = default, string Name = default, double? PercentageDiscount = default, int? PeriodType = default, int? ProductID = default, double? Quantity = default, int? QuoteID = default, int? QuoteItemType = default, int? ServiceBundleID = default, int? ServiceID = default, int? ShippingID = default, int? TaxCategoryID = default, double? TotalEffectiveTax = default, double? UnitCost = default, double? UnitDiscount = default, double? UnitPrice = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AverageCost = AverageCost;
			this.ChargeID = ChargeID;
			this.Description = Description;
			this.ExpenseID = ExpenseID;
			this.HighestCost = HighestCost;
			this.InternalCurrencyLineDiscount = InternalCurrencyLineDiscount;
			this.InternalCurrencyUnitDiscount = InternalCurrencyUnitDiscount;
			this.InternalCurrencyUnitPrice = InternalCurrencyUnitPrice;
			this.IsOptional = IsOptional;
			this.IsTaxable = IsTaxable;
			this.LaborID = LaborID;
			this.LineDiscount = LineDiscount;
			this.MarkupRate = MarkupRate;
			this.Name = Name;
			this.PercentageDiscount = PercentageDiscount;
			this.PeriodType = PeriodType;
			this.ProductID = ProductID;
			this.Quantity = Quantity;
			this.QuoteID = QuoteID;
			this.QuoteItemType = QuoteItemType;
			this.ServiceBundleID = ServiceBundleID;
			this.ServiceID = ServiceID;
			this.ShippingID = ShippingID;
			this.TaxCategoryID = TaxCategoryID;
			this.TotalEffectiveTax = TotalEffectiveTax;
			this.UnitCost = UnitCost;
			this.UnitDiscount = UnitDiscount;
			this.UnitPrice = UnitPrice;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AverageCost
		/// </summary>
		[DataMember(Name = "AverageCost", EmitDefaultValue = false)]
		public double? AverageCost { get; set; }

		/// <summary>
		/// Gets or Sets ChargeID
		/// </summary>
		[DataMember(Name = "ChargeID", EmitDefaultValue = false)]
		public int? ChargeID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets ExpenseID
		/// </summary>
		[DataMember(Name = "ExpenseID", EmitDefaultValue = false)]
		public int? ExpenseID { get; set; }

		/// <summary>
		/// Gets or Sets HighestCost
		/// </summary>
		[DataMember(Name = "HighestCost", EmitDefaultValue = false)]
		public double? HighestCost { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyLineDiscount
		/// </summary>
		[DataMember(Name = "InternalCurrencyLineDiscount", EmitDefaultValue = false)]
		public double? InternalCurrencyLineDiscount { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyUnitDiscount
		/// </summary>
		[DataMember(Name = "InternalCurrencyUnitDiscount", EmitDefaultValue = false)]
		public double? InternalCurrencyUnitDiscount { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyUnitPrice
		/// </summary>
		[DataMember(Name = "InternalCurrencyUnitPrice", EmitDefaultValue = false)]
		public double? InternalCurrencyUnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets IsOptional
		/// </summary>
		[DataMember(Name = "IsOptional", EmitDefaultValue = false)]
		public bool? IsOptional { get; set; }

		/// <summary>
		/// Gets or Sets IsTaxable
		/// </summary>
		[DataMember(Name = "IsTaxable", EmitDefaultValue = false)]
		public bool? IsTaxable { get; set; }

		/// <summary>
		/// Gets or Sets LaborID
		/// </summary>
		[DataMember(Name = "LaborID", EmitDefaultValue = false)]
		public int? LaborID { get; set; }

		/// <summary>
		/// Gets or Sets LineDiscount
		/// </summary>
		[DataMember(Name = "LineDiscount", EmitDefaultValue = false)]
		public double? LineDiscount { get; set; }

		/// <summary>
		/// Gets or Sets MarkupRate
		/// </summary>
		[DataMember(Name = "MarkupRate", EmitDefaultValue = false)]
		public double? MarkupRate { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PercentageDiscount
		/// </summary>
		[DataMember(Name = "PercentageDiscount", EmitDefaultValue = false)]
		public double? PercentageDiscount { get; set; }

		/// <summary>
		/// Gets or Sets PeriodType
		/// </summary>
		[DataMember(Name = "PeriodType", EmitDefaultValue = false)]
		public int? PeriodType { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public int? ProductID { get; set; }

		/// <summary>
		/// Gets or Sets Quantity
		/// </summary>
		[DataMember(Name = "Quantity", EmitDefaultValue = false)]
		public double? Quantity { get; set; }

		/// <summary>
		/// Gets or Sets QuoteID
		/// </summary>
		[DataMember(Name = "QuoteID", EmitDefaultValue = false)]
		public int? QuoteID { get; set; }

		/// <summary>
		/// Gets or Sets QuoteItemType
		/// </summary>
		[DataMember(Name = "QuoteItemType", EmitDefaultValue = false)]
		public int? QuoteItemType { get; set; }

		/// <summary>
		/// Gets or Sets ServiceBundleID
		/// </summary>
		[DataMember(Name = "ServiceBundleID", EmitDefaultValue = false)]
		public int? ServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceID
		/// </summary>
		[DataMember(Name = "ServiceID", EmitDefaultValue = false)]
		public int? ServiceID { get; set; }

		/// <summary>
		/// Gets or Sets ShippingID
		/// </summary>
		[DataMember(Name = "ShippingID", EmitDefaultValue = false)]
		public int? ShippingID { get; set; }

		/// <summary>
		/// Gets or Sets TaxCategoryID
		/// </summary>
		[DataMember(Name = "TaxCategoryID", EmitDefaultValue = false)]
		public int? TaxCategoryID { get; set; }

		/// <summary>
		/// Gets or Sets TotalEffectiveTax
		/// </summary>
		[DataMember(Name = "TotalEffectiveTax", EmitDefaultValue = false)]
		public double? TotalEffectiveTax { get; set; }

		/// <summary>
		/// Gets or Sets UnitCost
		/// </summary>
		[DataMember(Name = "UnitCost", EmitDefaultValue = false)]
		public double? UnitCost { get; set; }

		/// <summary>
		/// Gets or Sets UnitDiscount
		/// </summary>
		[DataMember(Name = "UnitDiscount", EmitDefaultValue = false)]
		public double? UnitDiscount { get; set; }

		/// <summary>
		/// Gets or Sets UnitPrice
		/// </summary>
		[DataMember(Name = "UnitPrice", EmitDefaultValue = false)]
		public double? UnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncQuoteItemInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
