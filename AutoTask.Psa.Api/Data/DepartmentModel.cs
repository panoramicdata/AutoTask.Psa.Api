namespace AutoTask.Psa.Api.Data;

/// <summary>
/// DepartmentModel
/// </summary>
[DataContract]
public partial class DepartmentModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Number
	/// </summary>
	[DataMember(Name = "Number")]
	public string Number { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets PrimaryLocationID
	/// </summary>
	[DataMember(Name = "PrimaryLocationID")]
	public int? PrimaryLocationID { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
