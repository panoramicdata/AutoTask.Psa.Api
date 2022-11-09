namespace AutoTask.Psa.Api.Data;

/// <summary>
/// AttachmentInfoModel
/// </summary>
[DataContract]
public class AttachmentInfoModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AttachDate
	/// </summary>
	[DataMember(Name = "AttachDate")]
	public DateTime? AttachDate { get; set; }

	/// <summary>
	/// Gets or Sets AttachedByContactID
	/// </summary>
	[DataMember(Name = "AttachedByContactID")]
	public long? AttachedByContactID { get; set; }

	/// <summary>
	/// Gets or Sets AttachedByResourceID
	/// </summary>
	[DataMember(Name = "AttachedByResourceID")]
	public long? AttachedByResourceID { get; set; }

	/// <summary>
	/// Gets or Sets AttachmentType
	/// </summary>
	[DataMember(Name = "AttachmentType")]
	public string AttachmentType { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ContentType
	/// </summary>
	[DataMember(Name = "ContentType")]
	public string ContentType { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets FileSize
	/// </summary>
	[DataMember(Name = "FileSize")]
	public double? FileSize { get; set; }

	/// <summary>
	/// Gets or Sets FullPath
	/// </summary>
	[DataMember(Name = "FullPath")]
	public string FullPath { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets OpportunityID
	/// </summary>
	[DataMember(Name = "OpportunityID")]
	public long? OpportunityID { get; set; }

	/// <summary>
	/// Gets or Sets ParentID
	/// </summary>
	[DataMember(Name = "ParentID")]
	public long? ParentID { get; set; }

	/// <summary>
	/// Gets or Sets ParentType
	/// </summary>
	[DataMember(Name = "ParentType")]
	public int? ParentType { get; set; }

	/// <summary>
	/// Gets or Sets Publish
	/// </summary>
	[DataMember(Name = "Publish")]
	public int? Publish { get; set; }

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "Title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public long? SoapParentPropertyId { get; private set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
