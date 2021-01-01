using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractBillingRuleModel
	/// </summary>
	[DataContract]
	public partial class ContractBillingRuleModel
	{
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
		/// Gets or Sets CreateChargesAsBillable
		/// </summary>
		[DataMember(Name = "CreateChargesAsBillable", EmitDefaultValue = false)]
		public bool? CreateChargesAsBillable { get; set; }

		/// <summary>
		/// Gets or Sets DailyProratedCost
		/// </summary>
		[DataMember(Name = "DailyProratedCost", EmitDefaultValue = false)]
		public double? DailyProratedCost { get; set; }

		/// <summary>
		/// Gets or Sets DailyProratedPrice
		/// </summary>
		[DataMember(Name = "DailyProratedPrice", EmitDefaultValue = false)]
		public double? DailyProratedPrice { get; set; }

		/// <summary>
		/// Gets or Sets DetermineUnits
		/// </summary>
		[DataMember(Name = "DetermineUnits", EmitDefaultValue = false)]
		public int? DetermineUnits { get; set; }

		/// <summary>
		/// Gets or Sets EndDate
		/// </summary>
		[DataMember(Name = "EndDate", EmitDefaultValue = false)]
		public DateTime? EndDate { get; set; }

		/// <summary>
		/// Gets or Sets ExecutionMethod
		/// </summary>
		[DataMember(Name = "ExecutionMethod", EmitDefaultValue = false)]
		public int? ExecutionMethod { get; set; }

		/// <summary>
		/// Gets or Sets IncludeItemsInChargeDescription
		/// </summary>
		[DataMember(Name = "IncludeItemsInChargeDescription", EmitDefaultValue = false)]
		public bool? IncludeItemsInChargeDescription { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceDescription
		/// </summary>
		[DataMember(Name = "InvoiceDescription", EmitDefaultValue = false)]
		public string InvoiceDescription { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsDailyProrationEnabled
		/// </summary>
		[DataMember(Name = "IsDailyProrationEnabled", EmitDefaultValue = false)]
		public bool? IsDailyProrationEnabled { get; set; }

		/// <summary>
		/// Gets or Sets MaximumUnits
		/// </summary>
		[DataMember(Name = "MaximumUnits", EmitDefaultValue = false)]
		public int? MaximumUnits { get; set; }

		/// <summary>
		/// Gets or Sets MinimumUnits
		/// </summary>
		[DataMember(Name = "MinimumUnits", EmitDefaultValue = false)]
		public int? MinimumUnits { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public int? ProductID { get; set; }

		/// <summary>
		/// Gets or Sets StartDate
		/// </summary>
		[DataMember(Name = "StartDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContractBillingRuleInt64 SoapParentPropertyId { get; private set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
