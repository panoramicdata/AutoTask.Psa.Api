namespace AutoTask.Psa.Api.Data;

/// <summary>
/// OpportunityModel
/// </summary>
[DataContract]
public class OpportunityModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AdvancedField1
	/// </summary>
	[DataMember(Name = "AdvancedField1")]
	public double? AdvancedField1 { get; set; }

	/// <summary>
	/// Gets or Sets AdvancedField2
	/// </summary>
	[DataMember(Name = "AdvancedField2")]
	public double? AdvancedField2 { get; set; }

	/// <summary>
	/// Gets or Sets AdvancedField3
	/// </summary>
	[DataMember(Name = "AdvancedField3")]
	public double? AdvancedField3 { get; set; }

	/// <summary>
	/// Gets or Sets AdvancedField4
	/// </summary>
	[DataMember(Name = "AdvancedField4")]
	public double? AdvancedField4 { get; set; }

	/// <summary>
	/// Gets or Sets AdvancedField5
	/// </summary>
	[DataMember(Name = "AdvancedField5")]
	public double? AdvancedField5 { get; set; }

	/// <summary>
	/// Gets or Sets Amount
	/// </summary>
	[DataMember(Name = "Amount")]
	public double? Amount { get; set; }

	/// <summary>
	/// Gets or Sets AssessmentScore
	/// </summary>
	[DataMember(Name = "AssessmentScore")]
	public double? AssessmentScore { get; set; }

	/// <summary>
	/// Gets or Sets Barriers
	/// </summary>
	[DataMember(Name = "Barriers")]
	public string Barriers { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ClosedDate
	/// </summary>
	[DataMember(Name = "ClosedDate")]
	public DateTime? ClosedDate { get; set; }

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
	/// Gets or Sets Cost
	/// </summary>
	[DataMember(Name = "Cost")]
	public double? Cost { get; set; }

	/// <summary>
	/// Gets or Sets CreateDate
	/// </summary>
	[DataMember(Name = "CreateDate")]
	public DateTime? CreateDate { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public int? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets HelpNeeded
	/// </summary>
	[DataMember(Name = "HelpNeeded")]
	public string HelpNeeded { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets LastActivity
	/// </summary>
	[DataMember(Name = "LastActivity")]
	public DateTime? LastActivity { get; set; }

	/// <summary>
	/// Gets or Sets LeadSource
	/// </summary>
	[DataMember(Name = "LeadSource")]
	public int? LeadSource { get; set; }

	/// <summary>
	/// Gets or Sets LossReason
	/// </summary>
	[DataMember(Name = "LossReason")]
	public int? LossReason { get; set; }

	/// <summary>
	/// Gets or Sets LossReasonDetail
	/// </summary>
	[DataMember(Name = "LossReasonDetail")]
	public string LossReasonDetail { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets LostDate
	/// </summary>
	[DataMember(Name = "LostDate")]
	public DateTime? LostDate { get; set; }

	/// <summary>
	/// Gets or Sets Market
	/// </summary>
	[DataMember(Name = "Market")]
	public string Market { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets MonthlyCost
	/// </summary>
	[DataMember(Name = "MonthlyCost")]
	public double? MonthlyCost { get; set; }

	/// <summary>
	/// Gets or Sets MonthlyRevenue
	/// </summary>
	[DataMember(Name = "MonthlyRevenue")]
	public double? MonthlyRevenue { get; set; }

	/// <summary>
	/// Gets or Sets NextStep
	/// </summary>
	[DataMember(Name = "NextStep")]
	public string NextStep { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets OnetimeCost
	/// </summary>
	[DataMember(Name = "OnetimeCost")]
	public double? OnetimeCost { get; set; }

	/// <summary>
	/// Gets or Sets OnetimeRevenue
	/// </summary>
	[DataMember(Name = "OnetimeRevenue")]
	public double? OnetimeRevenue { get; set; }

	/// <summary>
	/// Gets or Sets OpportunityCategoryID
	/// </summary>
	[DataMember(Name = "OpportunityCategoryID")]
	public int? OpportunityCategoryID { get; set; }

	/// <summary>
	/// Gets or Sets OrganizationalLevelAssociationID
	/// </summary>
	[DataMember(Name = "OrganizationalLevelAssociationID")]
	public int? OrganizationalLevelAssociationID { get; set; }

	/// <summary>
	/// Gets or Sets OwnerResourceID
	/// </summary>
	[DataMember(Name = "OwnerResourceID")]
	public int? OwnerResourceID { get; set; }

	/// <summary>
	/// Gets or Sets PrimaryCompetitor
	/// </summary>
	[DataMember(Name = "PrimaryCompetitor")]
	public int? PrimaryCompetitor { get; set; }

	/// <summary>
	/// Gets or Sets Probability
	/// </summary>
	[DataMember(Name = "Probability")]
	public int? Probability { get; set; }

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets ProjectedCloseDate
	/// </summary>
	[DataMember(Name = "ProjectedCloseDate")]
	public DateTime? ProjectedCloseDate { get; set; }

	/// <summary>
	/// Gets or Sets PromisedFulfillmentDate
	/// </summary>
	[DataMember(Name = "PromisedFulfillmentDate")]
	public DateTime? PromisedFulfillmentDate { get; set; }

	/// <summary>
	/// Gets or Sets PromotionName
	/// </summary>
	[DataMember(Name = "PromotionName")]
	public string PromotionName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets QuarterlyCost
	/// </summary>
	[DataMember(Name = "QuarterlyCost")]
	public double? QuarterlyCost { get; set; }

	/// <summary>
	/// Gets or Sets QuarterlyRevenue
	/// </summary>
	[DataMember(Name = "QuarterlyRevenue")]
	public double? QuarterlyRevenue { get; set; }

	/// <summary>
	/// Gets or Sets Rating
	/// </summary>
	[DataMember(Name = "Rating")]
	public int? Rating { get; set; }

	/// <summary>
	/// Gets or Sets RelationshipAssessmentScore
	/// </summary>
	[DataMember(Name = "RelationshipAssessmentScore")]
	public double? RelationshipAssessmentScore { get; set; }

	/// <summary>
	/// Gets or Sets RevenueSpread
	/// </summary>
	[DataMember(Name = "RevenueSpread")]
	public int? RevenueSpread { get; set; }

	/// <summary>
	/// Gets or Sets RevenueSpreadUnit
	/// </summary>
	[DataMember(Name = "RevenueSpreadUnit")]
	public string RevenueSpreadUnit { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SalesOrderID
	/// </summary>
	[DataMember(Name = "SalesOrderID")]
	public int? SalesOrderID { get; set; }

	/// <summary>
	/// Gets or Sets SalesProcessPercentComplete
	/// </summary>
	[DataMember(Name = "SalesProcessPercentComplete")]
	public int? SalesProcessPercentComplete { get; set; }

	/// <summary>
	/// Gets or Sets SemiannualCost
	/// </summary>
	[DataMember(Name = "SemiannualCost")]
	public double? SemiannualCost { get; set; }

	/// <summary>
	/// Gets or Sets SemiannualRevenue
	/// </summary>
	[DataMember(Name = "SemiannualRevenue")]
	public double? SemiannualRevenue { get; set; }

	/// <summary>
	/// Gets or Sets Stage
	/// </summary>
	[DataMember(Name = "Stage")]
	public int? Stage { get; set; }

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
	/// Gets or Sets TechnicalAssessmentScore
	/// </summary>
	[DataMember(Name = "TechnicalAssessmentScore")]
	public double? TechnicalAssessmentScore { get; set; }

	/// <summary>
	/// Gets or Sets ThroughDate
	/// </summary>
	[DataMember(Name = "ThroughDate")]
	public DateTime? ThroughDate { get; set; }

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "Title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TotalAmountMonths
	/// </summary>
	[DataMember(Name = "TotalAmountMonths")]
	public int? TotalAmountMonths { get; set; }

	/// <summary>
	/// Gets or Sets UseQuoteTotals
	/// </summary>
	[DataMember(Name = "UseQuoteTotals")]
	public bool? UseQuoteTotals { get; set; }

	/// <summary>
	/// Gets or Sets WinReason
	/// </summary>
	[DataMember(Name = "WinReason")]
	public int? WinReason { get; set; }

	/// <summary>
	/// Gets or Sets WinReasonDetail
	/// </summary>
	[DataMember(Name = "WinReasonDetail")]
	public string WinReasonDetail { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets YearlyCost
	/// </summary>
	[DataMember(Name = "YearlyCost")]
	public double? YearlyCost { get; set; }

	/// <summary>
	/// Gets or Sets YearlyRevenue
	/// </summary>
	[DataMember(Name = "YearlyRevenue")]
	public double? YearlyRevenue { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
