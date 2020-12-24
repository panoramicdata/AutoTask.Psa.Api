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
		/// Initializes a new instance of the <see cref="ContactModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AdditionalAddressInformation">AdditionalAddressInformation.</param>
		/// <param name="AddressLine">AddressLine.</param>
		/// <param name="AddressLine1">AddressLine1.</param>
		/// <param name="AlternatePhone">AlternatePhone.</param>
		/// <param name="ApiVendorID">ApiVendorID.</param>
		/// <param name="BulkEmailOptOutTime">BulkEmailOptOutTime.</param>
		/// <param name="City">City.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="CompanyLocationID">CompanyLocationID.</param>
		/// <param name="CountryID">CountryID.</param>
		/// <param name="CreateDate">CreateDate.</param>
		/// <param name="EmailAddress">EmailAddress.</param>
		/// <param name="EmailAddress2">EmailAddress2.</param>
		/// <param name="EmailAddress3">EmailAddress3.</param>
		/// <param name="Extension">Extension.</param>
		/// <param name="ExternalID">ExternalID.</param>
		/// <param name="FacebookUrl">FacebookUrl.</param>
		/// <param name="FaxNumber">FaxNumber.</param>
		/// <param name="FirstName">FirstName.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsOptedOutFromBulkEmail">IsOptedOutFromBulkEmail.</param>
		/// <param name="LastActivityDate">LastActivityDate.</param>
		/// <param name="LastModifiedDate">LastModifiedDate.</param>
		/// <param name="LastName">LastName.</param>
		/// <param name="LinkedInUrl">LinkedInUrl.</param>
		/// <param name="MiddleInitial">MiddleInitial.</param>
		/// <param name="MobilePhone">MobilePhone.</param>
		/// <param name="NamePrefix">NamePrefix.</param>
		/// <param name="NameSuffix">NameSuffix.</param>
		/// <param name="Note">Note.</param>
		/// <param name="ReceivesEmailNotifications">ReceivesEmailNotifications.</param>
		/// <param name="Phone">Phone.</param>
		/// <param name="PrimaryContact">PrimaryContact.</param>
		/// <param name="RoomNumber">RoomNumber.</param>
		/// <param name="SolicitationOptOut">SolicitationOptOut.</param>
		/// <param name="SolicitationOptOutTime">SolicitationOptOutTime.</param>
		/// <param name="State">State.</param>
		/// <param name="SurveyOptOut">SurveyOptOut.</param>
		/// <param name="Title">Title.</param>
		/// <param name="TwitterUrl">TwitterUrl.</param>
		/// <param name="ZipCode">ZipCode.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContactModel(long? Id = default, string AdditionalAddressInformation = default, string AddressLine = default, string AddressLine1 = default, string AlternatePhone = default, int? ApiVendorID = default, DateTime? BulkEmailOptOutTime = default, string City = default, int? CompanyID = default, int? CompanyLocationID = default, int? CountryID = default, DateTime? CreateDate = default, string EmailAddress = default, string EmailAddress2 = default, string EmailAddress3 = default, string Extension = default, string ExternalID = default, string FacebookUrl = default, string FaxNumber = default, string FirstName = default, int? ImpersonatorCreatorResourceID = default, int? IsActive = default, bool? IsOptedOutFromBulkEmail = default, DateTime? LastActivityDate = default, DateTime? LastModifiedDate = default, string LastName = default, string LinkedInUrl = default, string MiddleInitial = default, string MobilePhone = default, int? NamePrefix = default, int? NameSuffix = default, string Note = default, bool? ReceivesEmailNotifications = default, string Phone = default, bool? PrimaryContact = default, string RoomNumber = default, bool? SolicitationOptOut = default, DateTime? SolicitationOptOutTime = default, string State = default, bool? SurveyOptOut = default, string Title = default, string TwitterUrl = default, string ZipCode = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AdditionalAddressInformation = AdditionalAddressInformation;
			this.AddressLine = AddressLine;
			this.AddressLine1 = AddressLine1;
			this.AlternatePhone = AlternatePhone;
			this.ApiVendorID = ApiVendorID;
			this.BulkEmailOptOutTime = BulkEmailOptOutTime;
			this.City = City;
			this.CompanyID = CompanyID;
			this.CompanyLocationID = CompanyLocationID;
			this.CountryID = CountryID;
			this.CreateDate = CreateDate;
			this.EmailAddress = EmailAddress;
			this.EmailAddress2 = EmailAddress2;
			this.EmailAddress3 = EmailAddress3;
			this.Extension = Extension;
			this.ExternalID = ExternalID;
			this.FacebookUrl = FacebookUrl;
			this.FaxNumber = FaxNumber;
			this.FirstName = FirstName;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.IsActive = IsActive;
			this.IsOptedOutFromBulkEmail = IsOptedOutFromBulkEmail;
			this.LastActivityDate = LastActivityDate;
			this.LastModifiedDate = LastModifiedDate;
			this.LastName = LastName;
			this.LinkedInUrl = LinkedInUrl;
			this.MiddleInitial = MiddleInitial;
			this.MobilePhone = MobilePhone;
			this.NamePrefix = NamePrefix;
			this.NameSuffix = NameSuffix;
			this.Note = Note;
			this.ReceivesEmailNotifications = ReceivesEmailNotifications;
			this.Phone = Phone;
			this.PrimaryContact = PrimaryContact;
			this.RoomNumber = RoomNumber;
			this.SolicitationOptOut = SolicitationOptOut;
			this.SolicitationOptOutTime = SolicitationOptOutTime;
			this.State = State;
			this.SurveyOptOut = SurveyOptOut;
			this.Title = Title;
			this.TwitterUrl = TwitterUrl;
			this.ZipCode = ZipCode;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AdditionalAddressInformation
		/// </summary>
		[DataMember(Name = "AdditionalAddressInformation", EmitDefaultValue = false)]
		public string AdditionalAddressInformation { get; set; }

		/// <summary>
		/// Gets or Sets AddressLine
		/// </summary>
		[DataMember(Name = "AddressLine", EmitDefaultValue = false)]
		public string AddressLine { get; set; }

		/// <summary>
		/// Gets or Sets AddressLine1
		/// </summary>
		[DataMember(Name = "AddressLine1", EmitDefaultValue = false)]
		public string AddressLine1 { get; set; }

		/// <summary>
		/// Gets or Sets AlternatePhone
		/// </summary>
		[DataMember(Name = "AlternatePhone", EmitDefaultValue = false)]
		public string AlternatePhone { get; set; }

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
		public string City { get; set; }

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
		public string EmailAddress { get; set; }

		/// <summary>
		/// Gets or Sets EmailAddress2
		/// </summary>
		[DataMember(Name = "EmailAddress2", EmitDefaultValue = false)]
		public string EmailAddress2 { get; set; }

		/// <summary>
		/// Gets or Sets EmailAddress3
		/// </summary>
		[DataMember(Name = "EmailAddress3", EmitDefaultValue = false)]
		public string EmailAddress3 { get; set; }

		/// <summary>
		/// Gets or Sets Extension
		/// </summary>
		[DataMember(Name = "Extension", EmitDefaultValue = false)]
		public string Extension { get; set; }

		/// <summary>
		/// Gets or Sets ExternalID
		/// </summary>
		[DataMember(Name = "ExternalID", EmitDefaultValue = false)]
		public string ExternalID { get; set; }

		/// <summary>
		/// Gets or Sets FacebookUrl
		/// </summary>
		[DataMember(Name = "FacebookUrl", EmitDefaultValue = false)]
		public string FacebookUrl { get; set; }

		/// <summary>
		/// Gets or Sets FaxNumber
		/// </summary>
		[DataMember(Name = "FaxNumber", EmitDefaultValue = false)]
		public string FaxNumber { get; set; }

		/// <summary>
		/// Gets or Sets FirstName
		/// </summary>
		[DataMember(Name = "FirstName", EmitDefaultValue = false)]
		public string FirstName { get; set; }

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
		public string LastName { get; set; }

		/// <summary>
		/// Gets or Sets LinkedInUrl
		/// </summary>
		[DataMember(Name = "LinkedInUrl", EmitDefaultValue = false)]
		public string LinkedInUrl { get; set; }

		/// <summary>
		/// Gets or Sets MiddleInitial
		/// </summary>
		[DataMember(Name = "MiddleInitial", EmitDefaultValue = false)]
		public string MiddleInitial { get; set; }

		/// <summary>
		/// Gets or Sets MobilePhone
		/// </summary>
		[DataMember(Name = "MobilePhone", EmitDefaultValue = false)]
		public string MobilePhone { get; set; }

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
		public string Note { get; set; }

		/// <summary>
		/// Gets or Sets ReceivesEmailNotifications
		/// </summary>
		[DataMember(Name = "ReceivesEmailNotifications", EmitDefaultValue = false)]
		public bool? ReceivesEmailNotifications { get; set; }

		/// <summary>
		/// Gets or Sets Phone
		/// </summary>
		[DataMember(Name = "Phone", EmitDefaultValue = false)]
		public string Phone { get; set; }

		/// <summary>
		/// Gets or Sets PrimaryContact
		/// </summary>
		[DataMember(Name = "PrimaryContact", EmitDefaultValue = false)]
		public bool? PrimaryContact { get; set; }

		/// <summary>
		/// Gets or Sets RoomNumber
		/// </summary>
		[DataMember(Name = "RoomNumber", EmitDefaultValue = false)]
		public string RoomNumber { get; set; }

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
		public string State { get; set; }

		/// <summary>
		/// Gets or Sets SurveyOptOut
		/// </summary>
		[DataMember(Name = "SurveyOptOut", EmitDefaultValue = false)]
		public bool? SurveyOptOut { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		/// Gets or Sets TwitterUrl
		/// </summary>
		[DataMember(Name = "TwitterUrl", EmitDefaultValue = false)]
		public string TwitterUrl { get; set; }

		/// <summary>
		/// Gets or Sets ZipCode
		/// </summary>
		[DataMember(Name = "ZipCode", EmitDefaultValue = false)]
		public string ZipCode { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContactInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
