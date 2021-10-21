using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractServiceBundleModel
	/// </summary>
	[DataContract]
	public partial class ContractServiceBundleModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AdjustedPrice
		/// </summary>
		[DataMember(Name = "AdjustedPrice")]
		public double? AdjustedPrice { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID")]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyAdjustedPrice
		/// </summary>
		[DataMember(Name = "InternalCurrencyAdjustedPrice")]
		public double? InternalCurrencyAdjustedPrice { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyUnitPrice
		/// </summary>
		[DataMember(Name = "InternalCurrencyUnitPrice")]
		public double? InternalCurrencyUnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets InternalDescription
		/// </summary>
		[DataMember(Name = "InternalDescription")]
		public string InternalDescription { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets InvoiceDescription
		/// </summary>
		[DataMember(Name = "InvoiceDescription")]
		public string InvoiceDescription { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets QuoteItemID
		/// </summary>
		[DataMember(Name = "QuoteItemID")]
		public long? QuoteItemID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceBundleID
		/// </summary>
		[DataMember(Name = "ServiceBundleID")]
		public int? ServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets UnitPrice
		/// </summary>
		[DataMember(Name = "UnitPrice")]
		public double? UnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId")]
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
