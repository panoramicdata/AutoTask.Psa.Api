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
		/// Initializes a new instance of the <see cref="InvoiceModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BatchID">BatchID.</param>
		/// <param name="Comments">Comments.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="CreateDateTime">CreateDateTime.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="DueDate">DueDate.</param>
		/// <param name="FromDate">FromDate.</param>
		/// <param name="InvoiceDateTime">InvoiceDateTime.</param>
		/// <param name="InvoiceEditorTemplateID">InvoiceEditorTemplateID.</param>
		/// <param name="InvoiceNumber">InvoiceNumber.</param>
		/// <param name="InvoiceTotal">InvoiceTotal.</param>
		/// <param name="IsVoided">IsVoided.</param>
		/// <param name="OrderNumber">OrderNumber.</param>
		/// <param name="PaidDate">PaidDate.</param>
		/// <param name="PaymentTerm">PaymentTerm.</param>
		/// <param name="TaxGroup">TaxGroup.</param>
		/// <param name="TaxRegionName">TaxRegionName.</param>
		/// <param name="ToDate">ToDate.</param>
		/// <param name="TotalTaxValue">TotalTaxValue.</param>
		/// <param name="VoidedByResourceID">VoidedByResourceID.</param>
		/// <param name="VoidedDate">VoidedDate.</param>
		/// <param name="WebServiceDate">WebServiceDate.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public InvoiceModel(long? Id = default, int? BatchID = default, string Comments = default, int? CompanyID = default, DateTime? CreateDateTime = default, int? CreatorResourceID = default, DateTime? DueDate = default, DateTime? FromDate = default, DateTime? InvoiceDateTime = default, int? InvoiceEditorTemplateID = default, string InvoiceNumber = default, double? InvoiceTotal = default, bool? IsVoided = default, string OrderNumber = default, DateTime? PaidDate = default, int? PaymentTerm = default, int? TaxGroup = default, string TaxRegionName = default, DateTime? ToDate = default, double? TotalTaxValue = default, int? VoidedByResourceID = default, DateTime? VoidedDate = default, DateTime? WebServiceDate = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BatchID = BatchID;
			this.Comments = Comments;
			this.CompanyID = CompanyID;
			this.CreateDateTime = CreateDateTime;
			this.CreatorResourceID = CreatorResourceID;
			this.DueDate = DueDate;
			this.FromDate = FromDate;
			this.InvoiceDateTime = InvoiceDateTime;
			this.InvoiceEditorTemplateID = InvoiceEditorTemplateID;
			this.InvoiceNumber = InvoiceNumber;
			this.InvoiceTotal = InvoiceTotal;
			this.IsVoided = IsVoided;
			this.OrderNumber = OrderNumber;
			this.PaidDate = PaidDate;
			this.PaymentTerm = PaymentTerm;
			this.TaxGroup = TaxGroup;
			this.TaxRegionName = TaxRegionName;
			this.ToDate = ToDate;
			this.TotalTaxValue = TotalTaxValue;
			this.VoidedByResourceID = VoidedByResourceID;
			this.VoidedDate = VoidedDate;
			this.WebServiceDate = WebServiceDate;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		public string Comments { get; set; }

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
		public string InvoiceNumber { get; set; }

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
		public string OrderNumber { get; set; }

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
		public string TaxRegionName { get; set; }

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
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
