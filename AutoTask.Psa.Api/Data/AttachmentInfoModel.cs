namespace AutoTask.Psa.Api.Data;

/// <summary>
/// AttachmentInfoModel
/// </summary>
[DataContract]
public class AttachmentInfoModel : AttachmentCoreModelBase
{
	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];

	/// <summary>
	/// Gets or Sets ParentType
	/// </summary>
	[DataMember(Name = "ParentType")]
	public int? ParentType { get; set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public long? SoapParentPropertyId { get; private set; }
}
