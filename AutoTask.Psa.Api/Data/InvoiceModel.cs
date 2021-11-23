namespace AutoTask.Psa.Api.Data;

/// <summary>
/// InvoiceModel
/// </summary>
[DataContract]
public partial class InvoiceModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets BatchID
	/// </summary>
	[DataMember(Name = "BatchID")]
	public int? BatchID { get; set; }

	/// <summary>
	/// Gets or Sets Comments
	/// </summary>
	[DataMember(Name = "Comments")]
	public string Comments { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDateTime
	/// </summary>
	[DataMember(Name = "CreateDateTime")]
	public DateTime? CreateDateTime { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public int? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets DueDate
	/// </summary>
	[DataMember(Name = "DueDate")]
	public DateTime? DueDate { get; set; }

	/// <summary>
	/// Gets or Sets FromDate
	/// </summary>
	[DataMember(Name = "FromDate")]
	public DateTime? FromDate { get; set; }

	/// <summary>
	/// Gets or Sets InvoiceDateTime
	/// </summary>
	[DataMember(Name = "InvoiceDateTime")]
	public DateTime? InvoiceDateTime { get; set; }

	/// <summary>
	/// Gets or Sets InvoiceEditorTemplateID
	/// </summary>
	[DataMember(Name = "InvoiceEditorTemplateID")]
	public int? InvoiceEditorTemplateID { get; set; }

	/// <summary>
	/// Gets or Sets InvoiceNumber
	/// </summary>
	[DataMember(Name = "InvoiceNumber")]
	public string InvoiceNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets InvoiceTotal
	/// </summary>
	[DataMember(Name = "InvoiceTotal")]
	public double? InvoiceTotal { get; set; }

	/// <summary>
	/// Gets or Sets IsVoided
	/// </summary>
	[DataMember(Name = "IsVoided")]
	public bool? IsVoided { get; set; }

	/// <summary>
	/// Gets or Sets OrderNumber
	/// </summary>
	[DataMember(Name = "OrderNumber")]
	public string OrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets PaidDate
	/// </summary>
	[DataMember(Name = "PaidDate")]
	public DateTime? PaidDate { get; set; }

	/// <summary>
	/// Gets or Sets PaymentTerm
	/// </summary>
	[DataMember(Name = "PaymentTerm")]
	public int? PaymentTerm { get; set; }

	/// <summary>
	/// Gets or Sets TaxGroup
	/// </summary>
	[DataMember(Name = "TaxGroup")]
	public int? TaxGroup { get; set; }

	/// <summary>
	/// Gets or Sets TaxRegionName
	/// </summary>
	[DataMember(Name = "TaxRegionName")]
	public string TaxRegionName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ToDate
	/// </summary>
	[DataMember(Name = "ToDate")]
	public DateTime? ToDate { get; set; }

	/// <summary>
	/// Gets or Sets TotalTaxValue
	/// </summary>
	[DataMember(Name = "TotalTaxValue")]
	public double? TotalTaxValue { get; set; }

	/// <summary>
	/// Gets or Sets VoidedByResourceID
	/// </summary>
	[DataMember(Name = "VoidedByResourceID")]
	public int? VoidedByResourceID { get; set; }

	/// <summary>
	/// Gets or Sets VoidedDate
	/// </summary>
	[DataMember(Name = "VoidedDate")]
	public DateTime? VoidedDate { get; set; }

	/// <summary>
	/// Gets or Sets WebServiceDate
	/// </summary>
	[DataMember(Name = "WebServiceDate")]
	public DateTime? WebServiceDate { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
