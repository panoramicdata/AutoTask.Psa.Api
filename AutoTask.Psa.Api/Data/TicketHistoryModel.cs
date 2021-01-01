using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TicketHistoryModel
	/// </summary>
	[DataContract]
	public partial class TicketHistoryModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets Action
		/// </summary>
		[DataMember(Name = "Action", EmitDefaultValue = false)]
		public string Action { get; set; }

		/// <summary>
		/// Gets or Sets Date
		/// </summary>
		[DataMember(Name = "Date", EmitDefaultValue = false)]
		public DateTime? Date { get; set; }

		/// <summary>
		/// Gets or Sets Detail
		/// </summary>
		[DataMember(Name = "Detail", EmitDefaultValue = false)]
		public string Detail { get; set; }

		/// <summary>
		/// Gets or Sets ResourceID
		/// </summary>
		[DataMember(Name = "ResourceID", EmitDefaultValue = false)]
		public int? ResourceID { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public long? SoapParentPropertyId { get; private set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
