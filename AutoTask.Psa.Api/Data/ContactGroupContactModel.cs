namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContactGroupContactModel
/// </summary>
[DataContract]
public class ContactGroupContactModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ContactId
	/// </summary>
	[DataMember(Name = "ContactId")]
	public int? ContactId { get; set; }

	/// <summary>
	/// Gets or Sets ContactGroupId
	/// </summary>
	[DataMember(Name = "ContactGroupId")]
	public int? ContactGroupId { get; set; }
}
