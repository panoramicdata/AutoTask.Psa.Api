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
		public string ItemName { get; set; } = string.Empty;

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
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
