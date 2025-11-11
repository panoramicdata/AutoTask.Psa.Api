namespace AutoTask.Psa.Api.Data;

/// <summary>
/// HolidaySetModel
/// </summary>
[DataContract]
public class HolidaySetModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets HolidaySetDescription
	/// </summary>
	[DataMember(Name = "HolidaySetDescription")]
	public string HolidaySetDescription { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets HolidaySetName
	/// </summary>
	[DataMember(Name = "HolidaySetName")]
	public string HolidaySetName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
