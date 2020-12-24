using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TicketRmaCreditModel
	/// </summary>
	[DataContract]
	public partial class TicketRmaCreditModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TicketRmaCreditModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CreditAmount">CreditAmount.</param>
		/// <param name="CreditDetails">CreditDetails.</param>
		/// <param name="InternalCurrencyCreditAmount">InternalCurrencyCreditAmount.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TicketRmaCreditModel(long? Id = default, double? CreditAmount = default, string CreditDetails = default, double? InternalCurrencyCreditAmount = default, int? TicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CreditAmount = CreditAmount;
			this.CreditDetails = CreditDetails;
			this.InternalCurrencyCreditAmount = InternalCurrencyCreditAmount;
			this.TicketID = TicketID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CreditAmount
		/// </summary>
		[DataMember(Name = "CreditAmount", EmitDefaultValue = false)]
		public double? CreditAmount { get; set; }

		/// <summary>
		/// Gets or Sets CreditDetails
		/// </summary>
		[DataMember(Name = "CreditDetails", EmitDefaultValue = false)]
		public string CreditDetails { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyCreditAmount
		/// </summary>
		[DataMember(Name = "InternalCurrencyCreditAmount", EmitDefaultValue = false)]
		public double? InternalCurrencyCreditAmount { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncTicketRmaCreditInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
