namespace AutoTask.Psa.Api.Data;

/// <summary>
/// InternalLocationWithBusinessHoursModel
/// </summary>
[DataContract]
public class InternalLocationWithBusinessHoursModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AdditionalAddressInfo
	/// </summary>
	[DataMember(Name = "AdditionalAddressInfo")]
	public string AdditionalAddressInfo { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Address1
	/// </summary>
	[DataMember(Name = "Address1")]
	public string Address1 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Address2
	/// </summary>
	[DataMember(Name = "Address2")]
	public string Address2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets City
	/// </summary>
	[DataMember(Name = "City")]
	public string City { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CountryID
	/// </summary>
	[DataMember(Name = "CountryID")]
	public int? CountryID { get; set; }

	/// <summary>
	/// Gets or Sets DateFormat
	/// </summary>
	[DataMember(Name = "DateFormat")]
	public string DateFormat { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets FirstDayOfWeek
	/// </summary>
	[DataMember(Name = "FirstDayOfWeek")]
	public int? FirstDayOfWeek { get; set; }

	/// <summary>
	/// Gets or Sets FridayBusinessHoursEndTime
	/// </summary>
	[DataMember(Name = "FridayBusinessHoursEndTime")]
	public DateTime? FridayBusinessHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets FridayBusinessHoursStartTime
	/// </summary>
	[DataMember(Name = "FridayBusinessHoursStartTime")]
	public DateTime? FridayBusinessHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets FridayExtendedHoursEndTime
	/// </summary>
	[DataMember(Name = "FridayExtendedHoursEndTime")]
	public DateTime? FridayExtendedHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets FridayExtendedHoursStartTime
	/// </summary>
	[DataMember(Name = "FridayExtendedHoursStartTime")]
	public DateTime? FridayExtendedHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets HolidayExtendedHoursEndTime
	/// </summary>
	[DataMember(Name = "HolidayExtendedHoursEndTime")]
	public DateTime? HolidayExtendedHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets HolidayExtendedHoursStartTime
	/// </summary>
	[DataMember(Name = "HolidayExtendedHoursStartTime")]
	public DateTime? HolidayExtendedHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets HolidayHoursEndTime
	/// </summary>
	[DataMember(Name = "HolidayHoursEndTime")]
	public DateTime? HolidayHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets HolidayHoursStartTime
	/// </summary>
	[DataMember(Name = "HolidayHoursStartTime")]
	public DateTime? HolidayHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets HolidayHoursType
	/// </summary>
	[DataMember(Name = "HolidayHoursType")]
	public int? HolidayHoursType { get; set; }

	/// <summary>
	/// Gets or Sets HolidaySetID
	/// </summary>
	[DataMember(Name = "HolidaySetID")]
	public int? HolidaySetID { get; set; }

	/// <summary>
	/// Gets or Sets IsDefault
	/// </summary>
	[DataMember(Name = "IsDefault")]
	public bool? IsDefault { get; set; }

	/// <summary>
	/// Gets or Sets MondayBusinessHoursEndTime
	/// </summary>
	[DataMember(Name = "MondayBusinessHoursEndTime")]
	public DateTime? MondayBusinessHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets MondayBusinessHoursStartTime
	/// </summary>
	[DataMember(Name = "MondayBusinessHoursStartTime")]
	public DateTime? MondayBusinessHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets MondayExtendedHoursEndTime
	/// </summary>
	[DataMember(Name = "MondayExtendedHoursEndTime")]
	public DateTime? MondayExtendedHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets MondayExtendedHoursStartTime
	/// </summary>
	[DataMember(Name = "MondayExtendedHoursStartTime")]
	public DateTime? MondayExtendedHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets NoHoursOnHolidays
	/// </summary>
	[DataMember(Name = "NoHoursOnHolidays")]
	public bool? NoHoursOnHolidays { get; set; }

	/// <summary>
	/// Gets or Sets NumberFormat
	/// </summary>
	[DataMember(Name = "NumberFormat")]
	public string NumberFormat { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets PostalCode
	/// </summary>
	[DataMember(Name = "PostalCode")]
	public string PostalCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SaturdayBusinessHoursEndTime
	/// </summary>
	[DataMember(Name = "SaturdayBusinessHoursEndTime")]
	public DateTime? SaturdayBusinessHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets SaturdayBusinessHoursStartTime
	/// </summary>
	[DataMember(Name = "SaturdayBusinessHoursStartTime")]
	public DateTime? SaturdayBusinessHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets SaturdayExtendedHoursEndTime
	/// </summary>
	[DataMember(Name = "SaturdayExtendedHoursEndTime")]
	public DateTime? SaturdayExtendedHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets SaturdayExtendedHoursStartTime
	/// </summary>
	[DataMember(Name = "SaturdayExtendedHoursStartTime")]
	public DateTime? SaturdayExtendedHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets State
	/// </summary>
	[DataMember(Name = "State")]
	public string State { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SundayBusinessHoursEndTime
	/// </summary>
	[DataMember(Name = "SundayBusinessHoursEndTime")]
	public DateTime? SundayBusinessHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets SundayBusinessHoursStartTime
	/// </summary>
	[DataMember(Name = "SundayBusinessHoursStartTime")]
	public DateTime? SundayBusinessHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets SundayExtendedHoursEndTime
	/// </summary>
	[DataMember(Name = "SundayExtendedHoursEndTime")]
	public DateTime? SundayExtendedHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets SundayExtendedHoursStartTime
	/// </summary>
	[DataMember(Name = "SundayExtendedHoursStartTime")]
	public DateTime? SundayExtendedHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets ThursdayBusinessHoursEndTime
	/// </summary>
	[DataMember(Name = "ThursdayBusinessHoursEndTime")]
	public DateTime? ThursdayBusinessHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets ThursdayBusinessHoursStartTime
	/// </summary>
	[DataMember(Name = "ThursdayBusinessHoursStartTime")]
	public DateTime? ThursdayBusinessHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets ThursdayExtendedHoursEndTime
	/// </summary>
	[DataMember(Name = "ThursdayExtendedHoursEndTime")]
	public DateTime? ThursdayExtendedHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets ThursdayExtendedHoursStartTime
	/// </summary>
	[DataMember(Name = "ThursdayExtendedHoursStartTime")]
	public DateTime? ThursdayExtendedHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets TimeFormat
	/// </summary>
	[DataMember(Name = "TimeFormat")]
	public string TimeFormat { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TimeZoneID
	/// </summary>
	[DataMember(Name = "TimeZoneID")]
	public int? TimeZoneID { get; set; }

	/// <summary>
	/// Gets or Sets TuesdayBusinessHoursEndTime
	/// </summary>
	[DataMember(Name = "TuesdayBusinessHoursEndTime")]
	public DateTime? TuesdayBusinessHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets TuesdayBusinessHoursStartTime
	/// </summary>
	[DataMember(Name = "TuesdayBusinessHoursStartTime")]
	public DateTime? TuesdayBusinessHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets TuesdayExtendedHoursEndTime
	/// </summary>
	[DataMember(Name = "TuesdayExtendedHoursEndTime")]
	public DateTime? TuesdayExtendedHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets TuesdayExtendedHoursStartTime
	/// </summary>
	[DataMember(Name = "TuesdayExtendedHoursStartTime")]
	public DateTime? TuesdayExtendedHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets WednesdayBusinessHoursEndTime
	/// </summary>
	[DataMember(Name = "WednesdayBusinessHoursEndTime")]
	public DateTime? WednesdayBusinessHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets WednesdayBusinessHoursStartTime
	/// </summary>
	[DataMember(Name = "WednesdayBusinessHoursStartTime")]
	public DateTime? WednesdayBusinessHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets WednesdayExtendedHoursEndTime
	/// </summary>
	[DataMember(Name = "WednesdayExtendedHoursEndTime")]
	public DateTime? WednesdayExtendedHoursEndTime { get; set; }

	/// <summary>
	/// Gets or Sets WednesdayExtendedHoursStartTime
	/// </summary>
	[DataMember(Name = "WednesdayExtendedHoursStartTime")]
	public DateTime? WednesdayExtendedHoursStartTime { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
