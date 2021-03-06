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
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
