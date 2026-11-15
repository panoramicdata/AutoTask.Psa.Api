namespace AutoTask.Psa.Api.Data;

/// <summary>
/// HolidayModel
/// </summary>
[DataContract]
public class HolidayModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets HolidayDate
	/// </summary>
	[DataMember(Name = "HolidayDate")]
	public DateTime? HolidayDate { get; set; }

	/// <summary>
	/// Gets or Sets HolidayName
	/// </summary>
	[DataMember(Name = "HolidayName")]
	public string HolidayName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets HolidaySetID
	/// </summary>
	[DataMember(Name = "HolidaySetID")]
	public int? HolidaySetID { get; set; }
}
