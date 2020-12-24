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
		/// Initializes a new instance of the <see cref="TicketHistoryModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Action">Action.</param>
		/// <param name="Date">Date.</param>
		/// <param name="Detail">Detail.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TicketHistoryModel(long? Id = default, string Action = default, DateTime? Date = default, string Detail = default, int? ResourceID = default, int? TicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.Action = Action;
			this.Date = Date;
			this.Detail = Detail;
			this.ResourceID = ResourceID;
			this.TicketID = TicketID;
			this.UserDefinedFields = UserDefinedFields;
		}

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
