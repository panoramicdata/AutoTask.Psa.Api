namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContactModel
/// </summary>
[DataContract]
public class ContactModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AdditionalAddressInformation
	/// </summary>
	[DataMember(Name = "AdditionalAddressInformation")]
	public string AdditionalAddressInformation { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets AddressLine
	/// </summary>
	[DataMember(Name = "AddressLine")]
	public string AddressLine { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets AddressLine1
	/// </summary>
	[DataMember(Name = "AddressLine1")]
	public string AddressLine1 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets AlternatePhone
	/// </summary>
	[DataMember(Name = "AlternatePhone")]
	public string AlternatePhone { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ApiVendorID
	/// </summary>
	[DataMember(Name = "ApiVendorID")]
	public int? ApiVendorID { get; set; }

	/// <summary>
	/// Gets or Sets BulkEmailOptOutTime
	/// </summary>
	[DataMember(Name = "BulkEmailOptOutTime")]
	public DateTime? BulkEmailOptOutTime { get; set; }

	/// <summary>
	/// Gets or Sets City
	/// </summary>
	[DataMember(Name = "City")]
	public string City { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets CompanyLocationID
	/// </summary>
	[DataMember(Name = "CompanyLocationID")]
	public int? CompanyLocationID { get; set; }

	/// <summary>
	/// Gets or Sets CountryID
	/// </summary>
	[DataMember(Name = "CountryID")]
	public int? CountryID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDate
	/// </summary>
	[DataMember(Name = "CreateDate")]
	public DateTime? CreateDate { get; set; }

	/// <summary>
	/// Gets or Sets EmailAddress
	/// </summary>
	[DataMember(Name = "EmailAddress")]
	public string EmailAddress { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets EmailAddress2
	/// </summary>
	[DataMember(Name = "EmailAddress2")]
	public string EmailAddress2 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets EmailAddress3
	/// </summary>
	[DataMember(Name = "EmailAddress3")]
	public string EmailAddress3 { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Extension
	/// </summary>
	[DataMember(Name = "Extension")]
	public string Extension { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ExternalID
	/// </summary>
	[DataMember(Name = "ExternalID")]
	public string ExternalID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets FacebookUrl
	/// </summary>
	[DataMember(Name = "FacebookUrl")]
	public string FacebookUrl { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets FaxNumber
	/// </summary>
	[DataMember(Name = "FaxNumber")]
	public string FaxNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets FirstName
	/// </summary>
	[DataMember(Name = "FirstName")]
	public string FirstName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public int? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets IsOptedOutFromBulkEmail
	/// </summary>
	[DataMember(Name = "IsOptedOutFromBulkEmail")]
	public bool? IsOptedOutFromBulkEmail { get; set; }

	/// <summary>
	/// Gets or Sets LastActivityDate
	/// </summary>
	[DataMember(Name = "LastActivityDate")]
	public DateTime? LastActivityDate { get; set; }

	/// <summary>
	/// Gets or Sets LastModifiedDate
	/// </summary>
	[DataMember(Name = "LastModifiedDate")]
	public DateTime? LastModifiedDate { get; set; }

	/// <summary>
	/// Gets or Sets LastName
	/// </summary>
	[DataMember(Name = "LastName")]
	public string LastName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets LinkedInUrl
	/// </summary>
	[DataMember(Name = "LinkedInUrl")]
	public string LinkedInUrl { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets MiddleInitial
	/// </summary>
	[DataMember(Name = "MiddleInitial")]
	public string MiddleInitial { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets MobilePhone
	/// </summary>
	[DataMember(Name = "MobilePhone")]
	public string MobilePhone { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets NamePrefix
	/// </summary>
	[DataMember(Name = "NamePrefix")]
	public int? NamePrefix { get; set; }

	/// <summary>
	/// Gets or Sets NameSuffix
	/// </summary>
	[DataMember(Name = "NameSuffix")]
	public int? NameSuffix { get; set; }

	/// <summary>
	/// Gets or Sets Note
	/// </summary>
	[DataMember(Name = "Note")]
	public string Note { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ReceivesEmailNotifications
	/// </summary>
	[DataMember(Name = "ReceivesEmailNotifications")]
	public bool? ReceivesEmailNotifications { get; set; }

	/// <summary>
	/// Gets or Sets Phone
	/// </summary>
	[DataMember(Name = "Phone")]
	public string Phone { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets PrimaryContact
	/// </summary>
	[DataMember(Name = "PrimaryContact")]
	public bool? PrimaryContact { get; set; }

	/// <summary>
	/// Gets or Sets RoomNumber
	/// </summary>
	[DataMember(Name = "RoomNumber")]
	public string RoomNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SolicitationOptOut
	/// </summary>
	[DataMember(Name = "SolicitationOptOut")]
	public bool? SolicitationOptOut { get; set; }

	/// <summary>
	/// Gets or Sets SolicitationOptOutTime
	/// </summary>
	[DataMember(Name = "SolicitationOptOutTime")]
	public DateTime? SolicitationOptOutTime { get; set; }

	/// <summary>
	/// Gets or Sets State
	/// </summary>
	[DataMember(Name = "State")]
	public string State { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SurveyOptOut
	/// </summary>
	[DataMember(Name = "SurveyOptOut")]
	public bool? SurveyOptOut { get; set; }

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "Title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TwitterUrl
	/// </summary>
	[DataMember(Name = "TwitterUrl")]
	public string TwitterUrl { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ZipCode
	/// </summary>
	[DataMember(Name = "ZipCode")]
	public string ZipCode { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
