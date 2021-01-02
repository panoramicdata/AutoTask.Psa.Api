using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractBlockModel
	/// </summary>
	[DataContract]
	public partial class ContractBlockModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets DatePurchased
		/// </summary>
		[DataMember(Name = "DatePurchased", EmitDefaultValue = false)]
		public DateTime? DatePurchased { get; set; }

		/// <summary>
		/// Gets or Sets EndDate
		/// </summary>
		[DataMember(Name = "EndDate", EmitDefaultValue = false)]
		public DateTime? EndDate { get; set; }

		/// <summary>
		/// Gets or Sets HourlyRate
		/// </summary>
		[DataMember(Name = "HourlyRate", EmitDefaultValue = false)]
		public double? HourlyRate { get; set; }

		/// <summary>
		/// Gets or Sets Hours
		/// </summary>
		[DataMember(Name = "Hours", EmitDefaultValue = false)]
		public double? Hours { get; set; }

		/// <summary>
		/// Gets or Sets HoursApproved
		/// </summary>
		[DataMember(Name = "HoursApproved", EmitDefaultValue = false)]
		public double? HoursApproved { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceNumber
		/// </summary>
		[DataMember(Name = "InvoiceNumber", EmitDefaultValue = false)]
		public string InvoiceNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets IsPaid
		/// </summary>
		[DataMember(Name = "IsPaid", EmitDefaultValue = false)]
		public bool? IsPaid { get; set; }

		/// <summary>
		/// Gets or Sets PaymentNumber
		/// </summary>
		[DataMember(Name = "PaymentNumber", EmitDefaultValue = false)]
		public string PaymentNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets PaymentType
		/// </summary>
		[DataMember(Name = "PaymentType", EmitDefaultValue = false)]
		public int? PaymentType { get; set; }

		/// <summary>
		/// Gets or Sets StartDate
		/// </summary>
		[DataMember(Name = "StartDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
