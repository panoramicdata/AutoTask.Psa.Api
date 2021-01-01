using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ExpenseItemModel
	/// </summary>
	[DataContract]
	public partial class ExpenseItemModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets Destination
		/// </summary>
		[DataMember(Name = "Destination", EmitDefaultValue = false)]
		public string Destination { get; set; }

		/// <summary>
		/// Gets or Sets EntertainmentLocation
		/// </summary>
		[DataMember(Name = "EntertainmentLocation", EmitDefaultValue = false)]
		public string EntertainmentLocation { get; set; }

		/// <summary>
		/// Gets or Sets ExpenseCategory
		/// </summary>
		[DataMember(Name = "ExpenseCategory", EmitDefaultValue = false)]
		public int? ExpenseCategory { get; set; }

		/// <summary>
		/// Gets or Sets ExpenseCurrencyExpenseAmount
		/// </summary>
		[DataMember(Name = "ExpenseCurrencyExpenseAmount", EmitDefaultValue = false)]
		public double? ExpenseCurrencyExpenseAmount { get; set; }

		/// <summary>
		/// Gets or Sets ExpenseCurrencyID
		/// </summary>
		[DataMember(Name = "ExpenseCurrencyID", EmitDefaultValue = false)]
		public int? ExpenseCurrencyID { get; set; }

		/// <summary>
		/// Gets or Sets ExpenseDate
		/// </summary>
		[DataMember(Name = "ExpenseDate", EmitDefaultValue = false)]
		public DateTime? ExpenseDate { get; set; }

		/// <summary>
		/// Gets or Sets ExpenseReportID
		/// </summary>
		[DataMember(Name = "ExpenseReportID", EmitDefaultValue = false)]
		public int? ExpenseReportID { get; set; }

		/// <summary>
		/// Gets or Sets GLCode
		/// </summary>
		[DataMember(Name = "GLCode", EmitDefaultValue = false)]
		public string GLCode { get; set; }

		/// <summary>
		/// Gets or Sets HaveReceipt
		/// </summary>
		[DataMember(Name = "HaveReceipt", EmitDefaultValue = false)]
		public bool? HaveReceipt { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyExpenseAmount
		/// </summary>
		[DataMember(Name = "InternalCurrencyExpenseAmount", EmitDefaultValue = false)]
		public double? InternalCurrencyExpenseAmount { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyReimbursementAmount
		/// </summary>
		[DataMember(Name = "InternalCurrencyReimbursementAmount", EmitDefaultValue = false)]
		public double? InternalCurrencyReimbursementAmount { get; set; }

		/// <summary>
		/// Gets or Sets IsBillableToCompany
		/// </summary>
		[DataMember(Name = "IsBillableToCompany", EmitDefaultValue = false)]
		public bool? IsBillableToCompany { get; set; }

		/// <summary>
		/// Gets or Sets IsReimbursable
		/// </summary>
		[DataMember(Name = "IsReimbursable", EmitDefaultValue = false)]
		public bool? IsReimbursable { get; set; }

		/// <summary>
		/// Gets or Sets IsRejected
		/// </summary>
		[DataMember(Name = "IsRejected", EmitDefaultValue = false)]
		public bool? IsRejected { get; set; }

		/// <summary>
		/// Gets or Sets Miles
		/// </summary>
		[DataMember(Name = "Miles", EmitDefaultValue = false)]
		public double? Miles { get; set; }

		/// <summary>
		/// Gets or Sets OdometerEnd
		/// </summary>
		[DataMember(Name = "OdometerEnd", EmitDefaultValue = false)]
		public double? OdometerEnd { get; set; }

		/// <summary>
		/// Gets or Sets OdometerStart
		/// </summary>
		[DataMember(Name = "OdometerStart", EmitDefaultValue = false)]
		public double? OdometerStart { get; set; }

		/// <summary>
		/// Gets or Sets Origin
		/// </summary>
		[DataMember(Name = "Origin", EmitDefaultValue = false)]
		public string Origin { get; set; }

		/// <summary>
		/// Gets or Sets PaymentType
		/// </summary>
		[DataMember(Name = "PaymentType", EmitDefaultValue = false)]
		public int? PaymentType { get; set; }

		/// <summary>
		/// Gets or Sets ProjectID
		/// </summary>
		[DataMember(Name = "ProjectID", EmitDefaultValue = false)]
		public int? ProjectID { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Gets or Sets ReimbursementCurrencyReimbursementAmount
		/// </summary>
		[DataMember(Name = "ReimbursementCurrencyReimbursementAmount", EmitDefaultValue = false)]
		public double? ReimbursementCurrencyReimbursementAmount { get; set; }

		/// <summary>
		/// Gets or Sets TaskID
		/// </summary>
		[DataMember(Name = "TaskID", EmitDefaultValue = false)]
		public int? TaskID { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets WorkType
		/// </summary>
		[DataMember(Name = "WorkType", EmitDefaultValue = false)]
		public int? WorkType { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncExpenseItemInt64 SoapParentPropertyId { get; private set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
