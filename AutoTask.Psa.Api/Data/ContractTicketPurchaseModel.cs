namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractTicketPurchaseModel
/// </summary>
[DataContract]
public partial class ContractTicketPurchaseModel
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
	public long? ContractID { get; set; }

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
	/// Gets or Sets PerTicketRate
	/// </summary>
	[DataMember(Name = "PerTicketRate")]
	public double? PerTicketRate { get; set; }

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
	/// Gets or Sets TicketsPurchased
	/// </summary>
	[DataMember(Name = "TicketsPurchased")]
	public double? TicketsPurchased { get; set; }

	/// <summary>
	/// Gets or Sets TicketsUsed
	/// </summary>
	[DataMember(Name = "TicketsUsed")]
	public double? TicketsUsed { get; set; }

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
