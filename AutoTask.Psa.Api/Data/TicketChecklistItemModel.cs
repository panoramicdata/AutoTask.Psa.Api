using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TicketChecklistItemModel
	/// </summary>
	[DataContract]
	public partial class TicketChecklistItemModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TicketChecklistItemModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CompletedByResourceID">CompletedByResourceID.</param>
		/// <param name="CompletedDateTime">CompletedDateTime.</param>
		/// <param name="IsCompleted">IsCompleted.</param>
		/// <param name="IsImportant">IsImportant.</param>
		/// <param name="ItemName">ItemName.</param>
		/// <param name="KnowledgebaseArticleID">KnowledgebaseArticleID.</param>
		/// <param name="Position">Position.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TicketChecklistItemModel(long? Id = default, int? CompletedByResourceID = default, DateTime? CompletedDateTime = default, bool? IsCompleted = default, bool? IsImportant = default, string ItemName = default, int? KnowledgebaseArticleID = default, int? Position = default, int? TicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CompletedByResourceID = CompletedByResourceID;
			this.CompletedDateTime = CompletedDateTime;
			this.IsCompleted = IsCompleted;
			this.IsImportant = IsImportant;
			this.ItemName = ItemName;
			this.KnowledgebaseArticleID = KnowledgebaseArticleID;
			this.Position = Position;
			this.TicketID = TicketID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CompletedByResourceID
		/// </summary>
		[DataMember(Name = "CompletedByResourceID", EmitDefaultValue = false)]
		public int? CompletedByResourceID { get; set; }

		/// <summary>
		/// Gets or Sets CompletedDateTime
		/// </summary>
		[DataMember(Name = "CompletedDateTime", EmitDefaultValue = false)]
		public DateTime? CompletedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets IsCompleted
		/// </summary>
		[DataMember(Name = "IsCompleted", EmitDefaultValue = false)]
		public bool? IsCompleted { get; set; }

		/// <summary>
		/// Gets or Sets IsImportant
		/// </summary>
		[DataMember(Name = "IsImportant", EmitDefaultValue = false)]
		public bool? IsImportant { get; set; }

		/// <summary>
		/// Gets or Sets ItemName
		/// </summary>
		[DataMember(Name = "ItemName", EmitDefaultValue = false)]
		public string ItemName { get; set; }

		/// <summary>
		/// Gets or Sets KnowledgebaseArticleID
		/// </summary>
		[DataMember(Name = "KnowledgebaseArticleID", EmitDefaultValue = false)]
		public int? KnowledgebaseArticleID { get; set; }

		/// <summary>
		/// Gets or Sets Position
		/// </summary>
		[DataMember(Name = "Position", EmitDefaultValue = false)]
		public int? Position { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncTicketChecklistItemInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
