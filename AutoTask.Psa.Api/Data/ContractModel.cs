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
		/// Initializes a new instance of the <see cref="ContractModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BillingPreference">BillingPreference.</param>
		/// <param name="BillToCompanyContactID">BillToCompanyContactID.</param>
		/// <param name="BillToCompanyID">BillToCompanyID.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="ContactID">ContactID.</param>
		/// <param name="ContactName">ContactName.</param>
		/// <param name="ContractCategory">ContractCategory.</param>
		/// <param name="ContractExclusionSetID">ContractExclusionSetID.</param>
		/// <param name="ContractName">ContractName.</param>
		/// <param name="ContractNumber">ContractNumber.</param>
		/// <param name="ContractPeriodType">ContractPeriodType.</param>
		/// <param name="ContractType">ContractType.</param>
		/// <param name="Description">Description.</param>
		/// <param name="EndDate">EndDate.</param>
		/// <param name="EstimatedCost">EstimatedCost.</param>
		/// <param name="EstimatedHours">EstimatedHours.</param>
		/// <param name="EstimatedRevenue">EstimatedRevenue.</param>
		/// <param name="ExclusionContractID">ExclusionContractID.</param>
		/// <param name="InternalCurrencyOverageBillingRate">InternalCurrencyOverageBillingRate.</param>
		/// <param name="InternalCurrencySetupFee">InternalCurrencySetupFee.</param>
		/// <param name="IsCompliant">IsCompliant.</param>
		/// <param name="IsDefaultContract">IsDefaultContract.</param>
		/// <param name="OpportunityID">OpportunityID.</param>
		/// <param name="OrganizationalLevelAssociationID">OrganizationalLevelAssociationID.</param>
		/// <param name="OverageBillingRate">OverageBillingRate.</param>
		/// <param name="PurchaseOrderNumber">PurchaseOrderNumber.</param>
		/// <param name="RenewedContractID">RenewedContractID.</param>
		/// <param name="ServiceLevelAgreementID">ServiceLevelAgreementID.</param>
		/// <param name="SetupFee">SetupFee.</param>
		/// <param name="SetupFeeBillingCodeID">SetupFeeBillingCodeID.</param>
		/// <param name="StartDate">StartDate.</param>
		/// <param name="Status">Status.</param>
		/// <param name="TimeReportingRequiresStartAndStopTimes">TimeReportingRequiresStartAndStopTimes.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractModel(long? Id = default, int? BillingPreference = default, int? BillToCompanyContactID = default, int? BillToCompanyID = default, int? CompanyID = default, int? ContactID = default, string ContactName = default, int? ContractCategory = default, int? ContractExclusionSetID = default, string ContractName = default, string ContractNumber = default, int? ContractPeriodType = default, int? ContractType = default, string Description = default, DateTime? EndDate = default, double? EstimatedCost = default, double? EstimatedHours = default, double? EstimatedRevenue = default, long? ExclusionContractID = default, double? InternalCurrencyOverageBillingRate = default, double? InternalCurrencySetupFee = default, bool? IsCompliant = default, bool? IsDefaultContract = default, int? OpportunityID = default, int? OrganizationalLevelAssociationID = default, double? OverageBillingRate = default, string PurchaseOrderNumber = default, long? RenewedContractID = default, int? ServiceLevelAgreementID = default, double? SetupFee = default, long? SetupFeeBillingCodeID = default, DateTime? StartDate = default, int? Status = default, int? TimeReportingRequiresStartAndStopTimes = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BillingPreference = BillingPreference;
			this.BillToCompanyContactID = BillToCompanyContactID;
			this.BillToCompanyID = BillToCompanyID;
			this.CompanyID = CompanyID;
			this.ContactID = ContactID;
			this.ContactName = ContactName;
			this.ContractCategory = ContractCategory;
			this.ContractExclusionSetID = ContractExclusionSetID;
			this.ContractName = ContractName;
			this.ContractNumber = ContractNumber;
			this.ContractPeriodType = ContractPeriodType;
			this.ContractType = ContractType;
			this.Description = Description;
			this.EndDate = EndDate;
			this.EstimatedCost = EstimatedCost;
			this.EstimatedHours = EstimatedHours;
			this.EstimatedRevenue = EstimatedRevenue;
			this.ExclusionContractID = ExclusionContractID;
			this.InternalCurrencyOverageBillingRate = InternalCurrencyOverageBillingRate;
			this.InternalCurrencySetupFee = InternalCurrencySetupFee;
			this.IsCompliant = IsCompliant;
			this.IsDefaultContract = IsDefaultContract;
			this.OpportunityID = OpportunityID;
			this.OrganizationalLevelAssociationID = OrganizationalLevelAssociationID;
			this.OverageBillingRate = OverageBillingRate;
			this.PurchaseOrderNumber = PurchaseOrderNumber;
			this.RenewedContractID = RenewedContractID;
			this.ServiceLevelAgreementID = ServiceLevelAgreementID;
			this.SetupFee = SetupFee;
			this.SetupFeeBillingCodeID = SetupFeeBillingCodeID;
			this.StartDate = StartDate;
			this.Status = Status;
			this.TimeReportingRequiresStartAndStopTimes = TimeReportingRequiresStartAndStopTimes;
			this.UserDefinedFields = UserDefinedFields;
		}

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
