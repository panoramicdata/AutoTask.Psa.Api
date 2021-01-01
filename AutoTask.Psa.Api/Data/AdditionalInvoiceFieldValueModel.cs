using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// AdditionalInvoiceFieldValueModel
	/// </summary>
	[DataContract]
	public partial class AdditionalInvoiceFieldValueModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AdditionalInvoiceFieldID
		/// </summary>
		[DataMember(Name = "AdditionalInvoiceFieldID", EmitDefaultValue = false)]
		public long? AdditionalInvoiceFieldID { get; set; }

		/// <summary>
		/// Gets or Sets FieldValue
		/// </summary>
		[DataMember(Name = "FieldValue", EmitDefaultValue = false)]
		public string FieldValue { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceBatchID
		/// </summary>
		[DataMember(Name = "InvoiceBatchID", EmitDefaultValue = false)]
		public long? InvoiceBatchID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
