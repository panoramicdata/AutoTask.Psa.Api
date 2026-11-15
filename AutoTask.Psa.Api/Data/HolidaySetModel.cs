namespace AutoTask.Psa.Api.Data;

/// <summary>
/// HolidaySetModel
/// </summary>
[DataContract]
public class HolidaySetModel : EntityModelBase
{
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
}
