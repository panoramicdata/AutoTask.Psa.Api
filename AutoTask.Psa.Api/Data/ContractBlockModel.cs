namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractBlockModel
/// </summary>
[DataContract]
public class ContractBlockModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets DatePurchased
	/// </summary>
	[DataMember(Name = "DatePurchased")]
	public DateTime? DatePurchased { get; set; }

	/// <summary>
	/// Gets or Sets EndDate
	/// </summary>
	[DataMember(Name = "EndDate")]
	public DateTime? EndDate { get; set; }

	/// <summary>
	/// Gets or Sets HourlyRate
	/// </summary>
	[DataMember(Name = "HourlyRate")]
	public double? HourlyRate { get; set; }

	/// <summary>
	/// Gets or Sets Hours
	/// </summary>
	[DataMember(Name = "Hours")]
	public double? Hours { get; set; }

	/// <summary>
	/// Gets or Sets HoursApproved
	/// </summary>
	[DataMember(Name = "HoursApproved")]
	public double? HoursApproved { get; set; }

	/// <summary>
	/// Gets or Sets InvoiceNumber
	/// </summary>
	[DataMember(Name = "InvoiceNumber")]
	public string InvoiceNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets IsPaid
	/// </summary>
	[DataMember(Name = "IsPaid")]
	public bool? IsPaid { get; set; }

	/// <summary>
	/// Gets or Sets PaymentNumber
	/// </summary>
	[DataMember(Name = "PaymentNumber")]
	public string PaymentNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets PaymentType
	/// </summary>
	[DataMember(Name = "PaymentType")]
	public int? PaymentType { get; set; }

	/// <summary>
	/// Gets or Sets StartDate
	/// </summary>
	[DataMember(Name = "StartDate")]
	public DateTime? StartDate { get; set; }

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

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
