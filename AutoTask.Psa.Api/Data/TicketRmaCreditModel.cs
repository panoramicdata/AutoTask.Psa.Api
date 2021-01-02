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
		public string CreditDetails { get; set; } = string.Empty;

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
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
