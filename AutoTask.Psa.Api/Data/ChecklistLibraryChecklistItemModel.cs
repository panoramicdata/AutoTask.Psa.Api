using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ChecklistLibraryChecklistItemModel
	/// </summary>
	[DataContract]
	public partial class ChecklistLibraryChecklistItemModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ChecklistLibraryChecklistItemModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ChecklistLibraryID">ChecklistLibraryID.</param>
		/// <param name="IsImportant">IsImportant.</param>
		/// <param name="ItemName">ItemName.</param>
		/// <param name="KnowledgebaseArticleID">KnowledgebaseArticleID.</param>
		/// <param name="Position">Position.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ChecklistLibraryChecklistItemModel(long? Id = default, int? ChecklistLibraryID = default, bool? IsImportant = default, string ItemName = default, int? KnowledgebaseArticleID = default, int? Position = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ChecklistLibraryID = ChecklistLibraryID;
			this.IsImportant = IsImportant;
			this.ItemName = ItemName;
			this.KnowledgebaseArticleID = KnowledgebaseArticleID;
			this.Position = Position;
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
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncChecklistLibraryChecklistItemInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
