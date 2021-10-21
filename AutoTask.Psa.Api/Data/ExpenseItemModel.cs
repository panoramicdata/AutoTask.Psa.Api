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
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID")]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Destination
		/// </summary>
		[DataMember(Name = "Destination")]
		public string Destination { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets EntertainmentLocation
		/// </summary>
		[DataMember(Name = "EntertainmentLocation")]
		public string EntertainmentLocation { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ExpenseCategory
		/// </summary>
		[DataMember(Name = "ExpenseCategory")]
		public int? ExpenseCategory { get; set; }

		/// <summary>
		/// Gets or Sets ExpenseCurrencyExpenseAmount
		/// </summary>
		[DataMember(Name = "ExpenseCurrencyExpenseAmount")]
		public double? ExpenseCurrencyExpenseAmount { get; set; }

		/// <summary>
		/// Gets or Sets ExpenseCurrencyID
		/// </summary>
		[DataMember(Name = "ExpenseCurrencyID")]
		public int? ExpenseCurrencyID { get; set; }

		/// <summary>
		/// Gets or Sets ExpenseDate
		/// </summary>
		[DataMember(Name = "ExpenseDate")]
		public DateTime? ExpenseDate { get; set; }

		/// <summary>
		/// Gets or Sets ExpenseReportID
		/// </summary>
		[DataMember(Name = "ExpenseReportID")]
		public int? ExpenseReportID { get; set; }

		/// <summary>
		/// Gets or Sets GLCode
		/// </summary>
		[DataMember(Name = "GLCode")]
		public string GLCode { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets HaveReceipt
		/// </summary>
		[DataMember(Name = "HaveReceipt")]
		public bool? HaveReceipt { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyExpenseAmount
		/// </summary>
		[DataMember(Name = "InternalCurrencyExpenseAmount")]
		public double? InternalCurrencyExpenseAmount { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyReimbursementAmount
		/// </summary>
		[DataMember(Name = "InternalCurrencyReimbursementAmount")]
		public double? InternalCurrencyReimbursementAmount { get; set; }

		/// <summary>
		/// Gets or Sets IsBillableToCompany
		/// </summary>
		[DataMember(Name = "IsBillableToCompany")]
		public bool? IsBillableToCompany { get; set; }

		/// <summary>
		/// Gets or Sets IsReimbursable
		/// </summary>
		[DataMember(Name = "IsReimbursable")]
		public bool? IsReimbursable { get; set; }

		/// <summary>
		/// Gets or Sets IsRejected
		/// </summary>
		[DataMember(Name = "IsRejected")]
		public bool? IsRejected { get; set; }

		/// <summary>
		/// Gets or Sets Miles
		/// </summary>
		[DataMember(Name = "Miles")]
		public double? Miles { get; set; }

		/// <summary>
		/// Gets or Sets OdometerEnd
		/// </summary>
		[DataMember(Name = "OdometerEnd")]
		public double? OdometerEnd { get; set; }

		/// <summary>
		/// Gets or Sets OdometerStart
		/// </summary>
		[DataMember(Name = "OdometerStart")]
		public double? OdometerStart { get; set; }

		/// <summary>
		/// Gets or Sets Origin
		/// </summary>
		[DataMember(Name = "Origin")]
		public string Origin { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets PaymentType
		/// </summary>
		[DataMember(Name = "PaymentType")]
		public int? PaymentType { get; set; }

		/// <summary>
		/// Gets or Sets ProjectID
		/// </summary>
		[DataMember(Name = "ProjectID")]
		public int? ProjectID { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ReimbursementCurrencyReimbursementAmount
		/// </summary>
		[DataMember(Name = "ReimbursementCurrencyReimbursementAmount")]
		public double? ReimbursementCurrencyReimbursementAmount { get; set; }

		/// <summary>
		/// Gets or Sets TaskID
		/// </summary>
		[DataMember(Name = "TaskID")]
		public int? TaskID { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID")]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets WorkType
		/// </summary>
		[DataMember(Name = "WorkType")]
		public int? WorkType { get; set; }

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
