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
		/// Initializes a new instance of the <see cref="ContractBillingRuleModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="CreateChargesAsBillable">CreateChargesAsBillable.</param>
		/// <param name="DailyProratedCost">DailyProratedCost.</param>
		/// <param name="DailyProratedPrice">DailyProratedPrice.</param>
		/// <param name="DetermineUnits">DetermineUnits.</param>
		/// <param name="EndDate">EndDate.</param>
		/// <param name="ExecutionMethod">ExecutionMethod.</param>
		/// <param name="IncludeItemsInChargeDescription">IncludeItemsInChargeDescription.</param>
		/// <param name="InvoiceDescription">InvoiceDescription.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsDailyProrationEnabled">IsDailyProrationEnabled.</param>
		/// <param name="MaximumUnits">MaximumUnits.</param>
		/// <param name="MinimumUnits">MinimumUnits.</param>
		/// <param name="ProductID">ProductID.</param>
		/// <param name="StartDate">StartDate.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractBillingRuleModel(long? Id = default, int? ContractID = default, bool? CreateChargesAsBillable = default, double? DailyProratedCost = default, double? DailyProratedPrice = default, int? DetermineUnits = default, DateTime? EndDate = default, int? ExecutionMethod = default, bool? IncludeItemsInChargeDescription = default, string InvoiceDescription = default, bool? IsActive = default, bool? IsDailyProrationEnabled = default, int? MaximumUnits = default, int? MinimumUnits = default, int? ProductID = default, DateTime? StartDate = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ContractID = ContractID;
			this.CreateChargesAsBillable = CreateChargesAsBillable;
			this.DailyProratedCost = DailyProratedCost;
			this.DailyProratedPrice = DailyProratedPrice;
			this.DetermineUnits = DetermineUnits;
			this.EndDate = EndDate;
			this.ExecutionMethod = ExecutionMethod;
			this.IncludeItemsInChargeDescription = IncludeItemsInChargeDescription;
			this.InvoiceDescription = InvoiceDescription;
			this.IsActive = IsActive;
			this.IsDailyProrationEnabled = IsDailyProrationEnabled;
			this.MaximumUnits = MaximumUnits;
			this.MinimumUnits = MinimumUnits;
			this.ProductID = ProductID;
			this.StartDate = StartDate;
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
