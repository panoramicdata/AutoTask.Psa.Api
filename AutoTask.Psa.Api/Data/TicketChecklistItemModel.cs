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
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CompletedByResourceID
		/// </summary>
		[DataMember(Name = "CompletedByResourceID")]
		public int? CompletedByResourceID { get; set; }

		/// <summary>
		/// Gets or Sets CompletedDateTime
		/// </summary>
		[DataMember(Name = "CompletedDateTime")]
		public DateTime? CompletedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets IsCompleted
		/// </summary>
		[DataMember(Name = "IsCompleted")]
		public bool? IsCompleted { get; set; }

		/// <summary>
		/// Gets or Sets IsImportant
		/// </summary>
		[DataMember(Name = "IsImportant")]
		public bool? IsImportant { get; set; }

		/// <summary>
		/// Gets or Sets ItemName
		/// </summary>
		[DataMember(Name = "ItemName")]
		public string ItemName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets KnowledgebaseArticleID
		/// </summary>
		[DataMember(Name = "KnowledgebaseArticleID")]
		public int? KnowledgebaseArticleID { get; set; }

		/// <summary>
		/// Gets or Sets Position
		/// </summary>
		[DataMember(Name = "Position")]
		public int? Position { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID")]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId")]
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
