using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ResourceModel
	/// </summary>
	[DataContract]
	public partial class ResourceModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ResourceModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AccountingReferenceID">AccountingReferenceID.</param>
		/// <param name="DateFormat">DateFormat.</param>
		/// <param name="DefaultServiceDeskRoleID">DefaultServiceDeskRoleID.</param>
		/// <param name="Email">Email.</param>
		/// <param name="Email2">Email2.</param>
		/// <param name="Email3">Email3.</param>
		/// <param name="EmailTypeCode">EmailTypeCode.</param>
		/// <param name="EmailTypeCode2">EmailTypeCode2.</param>
		/// <param name="EmailTypeCode3">EmailTypeCode3.</param>
		/// <param name="FirstName">FirstName.</param>
		/// <param name="Gender">Gender.</param>
		/// <param name="Greeting">Greeting.</param>
		/// <param name="HireDate">HireDate.</param>
		/// <param name="HomePhone">HomePhone.</param>
		/// <param name="Initials">Initials.</param>
		/// <param name="InternalCost">InternalCost.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="LastName">LastName.</param>
		/// <param name="LicenseType">LicenseType.</param>
		/// <param name="LocationID">LocationID.</param>
		/// <param name="MiddleName">MiddleName.</param>
		/// <param name="MobilePhone">MobilePhone.</param>
		/// <param name="NumberFormat">NumberFormat.</param>
		/// <param name="OfficeExtension">OfficeExtension.</param>
		/// <param name="OfficePhone">OfficePhone.</param>
		/// <param name="PayrollType">PayrollType.</param>
		/// <param name="ResourceType">ResourceType.</param>
		/// <param name="Suffix">Suffix.</param>
		/// <param name="SurveyResourceRating">SurveyResourceRating.</param>
		/// <param name="TimeFormat">TimeFormat.</param>
		/// <param name="Title">Title.</param>
		/// <param name="TravelAvailabilityPct">TravelAvailabilityPct.</param>
		/// <param name="UserName">UserName.</param>
		/// <param name="UserType">UserType.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ResourceModel(long? Id = default, string AccountingReferenceID = default, string DateFormat = default, long? DefaultServiceDeskRoleID = default, string Email = default, string Email2 = default, string Email3 = default, string EmailTypeCode = default, string EmailTypeCode2 = default, string EmailTypeCode3 = default, string FirstName = default, string Gender = default, int? Greeting = default, DateTime? HireDate = default, string HomePhone = default, string Initials = default, double? InternalCost = default, bool? IsActive = default, string LastName = default, int? LicenseType = default, int? LocationID = default, string MiddleName = default, string MobilePhone = default, string NumberFormat = default, string OfficeExtension = default, string OfficePhone = default, int? PayrollType = default, string ResourceType = default, int? Suffix = default, double? SurveyResourceRating = default, string TimeFormat = default, string Title = default, string TravelAvailabilityPct = default, string UserName = default, int? UserType = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AccountingReferenceID = AccountingReferenceID;
			this.DateFormat = DateFormat;
			this.DefaultServiceDeskRoleID = DefaultServiceDeskRoleID;
			this.Email = Email;
			this.Email2 = Email2;
			this.Email3 = Email3;
			this.EmailTypeCode = EmailTypeCode;
			this.EmailTypeCode2 = EmailTypeCode2;
			this.EmailTypeCode3 = EmailTypeCode3;
			this.FirstName = FirstName;
			this.Gender = Gender;
			this.Greeting = Greeting;
			this.HireDate = HireDate;
			this.HomePhone = HomePhone;
			this.Initials = Initials;
			this.InternalCost = InternalCost;
			this.IsActive = IsActive;
			this.LastName = LastName;
			this.LicenseType = LicenseType;
			this.LocationID = LocationID;
			this.MiddleName = MiddleName;
			this.MobilePhone = MobilePhone;
			this.NumberFormat = NumberFormat;
			this.OfficeExtension = OfficeExtension;
			this.OfficePhone = OfficePhone;
			this.PayrollType = PayrollType;
			this.ResourceType = ResourceType;
			this.Suffix = Suffix;
			this.SurveyResourceRating = SurveyResourceRating;
			this.TimeFormat = TimeFormat;
			this.Title = Title;
			this.TravelAvailabilityPct = TravelAvailabilityPct;
			this.UserName = UserName;
			this.UserType = UserType;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AccountingReferenceID
		/// </summary>
		[DataMember(Name = "AccountingReferenceID", EmitDefaultValue = false)]
		public string AccountingReferenceID { get; set; }

		/// <summary>
		/// Gets or Sets DateFormat
		/// </summary>
		[DataMember(Name = "DateFormat", EmitDefaultValue = false)]
		public string DateFormat { get; set; }

		/// <summary>
		/// Gets or Sets DefaultServiceDeskRoleID
		/// </summary>
		[DataMember(Name = "DefaultServiceDeskRoleID", EmitDefaultValue = false)]
		public long? DefaultServiceDeskRoleID { get; set; }

		/// <summary>
		/// Gets or Sets Email
		/// </summary>
		[DataMember(Name = "Email", EmitDefaultValue = false)]
		public string Email { get; set; }

		/// <summary>
		/// Gets or Sets Email2
		/// </summary>
		[DataMember(Name = "Email2", EmitDefaultValue = false)]
		public string Email2 { get; set; }

		/// <summary>
		/// Gets or Sets Email3
		/// </summary>
		[DataMember(Name = "Email3", EmitDefaultValue = false)]
		public string Email3 { get; set; }

		/// <summary>
		/// Gets or Sets EmailTypeCode
		/// </summary>
		[DataMember(Name = "EmailTypeCode", EmitDefaultValue = false)]
		public string EmailTypeCode { get; set; }

		/// <summary>
		/// Gets or Sets EmailTypeCode2
		/// </summary>
		[DataMember(Name = "EmailTypeCode2", EmitDefaultValue = false)]
		public string EmailTypeCode2 { get; set; }

		/// <summary>
		/// Gets or Sets EmailTypeCode3
		/// </summary>
		[DataMember(Name = "EmailTypeCode3", EmitDefaultValue = false)]
		public string EmailTypeCode3 { get; set; }

		/// <summary>
		/// Gets or Sets FirstName
		/// </summary>
		[DataMember(Name = "FirstName", EmitDefaultValue = false)]
		public string FirstName { get; set; }

		/// <summary>
		/// Gets or Sets Gender
		/// </summary>
		[DataMember(Name = "Gender", EmitDefaultValue = false)]
		public string Gender { get; set; }

		/// <summary>
		/// Gets or Sets Greeting
		/// </summary>
		[DataMember(Name = "Greeting", EmitDefaultValue = false)]
		public int? Greeting { get; set; }

		/// <summary>
		/// Gets or Sets HireDate
		/// </summary>
		[DataMember(Name = "HireDate", EmitDefaultValue = false)]
		public DateTime? HireDate { get; set; }

		/// <summary>
		/// Gets or Sets HomePhone
		/// </summary>
		[DataMember(Name = "HomePhone", EmitDefaultValue = false)]
		public string HomePhone { get; set; }

		/// <summary>
		/// Gets or Sets Initials
		/// </summary>
		[DataMember(Name = "Initials", EmitDefaultValue = false)]
		public string Initials { get; set; }

		/// <summary>
		/// Gets or Sets InternalCost
		/// </summary>
		[DataMember(Name = "InternalCost", EmitDefaultValue = false)]
		public double? InternalCost { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets LastName
		/// </summary>
		[DataMember(Name = "LastName", EmitDefaultValue = false)]
		public string LastName { get; set; }

		/// <summary>
		/// Gets or Sets LicenseType
		/// </summary>
		[DataMember(Name = "LicenseType", EmitDefaultValue = false)]
		public int? LicenseType { get; set; }

		/// <summary>
		/// Gets or Sets LocationID
		/// </summary>
		[DataMember(Name = "LocationID", EmitDefaultValue = false)]
		public int? LocationID { get; set; }

		/// <summary>
		/// Gets or Sets MiddleName
		/// </summary>
		[DataMember(Name = "MiddleName", EmitDefaultValue = false)]
		public string MiddleName { get; set; }

		/// <summary>
		/// Gets or Sets MobilePhone
		/// </summary>
		[DataMember(Name = "MobilePhone", EmitDefaultValue = false)]
		public string MobilePhone { get; set; }

		/// <summary>
		/// Gets or Sets NumberFormat
		/// </summary>
		[DataMember(Name = "NumberFormat", EmitDefaultValue = false)]
		public string NumberFormat { get; set; }

		/// <summary>
		/// Gets or Sets OfficeExtension
		/// </summary>
		[DataMember(Name = "OfficeExtension", EmitDefaultValue = false)]
		public string OfficeExtension { get; set; }

		/// <summary>
		/// Gets or Sets OfficePhone
		/// </summary>
		[DataMember(Name = "OfficePhone", EmitDefaultValue = false)]
		public string OfficePhone { get; set; }

		/// <summary>
		/// Gets or Sets PayrollType
		/// </summary>
		[DataMember(Name = "PayrollType", EmitDefaultValue = false)]
		public int? PayrollType { get; set; }

		/// <summary>
		/// Gets or Sets ResourceType
		/// </summary>
		[DataMember(Name = "ResourceType", EmitDefaultValue = false)]
		public string ResourceType { get; set; }

		/// <summary>
		/// Gets or Sets Suffix
		/// </summary>
		[DataMember(Name = "Suffix", EmitDefaultValue = false)]
		public int? Suffix { get; set; }

		/// <summary>
		/// Gets or Sets SurveyResourceRating
		/// </summary>
		[DataMember(Name = "SurveyResourceRating", EmitDefaultValue = false)]
		public double? SurveyResourceRating { get; set; }

		/// <summary>
		/// Gets or Sets TimeFormat
		/// </summary>
		[DataMember(Name = "TimeFormat", EmitDefaultValue = false)]
		public string TimeFormat { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		/// Gets or Sets TravelAvailabilityPct
		/// </summary>
		[DataMember(Name = "TravelAvailabilityPct", EmitDefaultValue = false)]
		public string TravelAvailabilityPct { get; set; }

		/// <summary>
		/// Gets or Sets UserName
		/// </summary>
		[DataMember(Name = "UserName", EmitDefaultValue = false)]
		public string UserName { get; set; }

		/// <summary>
		/// Gets or Sets UserType
		/// </summary>
		[DataMember(Name = "UserType", EmitDefaultValue = false)]
		public int? UserType { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
