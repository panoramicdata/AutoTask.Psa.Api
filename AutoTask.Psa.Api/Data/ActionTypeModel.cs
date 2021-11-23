namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ActionTypeModel
/// </summary>
[DataContract]
public partial class ActionTypeModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string? Name { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets IsSystemActionType
	/// </summary>
	[DataMember(Name = "IsSystemActionType")]
	public bool? IsSystemActionType { get; set; }

	/// <summary>
	/// Gets or Sets View
	/// </summary>
	[DataMember(Name = "View")]
	public int? View { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField>? UserDefinedFields { get; set; }
}
