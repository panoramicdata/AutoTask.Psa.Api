namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ExpenseReportModel
/// </summary>
[DataContract]
public class ExpenseReportModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AmountDue
	/// </summary>
	[DataMember(Name = "AmountDue")]
	public double? AmountDue { get; set; }

	/// <summary>
	/// Gets or Sets ApprovedDate
	/// </summary>
	[DataMember(Name = "ApprovedDate")]
	public DateTime? ApprovedDate { get; set; }

	/// <summary>
	/// Gets or Sets ApproverID
	/// </summary>
	[DataMember(Name = "ApproverID")]
	public int? ApproverID { get; set; }

	/// <summary>
	/// Gets or Sets DepartmentNumber
	/// </summary>
	[DataMember(Name = "DepartmentNumber")]
	public string DepartmentNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets InternalCurrencyCashAdvanceAmount
	/// </summary>
	[DataMember(Name = "InternalCurrencyCashAdvanceAmount")]
	public double? InternalCurrencyCashAdvanceAmount { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyExpenseTotal
	/// </summary>
	[DataMember(Name = "InternalCurrencyExpenseTotal")]
	public double? InternalCurrencyExpenseTotal { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets OrganizationalLevelAssociationID
	/// </summary>
	[DataMember(Name = "OrganizationalLevelAssociationID")]
	public int? OrganizationalLevelAssociationID { get; set; }

	/// <summary>
	/// Gets or Sets QuickBooksReferenceNumber
	/// </summary>
	[DataMember(Name = "QuickBooksReferenceNumber")]
	public string QuickBooksReferenceNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ReimbursementCurrencyAmountDue
	/// </summary>
	[DataMember(Name = "ReimbursementCurrencyAmountDue")]
	public double? ReimbursementCurrencyAmountDue { get; set; }

	/// <summary>
	/// Gets or Sets ReimbursementCurrencyCashAdvanceAmount
	/// </summary>
	[DataMember(Name = "ReimbursementCurrencyCashAdvanceAmount")]
	public double? ReimbursementCurrencyCashAdvanceAmount { get; set; }

	/// <summary>
	/// Gets or Sets ReimbursementCurrencyID
	/// </summary>
	[DataMember(Name = "ReimbursementCurrencyID")]
	public int? ReimbursementCurrencyID { get; set; }

	/// <summary>
	/// Gets or Sets RejectionReason
	/// </summary>
	[DataMember(Name = "RejectionReason")]
	public string RejectionReason { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

	/// <summary>
	/// Gets or Sets Submit
	/// </summary>
	[DataMember(Name = "Submit")]
	public bool? Submit { get; set; }

	/// <summary>
	/// Gets or Sets SubmitDate
	/// </summary>
	[DataMember(Name = "SubmitDate")]
	public DateTime? SubmitDate { get; set; }

	/// <summary>
	/// Gets or Sets SubmitterID
	/// </summary>
	[DataMember(Name = "SubmitterID")]
	public int? SubmitterID { get; set; }

	/// <summary>
	/// Gets or Sets WeekEnding
	/// </summary>
	[DataMember(Name = "WeekEnding")]
	public DateTime? WeekEnding { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
