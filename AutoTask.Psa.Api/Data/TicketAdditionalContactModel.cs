using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TicketAdditionalContactModel
	/// </summary>
	[DataContract]
	public partial class TicketAdditionalContactModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TicketAdditionalContactModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ContactID">ContactID.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TicketAdditionalContactModel(long? Id = default, int? ContactID = default, int? TicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ContactID = ContactID;
			this.TicketID = TicketID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public int? ContactID { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncTicketAdditionalContactInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
