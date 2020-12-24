using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TicketChangeRequestApprovalModel
	/// </summary>
	[DataContract]
	public partial class TicketChangeRequestApprovalModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TicketChangeRequestApprovalModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ApproveRejectDateTime">ApproveRejectDateTime.</param>
		/// <param name="ApproveRejectNote">ApproveRejectNote.</param>
		/// <param name="ContactID">ContactID.</param>
		/// <param name="IsApproved">IsApproved.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TicketChangeRequestApprovalModel(long? Id = default, DateTime? ApproveRejectDateTime = default, string ApproveRejectNote = default, int? ContactID = default, bool? IsApproved = default, int? ResourceID = default, int? TicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ApproveRejectDateTime = ApproveRejectDateTime;
			this.ApproveRejectNote = ApproveRejectNote;
			this.ContactID = ContactID;
			this.IsApproved = IsApproved;
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
		/// Gets or Sets ApproveRejectDateTime
		/// </summary>
		[DataMember(Name = "ApproveRejectDateTime", EmitDefaultValue = false)]
		public DateTime? ApproveRejectDateTime { get; set; }

		/// <summary>
		/// Gets or Sets ApproveRejectNote
		/// </summary>
		[DataMember(Name = "ApproveRejectNote", EmitDefaultValue = false)]
		public string ApproveRejectNote { get; set; }

		/// <summary>
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public int? ContactID { get; set; }

		/// <summary>
		/// Gets or Sets IsApproved
		/// </summary>
		[DataMember(Name = "IsApproved", EmitDefaultValue = false)]
		public bool? IsApproved { get; set; }

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
		public ExpressionFuncTicketChangeRequestApprovalInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
