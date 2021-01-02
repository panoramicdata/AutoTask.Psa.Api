using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// InvoiceModel
	/// </summary>
	[DataContract]
	public partial class InvoiceModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BatchID
		/// </summary>
		[DataMember(Name = "BatchID", EmitDefaultValue = false)]
		public int? BatchID { get; set; }

		/// <summary>
		/// Gets or Sets Comments
		/// </summary>
		[DataMember(Name = "Comments", EmitDefaultValue = false)]
		public string Comments { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDateTime
		/// </summary>
		[DataMember(Name = "CreateDateTime", EmitDefaultValue = false)]
		public DateTime? CreateDateTime { get; set; }

		/// <summary>
		/// Gets or Sets CreatorResourceID
		/// </summary>
		[DataMember(Name = "CreatorResourceID", EmitDefaultValue = false)]
		public int? CreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets DueDate
		/// </summary>
		[DataMember(Name = "DueDate", EmitDefaultValue = false)]
		public DateTime? DueDate { get; set; }

		/// <summary>
		/// Gets or Sets FromDate
		/// </summary>
		[DataMember(Name = "FromDate", EmitDefaultValue = false)]
		public DateTime? FromDate { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceDateTime
		/// </summary>
		[DataMember(Name = "InvoiceDateTime", EmitDefaultValue = false)]
		public DateTime? InvoiceDateTime { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceEditorTemplateID
		/// </summary>
		[DataMember(Name = "InvoiceEditorTemplateID", EmitDefaultValue = false)]
		public int? InvoiceEditorTemplateID { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceNumber
		/// </summary>
		[DataMember(Name = "InvoiceNumber", EmitDefaultValue = false)]
		public string InvoiceNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets InvoiceTotal
		/// </summary>
		[DataMember(Name = "InvoiceTotal", EmitDefaultValue = false)]
		public double? InvoiceTotal { get; set; }

		/// <summary>
		/// Gets or Sets IsVoided
		/// </summary>
		[DataMember(Name = "IsVoided", EmitDefaultValue = false)]
		public bool? IsVoided { get; set; }

		/// <summary>
		/// Gets or Sets OrderNumber
		/// </summary>
		[DataMember(Name = "OrderNumber", EmitDefaultValue = false)]
		public string OrderNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets PaidDate
		/// </summary>
		[DataMember(Name = "PaidDate", EmitDefaultValue = false)]
		public DateTime? PaidDate { get; set; }

		/// <summary>
		/// Gets or Sets PaymentTerm
		/// </summary>
		[DataMember(Name = "PaymentTerm", EmitDefaultValue = false)]
		public int? PaymentTerm { get; set; }

		/// <summary>
		/// Gets or Sets TaxGroup
		/// </summary>
		[DataMember(Name = "TaxGroup", EmitDefaultValue = false)]
		public int? TaxGroup { get; set; }

		/// <summary>
		/// Gets or Sets TaxRegionName
		/// </summary>
		[DataMember(Name = "TaxRegionName", EmitDefaultValue = false)]
		public string TaxRegionName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ToDate
		/// </summary>
		[DataMember(Name = "ToDate", EmitDefaultValue = false)]
		public DateTime? ToDate { get; set; }

		/// <summary>
		/// Gets or Sets TotalTaxValue
		/// </summary>
		[DataMember(Name = "TotalTaxValue", EmitDefaultValue = false)]
		public double? TotalTaxValue { get; set; }

		/// <summary>
		/// Gets or Sets VoidedByResourceID
		/// </summary>
		[DataMember(Name = "VoidedByResourceID", EmitDefaultValue = false)]
		public int? VoidedByResourceID { get; set; }

		/// <summary>
		/// Gets or Sets VoidedDate
		/// </summary>
		[DataMember(Name = "VoidedDate", EmitDefaultValue = false)]
		public DateTime? VoidedDate { get; set; }

		/// <summary>
		/// Gets or Sets WebServiceDate
		/// </summary>
		[DataMember(Name = "WebServiceDate", EmitDefaultValue = false)]
		public DateTime? WebServiceDate { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
