using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractServiceAdjustmentModel
	/// </summary>
	[DataContract]
	public partial class ContractServiceAdjustmentModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AdjustedUnitCost
		/// </summary>
		[DataMember(Name = "AdjustedUnitCost", EmitDefaultValue = false)]
		public double? AdjustedUnitCost { get; set; }

		/// <summary>
		/// Gets or Sets AdjustedUnitPrice
		/// </summary>
		[DataMember(Name = "AdjustedUnitPrice", EmitDefaultValue = false)]
		public double? AdjustedUnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets AllowRepeatService
		/// </summary>
		[DataMember(Name = "AllowRepeatService", EmitDefaultValue = false)]
		public bool? AllowRepeatService { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceID
		/// </summary>
		[DataMember(Name = "ContractServiceID", EmitDefaultValue = false)]
		public int? ContractServiceID { get; set; }

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
		/// Gets or Sets ServiceID
		/// </summary>
		[DataMember(Name = "ServiceID", EmitDefaultValue = false)]
		public int? ServiceID { get; set; }

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
