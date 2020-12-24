using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TicketNoteModel
	/// </summary>
	[DataContract]
	public partial class TicketNoteModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TicketNoteModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CreateDateTime">CreateDateTime.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="ImpersonatorUpdaterResourceID">ImpersonatorUpdaterResourceID.</param>
		/// <param name="LastActivityDate">LastActivityDate.</param>
		/// <param name="NoteType">NoteType.</param>
		/// <param name="Publish">Publish.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="Title">Title.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TicketNoteModel(long? Id = default, DateTime? CreateDateTime = default, int? CreatorResourceID = default, string Description = default, int? ImpersonatorCreatorResourceID = default, int? ImpersonatorUpdaterResourceID = default, DateTime? LastActivityDate = default, int? NoteType = default, int? Publish = default, int? TicketID = default, string Title = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CreateDateTime = CreateDateTime;
			this.CreatorResourceID = CreatorResourceID;
			this.Description = Description;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.ImpersonatorUpdaterResourceID = ImpersonatorUpdaterResourceID;
			this.LastActivityDate = LastActivityDate;
			this.NoteType = NoteType;
			this.Publish = Publish;
			this.TicketID = TicketID;
			this.Title = Title;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CreateDateTime
		/// </summary>
		[DataMember(Name = "CreateDateTime", EmitDefaultValue = false)]
		public DateTime? CreateDateTime { get; set; }

		/// <summary>
		/// Gets or Sets CreatorResourceID
		/// </summary>
		[DataMember(Name = "CreatorResourceID", EmitDefaultValue = false)]
		public int? CreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorUpdaterResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorUpdaterResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorUpdaterResourceID { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityDate
		/// </summary>
		[DataMember(Name = "LastActivityDate", EmitDefaultValue = false)]
		public DateTime? LastActivityDate { get; set; }

		/// <summary>
		/// Gets or Sets NoteType
		/// </summary>
		[DataMember(Name = "NoteType", EmitDefaultValue = false)]
		public int? NoteType { get; set; }

		/// <summary>
		/// Gets or Sets Publish
		/// </summary>
		[DataMember(Name = "Publish", EmitDefaultValue = false)]
		public int? Publish { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncTicketNoteInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
