namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractModel
/// </summary>
[DataContract]
public partial class ContractModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets BillingPreference
	/// </summary>
	[DataMember(Name = "BillingPreference")]
	public int? BillingPreference { get; set; }

	/// <summary>
	/// Gets or Sets BillToCompanyContactID
	/// </summary>
	[DataMember(Name = "BillToCompanyContactID")]
	public int? BillToCompanyContactID { get; set; }

	/// <summary>
	/// Gets or Sets BillToCompanyID
	/// </summary>
	[DataMember(Name = "BillToCompanyID")]
	public int? BillToCompanyID { get; set; }

	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets ContactID
	/// </summary>
	[DataMember(Name = "ContactID")]
	public int? ContactID { get; set; }

	/// <summary>
	/// Gets or Sets ContactName
	/// </summary>
	[DataMember(Name = "ContactName")]
	public string ContactName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ContractCategory
	/// </summary>
	[DataMember(Name = "ContractCategory")]
	public int? ContractCategory { get; set; }

	/// <summary>
	/// Gets or Sets ContractExclusionSetID
	/// </summary>
	[DataMember(Name = "ContractExclusionSetID")]
	public int? ContractExclusionSetID { get; set; }

	/// <summary>
	/// Gets or Sets ContractName
	/// </summary>
	[DataMember(Name = "ContractName")]
	public string ContractName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ContractNumber
	/// </summary>
	[DataMember(Name = "ContractNumber")]
	public string ContractNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ContractPeriodType
	/// </summary>
	[DataMember(Name = "ContractPeriodType")]
	public int? ContractPeriodType { get; set; }

	/// <summary>
	/// Gets or Sets ContractType
	/// </summary>
	[DataMember(Name = "ContractType")]
	public int? ContractType { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets EndDate
	/// </summary>
	[DataMember(Name = "EndDate")]
	public DateTime? EndDate { get; set; }

	/// <summary>
	/// Gets or Sets EstimatedCost
	/// </summary>
	[DataMember(Name = "EstimatedCost")]
	public double? EstimatedCost { get; set; }

	/// <summary>
	/// Gets or Sets EstimatedHours
	/// </summary>
	[DataMember(Name = "EstimatedHours")]
	public double? EstimatedHours { get; set; }

	/// <summary>
	/// Gets or Sets EstimatedRevenue
	/// </summary>
	[DataMember(Name = "EstimatedRevenue")]
	public double? EstimatedRevenue { get; set; }

	/// <summary>
	/// Gets or Sets ExclusionContractID
	/// </summary>
	[DataMember(Name = "ExclusionContractID")]
	public long? ExclusionContractID { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencyOverageBillingRate
	/// </summary>
	[DataMember(Name = "InternalCurrencyOverageBillingRate")]
	public double? InternalCurrencyOverageBillingRate { get; set; }

	/// <summary>
	/// Gets or Sets InternalCurrencySetupFee
	/// </summary>
	[DataMember(Name = "InternalCurrencySetupFee")]
	public double? InternalCurrencySetupFee { get; set; }

	/// <summary>
	/// Gets or Sets IsCompliant
	/// </summary>
	[DataMember(Name = "IsCompliant")]
	public bool? IsCompliant { get; set; }

	/// <summary>
	/// Gets or Sets IsDefaultContract
	/// </summary>
	[DataMember(Name = "IsDefaultContract")]
	public bool? IsDefaultContract { get; set; }

	/// <summary>
	/// Gets or Sets OpportunityID
	/// </summary>
	[DataMember(Name = "OpportunityID")]
	public int? OpportunityID { get; set; }

	/// <summary>
	/// Gets or Sets OrganizationalLevelAssociationID
	/// </summary>
	[DataMember(Name = "OrganizationalLevelAssociationID")]
	public int? OrganizationalLevelAssociationID { get; set; }

	/// <summary>
	/// Gets or Sets OverageBillingRate
	/// </summary>
	[DataMember(Name = "OverageBillingRate")]
	public double? OverageBillingRate { get; set; }

	/// <summary>
	/// Gets or Sets PurchaseOrderNumber
	/// </summary>
	[DataMember(Name = "PurchaseOrderNumber")]
	public string PurchaseOrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RenewedContractID
	/// </summary>
	[DataMember(Name = "RenewedContractID")]
	public long? RenewedContractID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceLevelAgreementID
	/// </summary>
	[DataMember(Name = "ServiceLevelAgreementID")]
	public int? ServiceLevelAgreementID { get; set; }

	/// <summary>
	/// Gets or Sets SetupFee
	/// </summary>
	[DataMember(Name = "SetupFee")]
	public double? SetupFee { get; set; }

	/// <summary>
	/// Gets or Sets SetupFeeBillingCodeID
	/// </summary>
	[DataMember(Name = "SetupFeeBillingCodeID")]
	public long? SetupFeeBillingCodeID { get; set; }

	/// <summary>
	/// Gets or Sets StartDate
	/// </summary>
	[DataMember(Name = "StartDate")]
	public DateTime? StartDate { get; set; }

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

	/// <summary>
	/// Gets or Sets TimeReportingRequiresStartAndStopTimes
	/// </summary>
	[DataMember(Name = "TimeReportingRequiresStartAndStopTimes")]
	public int? TimeReportingRequiresStartAndStopTimes { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
