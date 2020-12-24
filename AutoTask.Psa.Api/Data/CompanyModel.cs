using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CompanyModel
	/// </summary>
	[DataContract]
	public partial class CompanyModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CompanyModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AdditionalAddressInformation">AdditionalAddressInformation.</param>
		/// <param name="Address1">Address1.</param>
		/// <param name="Address2">Address2.</param>
		/// <param name="AlternatePhone1">AlternatePhone1.</param>
		/// <param name="AlternatePhone2">AlternatePhone2.</param>
		/// <param name="ApiVendorID">ApiVendorID.</param>
		/// <param name="AssetValue">AssetValue.</param>
		/// <param name="BillToCompanyLocationID">BillToCompanyLocationID.</param>
		/// <param name="BillToAdditionalAddressInformation">BillToAdditionalAddressInformation.</param>
		/// <param name="BillingAddress1">BillingAddress1.</param>
		/// <param name="BillingAddress2">BillingAddress2.</param>
		/// <param name="BillToAddressToUse">BillToAddressToUse.</param>
		/// <param name="BillToAttention">BillToAttention.</param>
		/// <param name="BillToCity">BillToCity.</param>
		/// <param name="BillToCountryID">BillToCountryID.</param>
		/// <param name="BillToState">BillToState.</param>
		/// <param name="BillToZipCode">BillToZipCode.</param>
		/// <param name="City">City.</param>
		/// <param name="Classification">Classification.</param>
		/// <param name="CompanyName">CompanyName.</param>
		/// <param name="CompanyNumber">CompanyNumber.</param>
		/// <param name="CompanyType">CompanyType.</param>
		/// <param name="CompetitorID">CompetitorID.</param>
		/// <param name="CountryID">CountryID.</param>
		/// <param name="CreateDate">CreateDate.</param>
		/// <param name="CreatedByResourceID">CreatedByResourceID.</param>
		/// <param name="CurrencyID">CurrencyID.</param>
		/// <param name="Fax">Fax.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="InvoiceEmailMessageID">InvoiceEmailMessageID.</param>
		/// <param name="InvoiceMethod">InvoiceMethod.</param>
		/// <param name="InvoiceNonContractItemsToParentCompany">InvoiceNonContractItemsToParentCompany.</param>
		/// <param name="InvoiceTemplateID">InvoiceTemplateID.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsClientPortalActive">IsClientPortalActive.</param>
		/// <param name="IsEnabledForComanaged">IsEnabledForComanaged.</param>
		/// <param name="IsTaskFireActive">IsTaskFireActive.</param>
		/// <param name="IsTaxExempt">IsTaxExempt.</param>
		/// <param name="LastActivityDate">LastActivityDate.</param>
		/// <param name="LastTrackedModifiedDateTime">LastTrackedModifiedDateTime.</param>
		/// <param name="MarketSegmentID">MarketSegmentID.</param>
		/// <param name="OwnerResourceID">OwnerResourceID.</param>
		/// <param name="ParentCompanyID">ParentCompanyID.</param>
		/// <param name="Phone">Phone.</param>
		/// <param name="PostalCode">PostalCode.</param>
		/// <param name="QuoteEmailMessageID">QuoteEmailMessageID.</param>
		/// <param name="QuoteTemplateID">QuoteTemplateID.</param>
		/// <param name="SICCode">SICCode.</param>
		/// <param name="State">State.</param>
		/// <param name="StockMarket">StockMarket.</param>
		/// <param name="StockSymbol">StockSymbol.</param>
		/// <param name="SurveyCompanyRating">SurveyCompanyRating.</param>
		/// <param name="TaxID">TaxID.</param>
		/// <param name="TaxRegionID">TaxRegionID.</param>
		/// <param name="TerritoryID">TerritoryID.</param>
		/// <param name="WebAddress">WebAddress.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public CompanyModel(long? Id = default, string AdditionalAddressInformation = default, string Address1 = default, string Address2 = default, string AlternatePhone1 = default, string AlternatePhone2 = default, int? ApiVendorID = default, double? AssetValue = default, int? BillToCompanyLocationID = default, string BillToAdditionalAddressInformation = default, string BillingAddress1 = default, string BillingAddress2 = default, int? BillToAddressToUse = default, string BillToAttention = default, string BillToCity = default, int? BillToCountryID = default, string BillToState = default, string BillToZipCode = default, string City = default, int? Classification = default, string CompanyName = default, string CompanyNumber = default, int? CompanyType = default, int? CompetitorID = default, int? CountryID = default, DateTime? CreateDate = default, int? CreatedByResourceID = default, int? CurrencyID = default, string Fax = default, int? ImpersonatorCreatorResourceID = default, int? InvoiceEmailMessageID = default, int? InvoiceMethod = default, bool? InvoiceNonContractItemsToParentCompany = default, int? InvoiceTemplateID = default, bool? IsActive = default, bool? IsClientPortalActive = default, bool? IsEnabledForComanaged = default, bool? IsTaskFireActive = default, bool? IsTaxExempt = default, DateTime? LastActivityDate = default, DateTime? LastTrackedModifiedDateTime = default, int? MarketSegmentID = default, int? OwnerResourceID = default, int? ParentCompanyID = default, string Phone = default, string PostalCode = default, int? QuoteEmailMessageID = default, int? QuoteTemplateID = default, string SICCode = default, string State = default, string StockMarket = default, string StockSymbol = default, double? SurveyCompanyRating = default, string TaxID = default, int? TaxRegionID = default, int? TerritoryID = default, string WebAddress = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AdditionalAddressInformation = AdditionalAddressInformation;
			this.Address1 = Address1;
			this.Address2 = Address2;
			this.AlternatePhone1 = AlternatePhone1;
			this.AlternatePhone2 = AlternatePhone2;
			this.ApiVendorID = ApiVendorID;
			this.AssetValue = AssetValue;
			this.BillToCompanyLocationID = BillToCompanyLocationID;
			this.BillToAdditionalAddressInformation = BillToAdditionalAddressInformation;
			this.BillingAddress1 = BillingAddress1;
			this.BillingAddress2 = BillingAddress2;
			this.BillToAddressToUse = BillToAddressToUse;
			this.BillToAttention = BillToAttention;
			this.BillToCity = BillToCity;
			this.BillToCountryID = BillToCountryID;
			this.BillToState = BillToState;
			this.BillToZipCode = BillToZipCode;
			this.City = City;
			this.Classification = Classification;
			this.CompanyName = CompanyName;
			this.CompanyNumber = CompanyNumber;
			this.CompanyType = CompanyType;
			this.CompetitorID = CompetitorID;
			this.CountryID = CountryID;
			this.CreateDate = CreateDate;
			this.CreatedByResourceID = CreatedByResourceID;
			this.CurrencyID = CurrencyID;
			this.Fax = Fax;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.InvoiceEmailMessageID = InvoiceEmailMessageID;
			this.InvoiceMethod = InvoiceMethod;
			this.InvoiceNonContractItemsToParentCompany = InvoiceNonContractItemsToParentCompany;
			this.InvoiceTemplateID = InvoiceTemplateID;
			this.IsActive = IsActive;
			this.IsClientPortalActive = IsClientPortalActive;
			this.IsEnabledForComanaged = IsEnabledForComanaged;
			this.IsTaskFireActive = IsTaskFireActive;
			this.IsTaxExempt = IsTaxExempt;
			this.LastActivityDate = LastActivityDate;
			this.LastTrackedModifiedDateTime = LastTrackedModifiedDateTime;
			this.MarketSegmentID = MarketSegmentID;
			this.OwnerResourceID = OwnerResourceID;
			this.ParentCompanyID = ParentCompanyID;
			this.Phone = Phone;
			this.PostalCode = PostalCode;
			this.QuoteEmailMessageID = QuoteEmailMessageID;
			this.QuoteTemplateID = QuoteTemplateID;
			this.SICCode = SICCode;
			this.State = State;
			this.StockMarket = StockMarket;
			this.StockSymbol = StockSymbol;
			this.SurveyCompanyRating = SurveyCompanyRating;
			this.TaxID = TaxID;
			this.TaxRegionID = TaxRegionID;
			this.TerritoryID = TerritoryID;
			this.WebAddress = WebAddress;
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
		/// Gets or Sets AlternatePhone1
		/// </summary>
		[DataMember(Name = "AlternatePhone1", EmitDefaultValue = false)]
		public string AlternatePhone1 { get; set; }

		/// <summary>
		/// Gets or Sets AlternatePhone2
		/// </summary>
		[DataMember(Name = "AlternatePhone2", EmitDefaultValue = false)]
		public string AlternatePhone2 { get; set; }

		/// <summary>
		/// Gets or Sets ApiVendorID
		/// </summary>
		[DataMember(Name = "ApiVendorID", EmitDefaultValue = false)]
		public int? ApiVendorID { get; set; }

		/// <summary>
		/// Gets or Sets AssetValue
		/// </summary>
		[DataMember(Name = "AssetValue", EmitDefaultValue = false)]
		public double? AssetValue { get; set; }

		/// <summary>
		/// Gets or Sets BillToCompanyLocationID
		/// </summary>
		[DataMember(Name = "BillToCompanyLocationID", EmitDefaultValue = false)]
		public int? BillToCompanyLocationID { get; set; }

		/// <summary>
		/// Gets or Sets BillToAdditionalAddressInformation
		/// </summary>
		[DataMember(Name = "BillToAdditionalAddressInformation", EmitDefaultValue = false)]
		public string BillToAdditionalAddressInformation { get; set; }

		/// <summary>
		/// Gets or Sets BillingAddress1
		/// </summary>
		[DataMember(Name = "BillingAddress1", EmitDefaultValue = false)]
		public string BillingAddress1 { get; set; }

		/// <summary>
		/// Gets or Sets BillingAddress2
		/// </summary>
		[DataMember(Name = "BillingAddress2", EmitDefaultValue = false)]
		public string BillingAddress2 { get; set; }

		/// <summary>
		/// Gets or Sets BillToAddressToUse
		/// </summary>
		[DataMember(Name = "BillToAddressToUse", EmitDefaultValue = false)]
		public int? BillToAddressToUse { get; set; }

		/// <summary>
		/// Gets or Sets BillToAttention
		/// </summary>
		[DataMember(Name = "BillToAttention", EmitDefaultValue = false)]
		public string BillToAttention { get; set; }

		/// <summary>
		/// Gets or Sets BillToCity
		/// </summary>
		[DataMember(Name = "BillToCity", EmitDefaultValue = false)]
		public string BillToCity { get; set; }

		/// <summary>
		/// Gets or Sets BillToCountryID
		/// </summary>
		[DataMember(Name = "BillToCountryID", EmitDefaultValue = false)]
		public int? BillToCountryID { get; set; }

		/// <summary>
		/// Gets or Sets BillToState
		/// </summary>
		[DataMember(Name = "BillToState", EmitDefaultValue = false)]
		public string BillToState { get; set; }

		/// <summary>
		/// Gets or Sets BillToZipCode
		/// </summary>
		[DataMember(Name = "BillToZipCode", EmitDefaultValue = false)]
		public string BillToZipCode { get; set; }

		/// <summary>
		/// Gets or Sets City
		/// </summary>
		[DataMember(Name = "City", EmitDefaultValue = false)]
		public string City { get; set; }

		/// <summary>
		/// Gets or Sets Classification
		/// </summary>
		[DataMember(Name = "Classification", EmitDefaultValue = false)]
		public int? Classification { get; set; }

		/// <summary>
		/// Gets or Sets CompanyName
		/// </summary>
		[DataMember(Name = "CompanyName", EmitDefaultValue = false)]
		public string CompanyName { get; set; }

		/// <summary>
		/// Gets or Sets CompanyNumber
		/// </summary>
		[DataMember(Name = "CompanyNumber", EmitDefaultValue = false)]
		public string CompanyNumber { get; set; }

		/// <summary>
		/// Gets or Sets CompanyType
		/// </summary>
		[DataMember(Name = "CompanyType", EmitDefaultValue = false)]
		public int? CompanyType { get; set; }

		/// <summary>
		/// Gets or Sets CompetitorID
		/// </summary>
		[DataMember(Name = "CompetitorID", EmitDefaultValue = false)]
		public int? CompetitorID { get; set; }

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
		/// Gets or Sets CreatedByResourceID
		/// </summary>
		[DataMember(Name = "CreatedByResourceID", EmitDefaultValue = false)]
		public int? CreatedByResourceID { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyID
		/// </summary>
		[DataMember(Name = "CurrencyID", EmitDefaultValue = false)]
		public int? CurrencyID { get; set; }

		/// <summary>
		/// Gets or Sets Fax
		/// </summary>
		[DataMember(Name = "Fax", EmitDefaultValue = false)]
		public string Fax { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceEmailMessageID
		/// </summary>
		[DataMember(Name = "InvoiceEmailMessageID", EmitDefaultValue = false)]
		public int? InvoiceEmailMessageID { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceMethod
		/// </summary>
		[DataMember(Name = "InvoiceMethod", EmitDefaultValue = false)]
		public int? InvoiceMethod { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceNonContractItemsToParentCompany
		/// </summary>
		[DataMember(Name = "InvoiceNonContractItemsToParentCompany", EmitDefaultValue = false)]
		public bool? InvoiceNonContractItemsToParentCompany { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceTemplateID
		/// </summary>
		[DataMember(Name = "InvoiceTemplateID", EmitDefaultValue = false)]
		public int? InvoiceTemplateID { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsClientPortalActive
		/// </summary>
		[DataMember(Name = "IsClientPortalActive", EmitDefaultValue = false)]
		public bool? IsClientPortalActive { get; set; }

		/// <summary>
		/// Gets or Sets IsEnabledForComanaged
		/// </summary>
		[DataMember(Name = "IsEnabledForComanaged", EmitDefaultValue = false)]
		public bool? IsEnabledForComanaged { get; set; }

		/// <summary>
		/// Gets or Sets IsTaskFireActive
		/// </summary>
		[DataMember(Name = "IsTaskFireActive", EmitDefaultValue = false)]
		public bool? IsTaskFireActive { get; set; }

		/// <summary>
		/// Gets or Sets IsTaxExempt
		/// </summary>
		[DataMember(Name = "IsTaxExempt", EmitDefaultValue = false)]
		public bool? IsTaxExempt { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityDate
		/// </summary>
		[DataMember(Name = "LastActivityDate", EmitDefaultValue = false)]
		public DateTime? LastActivityDate { get; set; }

		/// <summary>
		/// Gets or Sets LastTrackedModifiedDateTime
		/// </summary>
		[DataMember(Name = "LastTrackedModifiedDateTime", EmitDefaultValue = false)]
		public DateTime? LastTrackedModifiedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets MarketSegmentID
		/// </summary>
		[DataMember(Name = "MarketSegmentID", EmitDefaultValue = false)]
		public int? MarketSegmentID { get; set; }

		/// <summary>
		/// Gets or Sets OwnerResourceID
		/// </summary>
		[DataMember(Name = "OwnerResourceID", EmitDefaultValue = false)]
		public int? OwnerResourceID { get; set; }

		/// <summary>
		/// Gets or Sets ParentCompanyID
		/// </summary>
		[DataMember(Name = "ParentCompanyID", EmitDefaultValue = false)]
		public int? ParentCompanyID { get; set; }

		/// <summary>
		/// Gets or Sets Phone
		/// </summary>
		[DataMember(Name = "Phone", EmitDefaultValue = false)]
		public string Phone { get; set; }

		/// <summary>
		/// Gets or Sets PostalCode
		/// </summary>
		[DataMember(Name = "PostalCode", EmitDefaultValue = false)]
		public string PostalCode { get; set; }

		/// <summary>
		/// Gets or Sets QuoteEmailMessageID
		/// </summary>
		[DataMember(Name = "QuoteEmailMessageID", EmitDefaultValue = false)]
		public int? QuoteEmailMessageID { get; set; }

		/// <summary>
		/// Gets or Sets QuoteTemplateID
		/// </summary>
		[DataMember(Name = "QuoteTemplateID", EmitDefaultValue = false)]
		public int? QuoteTemplateID { get; set; }

		/// <summary>
		/// Gets or Sets SICCode
		/// </summary>
		[DataMember(Name = "SICCode", EmitDefaultValue = false)]
		public string SICCode { get; set; }

		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "State", EmitDefaultValue = false)]
		public string State { get; set; }

		/// <summary>
		/// Gets or Sets StockMarket
		/// </summary>
		[DataMember(Name = "StockMarket", EmitDefaultValue = false)]
		public string StockMarket { get; set; }

		/// <summary>
		/// Gets or Sets StockSymbol
		/// </summary>
		[DataMember(Name = "StockSymbol", EmitDefaultValue = false)]
		public string StockSymbol { get; set; }

		/// <summary>
		/// Gets or Sets SurveyCompanyRating
		/// </summary>
		[DataMember(Name = "SurveyCompanyRating", EmitDefaultValue = false)]
		public double? SurveyCompanyRating { get; set; }

		/// <summary>
		/// Gets or Sets TaxID
		/// </summary>
		[DataMember(Name = "TaxID", EmitDefaultValue = false)]
		public string TaxID { get; set; }

		/// <summary>
		/// Gets or Sets TaxRegionID
		/// </summary>
		[DataMember(Name = "TaxRegionID", EmitDefaultValue = false)]
		public int? TaxRegionID { get; set; }

		/// <summary>
		/// Gets or Sets TerritoryID
		/// </summary>
		[DataMember(Name = "TerritoryID", EmitDefaultValue = false)]
		public int? TerritoryID { get; set; }

		/// <summary>
		/// Gets or Sets WebAddress
		/// </summary>
		[DataMember(Name = "WebAddress", EmitDefaultValue = false)]
		public string WebAddress { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
