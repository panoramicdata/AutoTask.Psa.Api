using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TicketChecklistLibraryModel
	/// </summary>
	[DataContract]
	public partial class TicketChecklistLibraryModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TicketChecklistLibraryModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ChecklistLibraryID">ChecklistLibraryID.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TicketChecklistLibraryModel(long? Id = default, int? ChecklistLibraryID = default, int? TicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ChecklistLibraryID = ChecklistLibraryID;
			this.TicketID = TicketID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ChecklistLibraryID
		/// </summary>
		[DataMember(Name = "ChecklistLibraryID", EmitDefaultValue = false)]
		public int? ChecklistLibraryID { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncTicketChecklistLibraryInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
