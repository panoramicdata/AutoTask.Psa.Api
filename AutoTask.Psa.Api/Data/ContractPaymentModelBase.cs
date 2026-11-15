namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Properties common to the contract block and contract ticket purchase entities.
/// </summary>
[DataContract]
public abstract class ContractPaymentModelBase : ParentedEntityModelBase
{
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
	/// Gets or Sets StartDate
	/// </summary>
	[DataMember(Name = "StartDate")]
	public DateTime? StartDate { get; set; }

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }
}
