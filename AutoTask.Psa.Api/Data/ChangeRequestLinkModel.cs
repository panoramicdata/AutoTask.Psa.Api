using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ChangeRequestLinkModel
	/// </summary>
	[DataContract]
	public partial class ChangeRequestLinkModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ChangeRequestLinkModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ChangeRequestTicketID">ChangeRequestTicketID.</param>
		/// <param name="ProblemOrIncidentTicketID">ProblemOrIncidentTicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ChangeRequestLinkModel(long? Id = default, int? ChangeRequestTicketID = default, int? ProblemOrIncidentTicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ChangeRequestTicketID = ChangeRequestTicketID;
			this.ProblemOrIncidentTicketID = ProblemOrIncidentTicketID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ChangeRequestTicketID
		/// </summary>
		[DataMember(Name = "ChangeRequestTicketID", EmitDefaultValue = false)]
		public int? ChangeRequestTicketID { get; set; }

		/// <summary>
		/// Gets or Sets ProblemOrIncidentTicketID
		/// </summary>
		[DataMember(Name = "ProblemOrIncidentTicketID", EmitDefaultValue = false)]
		public int? ProblemOrIncidentTicketID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
