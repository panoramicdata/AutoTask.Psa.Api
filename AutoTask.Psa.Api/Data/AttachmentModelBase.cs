namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Fields shared by every attachment entity. AutoTask models attachments identically whatever they hang off, so the shape lives here once.
/// </summary>
[DataContract]
public abstract class AttachmentModelBase : AttachmentCoreModelBase
{
	/// <summary>
	/// Gets or Sets Data
	/// </summary>
	[DataMember(Name = "Data")]
	public byte[]? Data { get; set; }

	/// <summary>
	/// Gets or Sets ParentType
	/// </summary>
	[DataMember(Name = "ParentType")]
	public int? ParentType { get; private set; }

	/// <summary>
	/// Gets or Sets IsTaskAttachment
	/// </summary>
	[DataMember(Name = "IsTaskAttachment")]
	public bool? IsTaskAttachment { get; private set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }
}
