using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContactModel
	/// </summary>
	[DataContract]
	public partial class ContactModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AdditionalAddressInformation
		/// </summary>
		[DataMember(Name = "AdditionalAddressInformation", EmitDefaultValue = false)]
		public string AdditionalAddressInformation { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets AddressLine
		/// </summary>
		[DataMember(Name = "AddressLine", EmitDefaultValue = false)]
		public string AddressLine { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets AddressLine1
		/// </summary>
		[DataMember(Name = "AddressLine1", EmitDefaultValue = false)]
		public string AddressLine1 { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets AlternatePhone
		/// </summary>
		[DataMember(Name = "AlternatePhone", EmitDefaultValue = false)]
		public string AlternatePhone { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ApiVendorID
		/// </summary>
		[DataMember(Name = "ApiVendorID", EmitDefaultValue = false)]
		public int? ApiVendorID { get; set; }

		/// <summary>
		/// Gets or Sets BulkEmailOptOutTime
		/// </summary>
		[DataMember(Name = "BulkEmailOptOutTime", EmitDefaultValue = false)]
		public DateTime? BulkEmailOptOutTime { get; set; }

		/// <summary>
		/// Gets or Sets City
		/// </summary>
		[DataMember(Name = "City", EmitDefaultValue = false)]
		public string City { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets CompanyLocationID
		/// </summary>
		[DataMember(Name = "CompanyLocationID", EmitDefaultValue = false)]
		public int? CompanyLocationID { get; set; }

		/// <summary>
		/// Gets or Sets CountryID
		/// </summary>
		[DataMember(Name = "CountryID", EmitDefaultValue = false)]
		public int? CountryID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate", EmitDefaultValue = false)]
		public DateTime? CreateDate { get; set; }

		/// <summary>
		/// Gets or Sets EmailAddress
		/// </summary>
		[DataMember(Name = "EmailAddress", EmitDefaultValue = false)]
		public string EmailAddress { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets EmailAddress2
		/// </summary>
		[DataMember(Name = "EmailAddress2", EmitDefaultValue = false)]
		public string EmailAddress2 { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets EmailAddress3
		/// </summary>
		[DataMember(Name = "EmailAddress3", EmitDefaultValue = false)]
		public string EmailAddress3 { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Extension
		/// </summary>
		[DataMember(Name = "Extension", EmitDefaultValue = false)]
		public string Extension { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ExternalID
		/// </summary>
		[DataMember(Name = "ExternalID", EmitDefaultValue = false)]
		public string ExternalID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets FacebookUrl
		/// </summary>
		[DataMember(Name = "FacebookUrl", EmitDefaultValue = false)]
		public string FacebookUrl { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets FaxNumber
		/// </summary>
		[DataMember(Name = "FaxNumber", EmitDefaultValue = false)]
		public string FaxNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets FirstName
		/// </summary>
		[DataMember(Name = "FirstName", EmitDefaultValue = false)]
		public string FirstName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public int? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsOptedOutFromBulkEmail
		/// </summary>
		[DataMember(Name = "IsOptedOutFromBulkEmail", EmitDefaultValue = false)]
		public bool? IsOptedOutFromBulkEmail { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityDate
		/// </summary>
		[DataMember(Name = "LastActivityDate", EmitDefaultValue = false)]
		public DateTime? LastActivityDate { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedDate
		/// </summary>
		[DataMember(Name = "LastModifiedDate", EmitDefaultValue = false)]
		public DateTime? LastModifiedDate { get; set; }

		/// <summary>
		/// Gets or Sets LastName
		/// </summary>
		[DataMember(Name = "LastName", EmitDefaultValue = false)]
		public string LastName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets LinkedInUrl
		/// </summary>
		[DataMember(Name = "LinkedInUrl", EmitDefaultValue = false)]
		public string LinkedInUrl { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets MiddleInitial
		/// </summary>
		[DataMember(Name = "MiddleInitial", EmitDefaultValue = false)]
		public string MiddleInitial { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets MobilePhone
		/// </summary>
		[DataMember(Name = "MobilePhone", EmitDefaultValue = false)]
		public string MobilePhone { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets NamePrefix
		/// </summary>
		[DataMember(Name = "NamePrefix", EmitDefaultValue = false)]
		public int? NamePrefix { get; set; }

		/// <summary>
		/// Gets or Sets NameSuffix
		/// </summary>
		[DataMember(Name = "NameSuffix", EmitDefaultValue = false)]
		public int? NameSuffix { get; set; }

		/// <summary>
		/// Gets or Sets Note
		/// </summary>
		[DataMember(Name = "Note", EmitDefaultValue = false)]
		public string Note { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ReceivesEmailNotifications
		/// </summary>
		[DataMember(Name = "ReceivesEmailNotifications", EmitDefaultValue = false)]
		public bool? ReceivesEmailNotifications { get; set; }

		/// <summary>
		/// Gets or Sets Phone
		/// </summary>
		[DataMember(Name = "Phone", EmitDefaultValue = false)]
		public string Phone { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets PrimaryContact
		/// </summary>
		[DataMember(Name = "PrimaryContact", EmitDefaultValue = false)]
		public bool? PrimaryContact { get; set; }

		/// <summary>
		/// Gets or Sets RoomNumber
		/// </summary>
		[DataMember(Name = "RoomNumber", EmitDefaultValue = false)]
		public string RoomNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets SolicitationOptOut
		/// </summary>
		[DataMember(Name = "SolicitationOptOut", EmitDefaultValue = false)]
		public bool? SolicitationOptOut { get; set; }

		/// <summary>
		/// Gets or Sets SolicitationOptOutTime
		/// </summary>
		[DataMember(Name = "SolicitationOptOutTime", EmitDefaultValue = false)]
		public DateTime? SolicitationOptOutTime { get; set; }

		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "State", EmitDefaultValue = false)]
		public string State { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets SurveyOptOut
		/// </summary>
		[DataMember(Name = "SurveyOptOut", EmitDefaultValue = false)]
		public bool? SurveyOptOut { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets TwitterUrl
		/// </summary>
		[DataMember(Name = "TwitterUrl", EmitDefaultValue = false)]
		public string TwitterUrl { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ZipCode
		/// </summary>
		[DataMember(Name = "ZipCode", EmitDefaultValue = false)]
		public string ZipCode { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
