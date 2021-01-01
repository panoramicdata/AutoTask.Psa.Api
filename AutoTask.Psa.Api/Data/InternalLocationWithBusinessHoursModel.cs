using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// InternalLocationWithBusinessHoursModel
	/// </summary>
	[DataContract]
	public partial class InternalLocationWithBusinessHoursModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AdditionalAddressInfo
		/// </summary>
		[DataMember(Name = "AdditionalAddressInfo", EmitDefaultValue = false)]
		public string AdditionalAddressInfo { get; set; }

		/// <summary>
		/// Gets or Sets Address1
		/// </summary>
		[DataMember(Name = "Address1", EmitDefaultValue = false)]
		public string Address1 { get; set; }

		/// <summary>
		/// Gets or Sets Address2
		/// </summary>
		[DataMember(Name = "Address2", EmitDefaultValue = false)]
		public string Address2 { get; set; }

		/// <summary>
		/// Gets or Sets City
		/// </summary>
		[DataMember(Name = "City", EmitDefaultValue = false)]
		public string City { get; set; }

		/// <summary>
		/// Gets or Sets CountryID
		/// </summary>
		[DataMember(Name = "CountryID", EmitDefaultValue = false)]
		public int? CountryID { get; set; }

		/// <summary>
		/// Gets or Sets DateFormat
		/// </summary>
		[DataMember(Name = "DateFormat", EmitDefaultValue = false)]
		public string DateFormat { get; set; }

		/// <summary>
		/// Gets or Sets FirstDayOfWeek
		/// </summary>
		[DataMember(Name = "FirstDayOfWeek", EmitDefaultValue = false)]
		public int? FirstDayOfWeek { get; set; }

		/// <summary>
		/// Gets or Sets FridayBusinessHoursEndTime
		/// </summary>
		[DataMember(Name = "FridayBusinessHoursEndTime", EmitDefaultValue = false)]
		public DateTime? FridayBusinessHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets FridayBusinessHoursStartTime
		/// </summary>
		[DataMember(Name = "FridayBusinessHoursStartTime", EmitDefaultValue = false)]
		public DateTime? FridayBusinessHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets FridayExtendedHoursEndTime
		/// </summary>
		[DataMember(Name = "FridayExtendedHoursEndTime", EmitDefaultValue = false)]
		public DateTime? FridayExtendedHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets FridayExtendedHoursStartTime
		/// </summary>
		[DataMember(Name = "FridayExtendedHoursStartTime", EmitDefaultValue = false)]
		public DateTime? FridayExtendedHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets HolidayExtendedHoursEndTime
		/// </summary>
		[DataMember(Name = "HolidayExtendedHoursEndTime", EmitDefaultValue = false)]
		public DateTime? HolidayExtendedHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets HolidayExtendedHoursStartTime
		/// </summary>
		[DataMember(Name = "HolidayExtendedHoursStartTime", EmitDefaultValue = false)]
		public DateTime? HolidayExtendedHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets HolidayHoursEndTime
		/// </summary>
		[DataMember(Name = "HolidayHoursEndTime", EmitDefaultValue = false)]
		public DateTime? HolidayHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets HolidayHoursStartTime
		/// </summary>
		[DataMember(Name = "HolidayHoursStartTime", EmitDefaultValue = false)]
		public DateTime? HolidayHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets HolidayHoursType
		/// </summary>
		[DataMember(Name = "HolidayHoursType", EmitDefaultValue = false)]
		public int? HolidayHoursType { get; set; }

		/// <summary>
		/// Gets or Sets HolidaySetID
		/// </summary>
		[DataMember(Name = "HolidaySetID", EmitDefaultValue = false)]
		public int? HolidaySetID { get; set; }

		/// <summary>
		/// Gets or Sets IsDefault
		/// </summary>
		[DataMember(Name = "IsDefault", EmitDefaultValue = false)]
		public bool? IsDefault { get; set; }

		/// <summary>
		/// Gets or Sets MondayBusinessHoursEndTime
		/// </summary>
		[DataMember(Name = "MondayBusinessHoursEndTime", EmitDefaultValue = false)]
		public DateTime? MondayBusinessHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets MondayBusinessHoursStartTime
		/// </summary>
		[DataMember(Name = "MondayBusinessHoursStartTime", EmitDefaultValue = false)]
		public DateTime? MondayBusinessHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets MondayExtendedHoursEndTime
		/// </summary>
		[DataMember(Name = "MondayExtendedHoursEndTime", EmitDefaultValue = false)]
		public DateTime? MondayExtendedHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets MondayExtendedHoursStartTime
		/// </summary>
		[DataMember(Name = "MondayExtendedHoursStartTime", EmitDefaultValue = false)]
		public DateTime? MondayExtendedHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets NoHoursOnHolidays
		/// </summary>
		[DataMember(Name = "NoHoursOnHolidays", EmitDefaultValue = false)]
		public bool? NoHoursOnHolidays { get; set; }

		/// <summary>
		/// Gets or Sets NumberFormat
		/// </summary>
		[DataMember(Name = "NumberFormat", EmitDefaultValue = false)]
		public string NumberFormat { get; set; }

		/// <summary>
		/// Gets or Sets PostalCode
		/// </summary>
		[DataMember(Name = "PostalCode", EmitDefaultValue = false)]
		public string PostalCode { get; set; }

		/// <summary>
		/// Gets or Sets SaturdayBusinessHoursEndTime
		/// </summary>
		[DataMember(Name = "SaturdayBusinessHoursEndTime", EmitDefaultValue = false)]
		public DateTime? SaturdayBusinessHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets SaturdayBusinessHoursStartTime
		/// </summary>
		[DataMember(Name = "SaturdayBusinessHoursStartTime", EmitDefaultValue = false)]
		public DateTime? SaturdayBusinessHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets SaturdayExtendedHoursEndTime
		/// </summary>
		[DataMember(Name = "SaturdayExtendedHoursEndTime", EmitDefaultValue = false)]
		public DateTime? SaturdayExtendedHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets SaturdayExtendedHoursStartTime
		/// </summary>
		[DataMember(Name = "SaturdayExtendedHoursStartTime", EmitDefaultValue = false)]
		public DateTime? SaturdayExtendedHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "State", EmitDefaultValue = false)]
		public string State { get; set; }

		/// <summary>
		/// Gets or Sets SundayBusinessHoursEndTime
		/// </summary>
		[DataMember(Name = "SundayBusinessHoursEndTime", EmitDefaultValue = false)]
		public DateTime? SundayBusinessHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets SundayBusinessHoursStartTime
		/// </summary>
		[DataMember(Name = "SundayBusinessHoursStartTime", EmitDefaultValue = false)]
		public DateTime? SundayBusinessHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets SundayExtendedHoursEndTime
		/// </summary>
		[DataMember(Name = "SundayExtendedHoursEndTime", EmitDefaultValue = false)]
		public DateTime? SundayExtendedHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets SundayExtendedHoursStartTime
		/// </summary>
		[DataMember(Name = "SundayExtendedHoursStartTime", EmitDefaultValue = false)]
		public DateTime? SundayExtendedHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets ThursdayBusinessHoursEndTime
		/// </summary>
		[DataMember(Name = "ThursdayBusinessHoursEndTime", EmitDefaultValue = false)]
		public DateTime? ThursdayBusinessHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets ThursdayBusinessHoursStartTime
		/// </summary>
		[DataMember(Name = "ThursdayBusinessHoursStartTime", EmitDefaultValue = false)]
		public DateTime? ThursdayBusinessHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets ThursdayExtendedHoursEndTime
		/// </summary>
		[DataMember(Name = "ThursdayExtendedHoursEndTime", EmitDefaultValue = false)]
		public DateTime? ThursdayExtendedHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets ThursdayExtendedHoursStartTime
		/// </summary>
		[DataMember(Name = "ThursdayExtendedHoursStartTime", EmitDefaultValue = false)]
		public DateTime? ThursdayExtendedHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets TimeFormat
		/// </summary>
		[DataMember(Name = "TimeFormat", EmitDefaultValue = false)]
		public string TimeFormat { get; set; }

		/// <summary>
		/// Gets or Sets TimeZoneID
		/// </summary>
		[DataMember(Name = "TimeZoneID", EmitDefaultValue = false)]
		public int? TimeZoneID { get; set; }

		/// <summary>
		/// Gets or Sets TuesdayBusinessHoursEndTime
		/// </summary>
		[DataMember(Name = "TuesdayBusinessHoursEndTime", EmitDefaultValue = false)]
		public DateTime? TuesdayBusinessHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets TuesdayBusinessHoursStartTime
		/// </summary>
		[DataMember(Name = "TuesdayBusinessHoursStartTime", EmitDefaultValue = false)]
		public DateTime? TuesdayBusinessHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets TuesdayExtendedHoursEndTime
		/// </summary>
		[DataMember(Name = "TuesdayExtendedHoursEndTime", EmitDefaultValue = false)]
		public DateTime? TuesdayExtendedHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets TuesdayExtendedHoursStartTime
		/// </summary>
		[DataMember(Name = "TuesdayExtendedHoursStartTime", EmitDefaultValue = false)]
		public DateTime? TuesdayExtendedHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets WednesdayBusinessHoursEndTime
		/// </summary>
		[DataMember(Name = "WednesdayBusinessHoursEndTime", EmitDefaultValue = false)]
		public DateTime? WednesdayBusinessHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets WednesdayBusinessHoursStartTime
		/// </summary>
		[DataMember(Name = "WednesdayBusinessHoursStartTime", EmitDefaultValue = false)]
		public DateTime? WednesdayBusinessHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets WednesdayExtendedHoursEndTime
		/// </summary>
		[DataMember(Name = "WednesdayExtendedHoursEndTime", EmitDefaultValue = false)]
		public DateTime? WednesdayExtendedHoursEndTime { get; set; }

		/// <summary>
		/// Gets or Sets WednesdayExtendedHoursStartTime
		/// </summary>
		[DataMember(Name = "WednesdayExtendedHoursStartTime", EmitDefaultValue = false)]
		public DateTime? WednesdayExtendedHoursStartTime { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
