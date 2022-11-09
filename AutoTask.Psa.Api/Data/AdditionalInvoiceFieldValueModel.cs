namespace AutoTask.Psa.Api.Data;

/// <summary>
/// AdditionalInvoiceFieldValueModel
/// </summary>
[DataContract]
public class AdditionalInvoiceFieldValueModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
