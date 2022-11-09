namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ResourceModel
/// </summary>
[DataContract]
public class ResourceModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AccountingReferenceID
	/// </summary>
	[DataMember(Name = "AccountingReferenceID")]
	public string AccountingReferenceID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DateFormat
	/// </summary>
	[DataMember(Name = "DateFormat")]
	public string DateFormat { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DefaultServiceDeskRoleID
	/// </summary>
	[DataMember(Name = "DefaultServiceDeskRoleID")]
	public long? DefaultServiceDeskRoleID { get; set; }

	/// <summary>
	/// Gets or Sets Email
	/// </summary>
	[DataMember(Name = "Email")]
	public string Email { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Email2
	/// </summary>
	[DataMember(Name = "Email2")]
	public string Email2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Email3
	/// </summary>
	[DataMember(Name = "Email3")]
	public string Email3 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets EmailTypeCode
	/// </summary>
	[DataMember(Name = "EmailTypeCode")]
	public string EmailTypeCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets EmailTypeCode2
	/// </summary>
	[DataMember(Name = "EmailTypeCode2")]
	public string EmailTypeCode2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets EmailTypeCode3
	/// </summary>
	[DataMember(Name = "EmailTypeCode3")]
	public string EmailTypeCode3 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets FirstName
	/// </summary>
	[DataMember(Name = "FirstName")]
	public string FirstName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Gender
	/// </summary>
	[DataMember(Name = "Gender")]
	public string Gender { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Greeting
	/// </summary>
	[DataMember(Name = "Greeting")]
	public int? Greeting { get; set; }

	/// <summary>
	/// Gets or Sets HireDate
	/// </summary>
	[DataMember(Name = "HireDate")]
	public DateTime? HireDate { get; set; }

	/// <summary>
	/// Gets or Sets HomePhone
	/// </summary>
	[DataMember(Name = "HomePhone")]
	public string HomePhone { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Initials
	/// </summary>
	[DataMember(Name = "Initials")]
	public string Initials { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets InternalCost
	/// </summary>
	[DataMember(Name = "InternalCost")]
	public double? InternalCost { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets LastName
	/// </summary>
	[DataMember(Name = "LastName")]
	public string LastName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets LicenseType
	/// </summary>
	[DataMember(Name = "LicenseType")]
	public int? LicenseType { get; set; }

	/// <summary>
	/// Gets or Sets LocationID
	/// </summary>
	[DataMember(Name = "LocationID")]
	public int? LocationID { get; set; }

	/// <summary>
	/// Gets or Sets MiddleName
	/// </summary>
	[DataMember(Name = "MiddleName")]
	public string MiddleName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets MobilePhone
	/// </summary>
	[DataMember(Name = "MobilePhone")]
	public string MobilePhone { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets NumberFormat
	/// </summary>
	[DataMember(Name = "NumberFormat")]
	public string NumberFormat { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets OfficeExtension
	/// </summary>
	[DataMember(Name = "OfficeExtension")]
	public string OfficeExtension { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets OfficePhone
	/// </summary>
	[DataMember(Name = "OfficePhone")]
	public string OfficePhone { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets PayrollType
	/// </summary>
	[DataMember(Name = "PayrollType")]
	public int? PayrollType { get; set; }

	/// <summary>
	/// Gets or Sets ResourceType
	/// </summary>
	[DataMember(Name = "ResourceType")]
	public string ResourceType { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Suffix
	/// </summary>
	[DataMember(Name = "Suffix")]
	public int? Suffix { get; set; }

	/// <summary>
	/// Gets or Sets SurveyResourceRating
	/// </summary>
	[DataMember(Name = "SurveyResourceRating")]
	public double? SurveyResourceRating { get; set; }

	/// <summary>
	/// Gets or Sets TimeFormat
	/// </summary>
	[DataMember(Name = "TimeFormat")]
	public string TimeFormat { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "Title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TravelAvailabilityPct
	/// </summary>
	[DataMember(Name = "TravelAvailabilityPct")]
	public string TravelAvailabilityPct { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserName
	/// </summary>
	[DataMember(Name = "UserName")]
	public string UserName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserType
	/// </summary>
	[DataMember(Name = "UserType")]
	public int? UserType { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
