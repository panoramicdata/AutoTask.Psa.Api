using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractServiceBundleAdjustmentModel
	/// </summary>
	[DataContract]
	public partial class ContractServiceBundleAdjustmentModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AdjustedUnitPrice
		/// </summary>
		[DataMember(Name = "AdjustedUnitPrice", EmitDefaultValue = false)]
		public double? AdjustedUnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets AllowRepeatServiceBundle
		/// </summary>
		[DataMember(Name = "AllowRepeatServiceBundle", EmitDefaultValue = false)]
		public bool? AllowRepeatServiceBundle { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceBundleID
		/// </summary>
		[DataMember(Name = "ContractServiceBundleID", EmitDefaultValue = false)]
		public int? ContractServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets EffectiveDate
		/// </summary>
		[DataMember(Name = "EffectiveDate", EmitDefaultValue = false)]
		public DateTime? EffectiveDate { get; set; }

		/// <summary>
		/// Gets or Sets QuoteItemID
		/// </summary>
		[DataMember(Name = "QuoteItemID", EmitDefaultValue = false)]
		public int? QuoteItemID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceBundleID
		/// </summary>
		[DataMember(Name = "ServiceBundleID", EmitDefaultValue = false)]
		public int? ServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets UnitChange
		/// </summary>
		[DataMember(Name = "UnitChange", EmitDefaultValue = false)]
		public int? UnitChange { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
