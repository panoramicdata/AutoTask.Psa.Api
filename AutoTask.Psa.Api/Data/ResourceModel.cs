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
