using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractRetainerModel
	/// </summary>
	[DataContract]
	public partial class ContractRetainerModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractRetainerModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Amount">Amount.</param>
		/// <param name="AmountApproved">AmountApproved.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="DatePurchased">DatePurchased.</param>
		/// <param name="EndDate">EndDate.</param>
		/// <param name="InternalCurrencyAmount">InternalCurrencyAmount.</param>
		/// <param name="InternalCurrencyAmountApproved">InternalCurrencyAmountApproved.</param>
		/// <param name="InvoiceNumber">InvoiceNumber.</param>
		/// <param name="IsPaid">IsPaid.</param>
		/// <param name="PaymentID">PaymentID.</param>
		/// <param name="PaymentNumber">PaymentNumber.</param>
		/// <param name="StartDate">StartDate.</param>
		/// <param name="Status">Status.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractRetainerModel(long? Id = default, double? Amount = default, double? AmountApproved = default, int? ContractID = default, DateTime? DatePurchased = default, DateTime? EndDate = default, double? InternalCurrencyAmount = default, double? InternalCurrencyAmountApproved = default, string InvoiceNumber = default, bool? IsPaid = default, int? PaymentID = default, string PaymentNumber = default, DateTime? StartDate = default, int? Status = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.Amount = Amount;
			this.AmountApproved = AmountApproved;
			this.ContractID = ContractID;
			this.DatePurchased = DatePurchased;
			this.EndDate = EndDate;
			this.InternalCurrencyAmount = InternalCurrencyAmount;
			this.InternalCurrencyAmountApproved = InternalCurrencyAmountApproved;
			this.InvoiceNumber = InvoiceNumber;
			this.IsPaid = IsPaid;
			this.PaymentID = PaymentID;
			this.PaymentNumber = PaymentNumber;
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
		/// Gets or Sets Amount
		/// </summary>
		[DataMember(Name = "Amount", EmitDefaultValue = false)]
		public double? Amount { get; set; }

		/// <summary>
		/// Gets or Sets AmountApproved
		/// </summary>
		[DataMember(Name = "AmountApproved", EmitDefaultValue = false)]
		public double? AmountApproved { get; set; }

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
		/// Gets or Sets InternalCurrencyAmount
		/// </summary>
		[DataMember(Name = "InternalCurrencyAmount", EmitDefaultValue = false)]
		public double? InternalCurrencyAmount { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyAmountApproved
		/// </summary>
		[DataMember(Name = "InternalCurrencyAmountApproved", EmitDefaultValue = false)]
		public double? InternalCurrencyAmountApproved { get; set; }

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
		/// Gets or Sets PaymentID
		/// </summary>
		[DataMember(Name = "PaymentID", EmitDefaultValue = false)]
		public int? PaymentID { get; set; }

		/// <summary>
		/// Gets or Sets PaymentNumber
		/// </summary>
		[DataMember(Name = "PaymentNumber", EmitDefaultValue = false)]
		public string PaymentNumber { get; set; }

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
		public ExpressionFuncContractRetainerInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
