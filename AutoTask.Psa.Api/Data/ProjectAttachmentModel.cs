using System;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ProjectAttachmentModel
	/// </summary>
	[DataContract]
	public partial class ProjectAttachmentModel
	{
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
		public string AttachmentType { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ContentType
		/// </summary>
		[DataMember(Name = "ContentType", EmitDefaultValue = false)]
		public string ContentType { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets FileSize
		/// </summary>
		[DataMember(Name = "FileSize", EmitDefaultValue = false)]
		public double? FileSize { get; set; }

		/// <summary>
		/// Gets or Sets FullPath
		/// </summary>
		[DataMember(Name = "FullPath", EmitDefaultValue = false)]
		public string FullPath { get; set; } = string.Empty;

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
		/// Gets or Sets Publish
		/// </summary>
		[DataMember(Name = "Publish", EmitDefaultValue = false)]
		public int? Publish { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name = "Data", EmitDefaultValue = false)]
		public byte[] Data { get; set; }

		/// <summary>
		/// Gets or Sets ParentType
		/// </summary>
		[DataMember(Name = "ParentType", EmitDefaultValue = false)]
		public int? ParentType { get; private set; }

		/// <summary>
		/// Gets or Sets IsTaskAttachment
		/// </summary>
		[DataMember(Name = "IsTaskAttachment", EmitDefaultValue = false)]
		public bool? IsTaskAttachment { get; private set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFunc? SoapParentPropertyId { get; set; }
	}
}
