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
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AdjustedUnitCost
		/// </summary>
		[DataMember(Name = "AdjustedUnitCost")]
		public double? AdjustedUnitCost { get; set; }

		/// <summary>
		/// Gets or Sets AdjustedUnitPrice
		/// </summary>
		[DataMember(Name = "AdjustedUnitPrice")]
		public double? AdjustedUnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets AllowRepeatService
		/// </summary>
		[DataMember(Name = "AllowRepeatService")]
		public bool? AllowRepeatService { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID")]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceID
		/// </summary>
		[DataMember(Name = "ContractServiceID")]
		public int? ContractServiceID { get; set; }

		/// <summary>
		/// Gets or Sets EffectiveDate
		/// </summary>
		[DataMember(Name = "EffectiveDate")]
		public DateTime? EffectiveDate { get; set; }

		/// <summary>
		/// Gets or Sets QuoteItemID
		/// </summary>
		[DataMember(Name = "QuoteItemID")]
		public int? QuoteItemID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceID
		/// </summary>
		[DataMember(Name = "ServiceID")]
		public int? ServiceID { get; set; }

		/// <summary>
		/// Gets or Sets UnitChange
		/// </summary>
		[DataMember(Name = "UnitChange")]
		public int? UnitChange { get; set; }

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
