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
		/// Initializes a new instance of the <see cref="ContractBlockModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="DatePurchased">DatePurchased.</param>
		/// <param name="EndDate">EndDate.</param>
		/// <param name="HourlyRate">HourlyRate.</param>
		/// <param name="Hours">Hours.</param>
		/// <param name="HoursApproved">HoursApproved.</param>
		/// <param name="InvoiceNumber">InvoiceNumber.</param>
		/// <param name="IsPaid">IsPaid.</param>
		/// <param name="PaymentNumber">PaymentNumber.</param>
		/// <param name="PaymentType">PaymentType.</param>
		/// <param name="StartDate">StartDate.</param>
		/// <param name="Status">Status.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractBlockModel(long? Id = default, int? ContractID = default, DateTime? DatePurchased = default, DateTime? EndDate = default, double? HourlyRate = default, double? Hours = default, double? HoursApproved = default, string InvoiceNumber = default, bool? IsPaid = default, string PaymentNumber = default, int? PaymentType = default, DateTime? StartDate = default, int? Status = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ContractID = ContractID;
			this.DatePurchased = DatePurchased;
			this.EndDate = EndDate;
			this.HourlyRate = HourlyRate;
			this.Hours = Hours;
			this.HoursApproved = HoursApproved;
			this.InvoiceNumber = InvoiceNumber;
			this.IsPaid = IsPaid;
			this.PaymentNumber = PaymentNumber;
			this.PaymentType = PaymentType;
			this.StartDate = StartDate;
			this.Status = Status;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		public string InvoiceNumber { get; set; }

		/// <summary>
		/// Gets or Sets IsPaid
		/// </summary>
		[DataMember(Name = "IsPaid", EmitDefaultValue = false)]
		public bool? IsPaid { get; set; }

		/// <summary>
		/// Gets or Sets PaymentNumber
		/// </summary>
		[DataMember(Name = "PaymentNumber", EmitDefaultValue = false)]
		public string PaymentNumber { get; set; }

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
		public ExpressionFuncContractBlockInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
