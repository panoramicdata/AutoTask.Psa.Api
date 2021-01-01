using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractModel
	/// </summary>
	[DataContract]
	public partial class ContractModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BillingPreference
		/// </summary>
		[DataMember(Name = "BillingPreference", EmitDefaultValue = false)]
		public int? BillingPreference { get; set; }

		/// <summary>
		/// Gets or Sets BillToCompanyContactID
		/// </summary>
		[DataMember(Name = "BillToCompanyContactID", EmitDefaultValue = false)]
		public int? BillToCompanyContactID { get; set; }

		/// <summary>
		/// Gets or Sets BillToCompanyID
		/// </summary>
		[DataMember(Name = "BillToCompanyID", EmitDefaultValue = false)]
		public int? BillToCompanyID { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public int? ContactID { get; set; }

		/// <summary>
		/// Gets or Sets ContactName
		/// </summary>
		[DataMember(Name = "ContactName", EmitDefaultValue = false)]
		public string ContactName { get; set; }

		/// <summary>
		/// Gets or Sets ContractCategory
		/// </summary>
		[DataMember(Name = "ContractCategory", EmitDefaultValue = false)]
		public int? ContractCategory { get; set; }

		/// <summary>
		/// Gets or Sets ContractExclusionSetID
		/// </summary>
		[DataMember(Name = "ContractExclusionSetID", EmitDefaultValue = false)]
		public int? ContractExclusionSetID { get; set; }

		/// <summary>
		/// Gets or Sets ContractName
		/// </summary>
		[DataMember(Name = "ContractName", EmitDefaultValue = false)]
		public string ContractName { get; set; }

		/// <summary>
		/// Gets or Sets ContractNumber
		/// </summary>
		[DataMember(Name = "ContractNumber", EmitDefaultValue = false)]
		public string ContractNumber { get; set; }

		/// <summary>
		/// Gets or Sets ContractPeriodType
		/// </summary>
		[DataMember(Name = "ContractPeriodType", EmitDefaultValue = false)]
		public int? ContractPeriodType { get; set; }

		/// <summary>
		/// Gets or Sets ContractType
		/// </summary>
		[DataMember(Name = "ContractType", EmitDefaultValue = false)]
		public int? ContractType { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets EndDate
		/// </summary>
		[DataMember(Name = "EndDate", EmitDefaultValue = false)]
		public DateTime? EndDate { get; set; }

		/// <summary>
		/// Gets or Sets EstimatedCost
		/// </summary>
		[DataMember(Name = "EstimatedCost", EmitDefaultValue = false)]
		public double? EstimatedCost { get; set; }

		/// <summary>
		/// Gets or Sets EstimatedHours
		/// </summary>
		[DataMember(Name = "EstimatedHours", EmitDefaultValue = false)]
		public double? EstimatedHours { get; set; }

		/// <summary>
		/// Gets or Sets EstimatedRevenue
		/// </summary>
		[DataMember(Name = "EstimatedRevenue", EmitDefaultValue = false)]
		public double? EstimatedRevenue { get; set; }

		/// <summary>
		/// Gets or Sets ExclusionContractID
		/// </summary>
		[DataMember(Name = "ExclusionContractID", EmitDefaultValue = false)]
		public long? ExclusionContractID { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyOverageBillingRate
		/// </summary>
		[DataMember(Name = "InternalCurrencyOverageBillingRate", EmitDefaultValue = false)]
		public double? InternalCurrencyOverageBillingRate { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencySetupFee
		/// </summary>
		[DataMember(Name = "InternalCurrencySetupFee", EmitDefaultValue = false)]
		public double? InternalCurrencySetupFee { get; set; }

		/// <summary>
		/// Gets or Sets IsCompliant
		/// </summary>
		[DataMember(Name = "IsCompliant", EmitDefaultValue = false)]
		public bool? IsCompliant { get; set; }

		/// <summary>
		/// Gets or Sets IsDefaultContract
		/// </summary>
		[DataMember(Name = "IsDefaultContract", EmitDefaultValue = false)]
		public bool? IsDefaultContract { get; set; }

		/// <summary>
		/// Gets or Sets OpportunityID
		/// </summary>
		[DataMember(Name = "OpportunityID", EmitDefaultValue = false)]
		public int? OpportunityID { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets OverageBillingRate
		/// </summary>
		[DataMember(Name = "OverageBillingRate", EmitDefaultValue = false)]
		public double? OverageBillingRate { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Gets or Sets RenewedContractID
		/// </summary>
		[DataMember(Name = "RenewedContractID", EmitDefaultValue = false)]
		public long? RenewedContractID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceLevelAgreementID
		/// </summary>
		[DataMember(Name = "ServiceLevelAgreementID", EmitDefaultValue = false)]
		public int? ServiceLevelAgreementID { get; set; }

		/// <summary>
		/// Gets or Sets SetupFee
		/// </summary>
		[DataMember(Name = "SetupFee", EmitDefaultValue = false)]
		public double? SetupFee { get; set; }

		/// <summary>
		/// Gets or Sets SetupFeeBillingCodeID
		/// </summary>
		[DataMember(Name = "SetupFeeBillingCodeID", EmitDefaultValue = false)]
		public long? SetupFeeBillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets StartDate
		/// </summary>
		[DataMember(Name = "StartDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets TimeReportingRequiresStartAndStopTimes
		/// </summary>
		[DataMember(Name = "TimeReportingRequiresStartAndStopTimes", EmitDefaultValue = false)]
		public int? TimeReportingRequiresStartAndStopTimes { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
