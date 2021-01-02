using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ExpenseReportModel
	/// </summary>
	[DataContract]
	public partial class ExpenseReportModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AmountDue
		/// </summary>
		[DataMember(Name = "AmountDue", EmitDefaultValue = false)]
		public double? AmountDue { get; set; }

		/// <summary>
		/// Gets or Sets ApprovedDate
		/// </summary>
		[DataMember(Name = "ApprovedDate", EmitDefaultValue = false)]
		public DateTime? ApprovedDate { get; set; }

		/// <summary>
		/// Gets or Sets ApproverID
		/// </summary>
		[DataMember(Name = "ApproverID", EmitDefaultValue = false)]
		public int? ApproverID { get; set; }

		/// <summary>
		/// Gets or Sets DepartmentNumber
		/// </summary>
		[DataMember(Name = "DepartmentNumber", EmitDefaultValue = false)]
		public string DepartmentNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets InternalCurrencyCashAdvanceAmount
		/// </summary>
		[DataMember(Name = "InternalCurrencyCashAdvanceAmount", EmitDefaultValue = false)]
		public double? InternalCurrencyCashAdvanceAmount { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyExpenseTotal
		/// </summary>
		[DataMember(Name = "InternalCurrencyExpenseTotal", EmitDefaultValue = false)]
		public double? InternalCurrencyExpenseTotal { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets QuickBooksReferenceNumber
		/// </summary>
		[DataMember(Name = "QuickBooksReferenceNumber", EmitDefaultValue = false)]
		public string QuickBooksReferenceNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ReimbursementCurrencyAmountDue
		/// </summary>
		[DataMember(Name = "ReimbursementCurrencyAmountDue", EmitDefaultValue = false)]
		public double? ReimbursementCurrencyAmountDue { get; set; }

		/// <summary>
		/// Gets or Sets ReimbursementCurrencyCashAdvanceAmount
		/// </summary>
		[DataMember(Name = "ReimbursementCurrencyCashAdvanceAmount", EmitDefaultValue = false)]
		public double? ReimbursementCurrencyCashAdvanceAmount { get; set; }

		/// <summary>
		/// Gets or Sets ReimbursementCurrencyID
		/// </summary>
		[DataMember(Name = "ReimbursementCurrencyID", EmitDefaultValue = false)]
		public int? ReimbursementCurrencyID { get; set; }

		/// <summary>
		/// Gets or Sets RejectionReason
		/// </summary>
		[DataMember(Name = "RejectionReason", EmitDefaultValue = false)]
		public string RejectionReason { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets Submit
		/// </summary>
		[DataMember(Name = "Submit", EmitDefaultValue = false)]
		public bool? Submit { get; set; }

		/// <summary>
		/// Gets or Sets SubmitDate
		/// </summary>
		[DataMember(Name = "SubmitDate", EmitDefaultValue = false)]
		public DateTime? SubmitDate { get; set; }

		/// <summary>
		/// Gets or Sets SubmitterID
		/// </summary>
		[DataMember(Name = "SubmitterID", EmitDefaultValue = false)]
		public int? SubmitterID { get; set; }

		/// <summary>
		/// Gets or Sets WeekEnding
		/// </summary>
		[DataMember(Name = "WeekEnding", EmitDefaultValue = false)]
		public DateTime? WeekEnding { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
