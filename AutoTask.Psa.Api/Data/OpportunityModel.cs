using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// OpportunityModel
	/// </summary>
	[DataContract]
	public partial class OpportunityModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AdvancedField1
		/// </summary>
		[DataMember(Name = "AdvancedField1", EmitDefaultValue = false)]
		public double? AdvancedField1 { get; set; }

		/// <summary>
		/// Gets or Sets AdvancedField2
		/// </summary>
		[DataMember(Name = "AdvancedField2", EmitDefaultValue = false)]
		public double? AdvancedField2 { get; set; }

		/// <summary>
		/// Gets or Sets AdvancedField3
		/// </summary>
		[DataMember(Name = "AdvancedField3", EmitDefaultValue = false)]
		public double? AdvancedField3 { get; set; }

		/// <summary>
		/// Gets or Sets AdvancedField4
		/// </summary>
		[DataMember(Name = "AdvancedField4", EmitDefaultValue = false)]
		public double? AdvancedField4 { get; set; }

		/// <summary>
		/// Gets or Sets AdvancedField5
		/// </summary>
		[DataMember(Name = "AdvancedField5", EmitDefaultValue = false)]
		public double? AdvancedField5 { get; set; }

		/// <summary>
		/// Gets or Sets Amount
		/// </summary>
		[DataMember(Name = "Amount", EmitDefaultValue = false)]
		public double? Amount { get; set; }

		/// <summary>
		/// Gets or Sets AssessmentScore
		/// </summary>
		[DataMember(Name = "AssessmentScore", EmitDefaultValue = false)]
		public double? AssessmentScore { get; set; }

		/// <summary>
		/// Gets or Sets Barriers
		/// </summary>
		[DataMember(Name = "Barriers", EmitDefaultValue = false)]
		public string Barriers { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ClosedDate
		/// </summary>
		[DataMember(Name = "ClosedDate", EmitDefaultValue = false)]
		public DateTime? ClosedDate { get; set; }

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
		/// Gets or Sets Cost
		/// </summary>
		[DataMember(Name = "Cost", EmitDefaultValue = false)]
		public double? Cost { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate", EmitDefaultValue = false)]
		public DateTime? CreateDate { get; set; }

		/// <summary>
		/// Gets or Sets CreatorResourceID
		/// </summary>
		[DataMember(Name = "CreatorResourceID", EmitDefaultValue = false)]
		public int? CreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets HelpNeeded
		/// </summary>
		[DataMember(Name = "HelpNeeded", EmitDefaultValue = false)]
		public string HelpNeeded { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets LastActivity
		/// </summary>
		[DataMember(Name = "LastActivity", EmitDefaultValue = false)]
		public DateTime? LastActivity { get; set; }

		/// <summary>
		/// Gets or Sets LeadSource
		/// </summary>
		[DataMember(Name = "LeadSource", EmitDefaultValue = false)]
		public int? LeadSource { get; set; }

		/// <summary>
		/// Gets or Sets LossReason
		/// </summary>
		[DataMember(Name = "LossReason", EmitDefaultValue = false)]
		public int? LossReason { get; set; }

		/// <summary>
		/// Gets or Sets LossReasonDetail
		/// </summary>
		[DataMember(Name = "LossReasonDetail", EmitDefaultValue = false)]
		public string LossReasonDetail { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets LostDate
		/// </summary>
		[DataMember(Name = "LostDate", EmitDefaultValue = false)]
		public DateTime? LostDate { get; set; }

		/// <summary>
		/// Gets or Sets Market
		/// </summary>
		[DataMember(Name = "Market", EmitDefaultValue = false)]
		public string Market { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets MonthlyCost
		/// </summary>
		[DataMember(Name = "MonthlyCost", EmitDefaultValue = false)]
		public double? MonthlyCost { get; set; }

		/// <summary>
		/// Gets or Sets MonthlyRevenue
		/// </summary>
		[DataMember(Name = "MonthlyRevenue", EmitDefaultValue = false)]
		public double? MonthlyRevenue { get; set; }

		/// <summary>
		/// Gets or Sets NextStep
		/// </summary>
		[DataMember(Name = "NextStep", EmitDefaultValue = false)]
		public string NextStep { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets OnetimeCost
		/// </summary>
		[DataMember(Name = "OnetimeCost", EmitDefaultValue = false)]
		public double? OnetimeCost { get; set; }

		/// <summary>
		/// Gets or Sets OnetimeRevenue
		/// </summary>
		[DataMember(Name = "OnetimeRevenue", EmitDefaultValue = false)]
		public double? OnetimeRevenue { get; set; }

		/// <summary>
		/// Gets or Sets OpportunityCategoryID
		/// </summary>
		[DataMember(Name = "OpportunityCategoryID", EmitDefaultValue = false)]
		public int? OpportunityCategoryID { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets OwnerResourceID
		/// </summary>
		[DataMember(Name = "OwnerResourceID", EmitDefaultValue = false)]
		public int? OwnerResourceID { get; set; }

		/// <summary>
		/// Gets or Sets PrimaryCompetitor
		/// </summary>
		[DataMember(Name = "PrimaryCompetitor", EmitDefaultValue = false)]
		public int? PrimaryCompetitor { get; set; }

		/// <summary>
		/// Gets or Sets Probability
		/// </summary>
		[DataMember(Name = "Probability", EmitDefaultValue = false)]
		public int? Probability { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public int? ProductID { get; set; }

		/// <summary>
		/// Gets or Sets ProjectedCloseDate
		/// </summary>
		[DataMember(Name = "ProjectedCloseDate", EmitDefaultValue = false)]
		public DateTime? ProjectedCloseDate { get; set; }

		/// <summary>
		/// Gets or Sets PromisedFulfillmentDate
		/// </summary>
		[DataMember(Name = "PromisedFulfillmentDate", EmitDefaultValue = false)]
		public DateTime? PromisedFulfillmentDate { get; set; }

		/// <summary>
		/// Gets or Sets PromotionName
		/// </summary>
		[DataMember(Name = "PromotionName", EmitDefaultValue = false)]
		public string PromotionName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets QuarterlyCost
		/// </summary>
		[DataMember(Name = "QuarterlyCost", EmitDefaultValue = false)]
		public double? QuarterlyCost { get; set; }

		/// <summary>
		/// Gets or Sets QuarterlyRevenue
		/// </summary>
		[DataMember(Name = "QuarterlyRevenue", EmitDefaultValue = false)]
		public double? QuarterlyRevenue { get; set; }

		/// <summary>
		/// Gets or Sets Rating
		/// </summary>
		[DataMember(Name = "Rating", EmitDefaultValue = false)]
		public int? Rating { get; set; }

		/// <summary>
		/// Gets or Sets RelationshipAssessmentScore
		/// </summary>
		[DataMember(Name = "RelationshipAssessmentScore", EmitDefaultValue = false)]
		public double? RelationshipAssessmentScore { get; set; }

		/// <summary>
		/// Gets or Sets RevenueSpread
		/// </summary>
		[DataMember(Name = "RevenueSpread", EmitDefaultValue = false)]
		public int? RevenueSpread { get; set; }

		/// <summary>
		/// Gets or Sets RevenueSpreadUnit
		/// </summary>
		[DataMember(Name = "RevenueSpreadUnit", EmitDefaultValue = false)]
		public string RevenueSpreadUnit { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets SalesOrderID
		/// </summary>
		[DataMember(Name = "SalesOrderID", EmitDefaultValue = false)]
		public int? SalesOrderID { get; set; }

		/// <summary>
		/// Gets or Sets SalesProcessPercentComplete
		/// </summary>
		[DataMember(Name = "SalesProcessPercentComplete", EmitDefaultValue = false)]
		public int? SalesProcessPercentComplete { get; set; }

		/// <summary>
		/// Gets or Sets SemiannualCost
		/// </summary>
		[DataMember(Name = "SemiannualCost", EmitDefaultValue = false)]
		public double? SemiannualCost { get; set; }

		/// <summary>
		/// Gets or Sets SemiannualRevenue
		/// </summary>
		[DataMember(Name = "SemiannualRevenue", EmitDefaultValue = false)]
		public double? SemiannualRevenue { get; set; }

		/// <summary>
		/// Gets or Sets Stage
		/// </summary>
		[DataMember(Name = "Stage", EmitDefaultValue = false)]
		public int? Stage { get; set; }

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
		/// Gets or Sets TechnicalAssessmentScore
		/// </summary>
		[DataMember(Name = "TechnicalAssessmentScore", EmitDefaultValue = false)]
		public double? TechnicalAssessmentScore { get; set; }

		/// <summary>
		/// Gets or Sets ThroughDate
		/// </summary>
		[DataMember(Name = "ThroughDate", EmitDefaultValue = false)]
		public DateTime? ThroughDate { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets TotalAmountMonths
		/// </summary>
		[DataMember(Name = "TotalAmountMonths", EmitDefaultValue = false)]
		public int? TotalAmountMonths { get; set; }

		/// <summary>
		/// Gets or Sets UseQuoteTotals
		/// </summary>
		[DataMember(Name = "UseQuoteTotals", EmitDefaultValue = false)]
		public bool? UseQuoteTotals { get; set; }

		/// <summary>
		/// Gets or Sets WinReason
		/// </summary>
		[DataMember(Name = "WinReason", EmitDefaultValue = false)]
		public int? WinReason { get; set; }

		/// <summary>
		/// Gets or Sets WinReasonDetail
		/// </summary>
		[DataMember(Name = "WinReasonDetail", EmitDefaultValue = false)]
		public string WinReasonDetail { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets YearlyCost
		/// </summary>
		[DataMember(Name = "YearlyCost", EmitDefaultValue = false)]
		public double? YearlyCost { get; set; }

		/// <summary>
		/// Gets or Sets YearlyRevenue
		/// </summary>
		[DataMember(Name = "YearlyRevenue", EmitDefaultValue = false)]
		public double? YearlyRevenue { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
