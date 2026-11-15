namespace AutoTask.Psa.Api.Data;

/// <summary>
/// DepartmentModel
/// </summary>
[DataContract]
public class DepartmentModel : EntityModelBase
{
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
}
