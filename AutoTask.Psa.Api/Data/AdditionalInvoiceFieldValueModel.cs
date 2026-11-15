namespace AutoTask.Psa.Api.Data;

/// <summary>
/// AdditionalInvoiceFieldValueModel
/// </summary>
[DataContract]
public class AdditionalInvoiceFieldValueModel : EntityModelBase
{
	/// <summary>
	/// Gets or Sets AdditionalInvoiceFieldID
	/// </summary>
	[DataMember(Name = "AdditionalInvoiceFieldID")]
	public long? AdditionalInvoiceFieldID { get; set; }

	/// <summary>
	/// Gets or Sets FieldValue
	/// </summary>
	[DataMember(Name = "FieldValue")]
	public string FieldValue { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets InvoiceBatchID
	/// </summary>
	[DataMember(Name = "InvoiceBatchID")]
	public long? InvoiceBatchID { get; set; }
}
