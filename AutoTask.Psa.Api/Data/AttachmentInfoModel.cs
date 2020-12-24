using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// AttachmentInfoModel
	/// </summary>
	[DataContract]
	public partial class AttachmentInfoModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AttachmentInfoModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AttachDate">AttachDate.</param>
		/// <param name="AttachedByContactID">AttachedByContactID.</param>
		/// <param name="AttachedByResourceID">AttachedByResourceID.</param>
		/// <param name="AttachmentType">AttachmentType.</param>
		/// <param name="ContentType">ContentType.</param>
		/// <param name="FileSize">FileSize.</param>
		/// <param name="FullPath">FullPath.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="OpportunityID">OpportunityID.</param>
		/// <param name="ParentID">ParentID.</param>
		/// <param name="ParentType">ParentType.</param>
		/// <param name="Publish">Publish.</param>
		/// <param name="Title">Title.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public AttachmentInfoModel(long? Id = default, DateTime? AttachDate = default, long? AttachedByContactID = default, long? AttachedByResourceID = default, string AttachmentType = default, string ContentType = default, double? FileSize = default, string FullPath = default, int? ImpersonatorCreatorResourceID = default, long? OpportunityID = default, long? ParentID = default, int? ParentType = default, int? Publish = default, string Title = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AttachDate = AttachDate;
			this.AttachedByContactID = AttachedByContactID;
			this.AttachedByResourceID = AttachedByResourceID;
			this.AttachmentType = AttachmentType;
			this.ContentType = ContentType;
			this.FileSize = FileSize;
			this.FullPath = FullPath;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.OpportunityID = OpportunityID;
			this.ParentID = ParentID;
			this.ParentType = ParentType;
			this.Publish = Publish;
			this.Title = Title;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AttachDate
		/// </summary>
		[DataMember(Name = "AttachDate", EmitDefaultValue = false)]
		public DateTime? AttachDate { get; set; }

		/// <summary>
		/// Gets or Sets AttachedByContactID
		/// </summary>
		[DataMember(Name = "AttachedByContactID", EmitDefaultValue = false)]
		public long? AttachedByContactID { get; set; }

		/// <summary>
		/// Gets or Sets AttachedByResourceID
		/// </summary>
		[DataMember(Name = "AttachedByResourceID", EmitDefaultValue = false)]
		public long? AttachedByResourceID { get; set; }

		/// <summary>
		/// Gets or Sets AttachmentType
		/// </summary>
		[DataMember(Name = "AttachmentType", EmitDefaultValue = false)]
		public string AttachmentType { get; set; }

		/// <summary>
		/// Gets or Sets ContentType
		/// </summary>
		[DataMember(Name = "ContentType", EmitDefaultValue = false)]
		public string ContentType { get; set; }

		/// <summary>
		/// Gets or Sets FileSize
		/// </summary>
		[DataMember(Name = "FileSize", EmitDefaultValue = false)]
		public double? FileSize { get; set; }

		/// <summary>
		/// Gets or Sets FullPath
		/// </summary>
		[DataMember(Name = "FullPath", EmitDefaultValue = false)]
		public string FullPath { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets OpportunityID
		/// </summary>
		[DataMember(Name = "OpportunityID", EmitDefaultValue = false)]
		public long? OpportunityID { get; set; }

		/// <summary>
		/// Gets or Sets ParentID
		/// </summary>
		[DataMember(Name = "ParentID", EmitDefaultValue = false)]
		public long? ParentID { get; set; }

		/// <summary>
		/// Gets or Sets ParentType
		/// </summary>
		[DataMember(Name = "ParentType", EmitDefaultValue = false)]
		public int? ParentType { get; set; }

		/// <summary>
		/// Gets or Sets Publish
		/// </summary>
		[DataMember(Name = "Publish", EmitDefaultValue = false)]
		public int? Publish { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public long? SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
