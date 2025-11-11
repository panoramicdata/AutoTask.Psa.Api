namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ClientPortalUserModel
/// </summary>
[DataContract]
public class ClientPortalUserModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ContactID
	/// </summary>
	[DataMember(Name = "ContactID")]
	public int? ContactID { get; set; }

	/// <summary>
	/// Gets or Sets DateFormat
	/// </summary>
	[DataMember(Name = "DateFormat")]
	public int? DateFormat { get; set; }

	/// <summary>
	/// Gets or Sets IsClientPortalActive
	/// </summary>
	[DataMember(Name = "IsClientPortalActive")]
	public bool? IsClientPortalActive { get; set; }

	/// <summary>
	/// Gets or Sets NumberFormat
	/// </summary>
	[DataMember(Name = "NumberFormat")]
	public int? NumberFormat { get; set; }

	/// <summary>
	/// Gets or Sets Password
	/// </summary>
	[DataMember(Name = "Password")]
	public string Password { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SecurityLevel
	/// </summary>
	[DataMember(Name = "SecurityLevel")]
	public int? SecurityLevel { get; set; }

	/// <summary>
	/// Gets or Sets TimeFormat
	/// </summary>
	[DataMember(Name = "TimeFormat")]
	public int? TimeFormat { get; set; }

	/// <summary>
	/// Gets or Sets UserName
	/// </summary>
	[DataMember(Name = "UserName")]
	public string UserName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
