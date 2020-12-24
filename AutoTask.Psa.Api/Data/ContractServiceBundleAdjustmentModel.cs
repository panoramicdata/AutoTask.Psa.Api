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
		/// Initializes a new instance of the <see cref="ContractServiceBundleAdjustmentModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AdjustedUnitPrice">AdjustedUnitPrice.</param>
		/// <param name="AllowRepeatServiceBundle">AllowRepeatServiceBundle.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="ContractServiceBundleID">ContractServiceBundleID.</param>
		/// <param name="EffectiveDate">EffectiveDate.</param>
		/// <param name="QuoteItemID">QuoteItemID.</param>
		/// <param name="ServiceBundleID">ServiceBundleID.</param>
		/// <param name="UnitChange">UnitChange.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractServiceBundleAdjustmentModel(long? Id = default, double? AdjustedUnitPrice = default, bool? AllowRepeatServiceBundle = default, int? ContractID = default, int? ContractServiceBundleID = default, DateTime? EffectiveDate = default, int? QuoteItemID = default, int? ServiceBundleID = default, int? UnitChange = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AdjustedUnitPrice = AdjustedUnitPrice;
			this.AllowRepeatServiceBundle = AllowRepeatServiceBundle;
			this.ContractID = ContractID;
			this.ContractServiceBundleID = ContractServiceBundleID;
			this.EffectiveDate = EffectiveDate;
			this.QuoteItemID = QuoteItemID;
			this.ServiceBundleID = ServiceBundleID;
			this.UnitChange = UnitChange;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		public ExpressionFuncContractServiceBundleAdjustmentInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
