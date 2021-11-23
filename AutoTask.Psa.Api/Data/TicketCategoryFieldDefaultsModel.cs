namespace AutoTask.Psa.Api.Data;

/// <summary>
/// TicketCategoryFieldDefaultsModel
/// </summary>
[DataContract]
public partial class TicketCategoryFieldDefaultsModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "Description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets EstimatedHours
	/// </summary>
	[DataMember(Name = "EstimatedHours")]
	public double? EstimatedHours { get; set; }

	/// <summary>
	/// Gets or Sets IssueTypeID
	/// </summary>
	[DataMember(Name = "IssueTypeID")]
	public int? IssueTypeID { get; set; }

	/// <summary>
	/// Gets or Sets OrganizationalLevelAssociationID
	/// </summary>
	[DataMember(Name = "OrganizationalLevelAssociationID")]
	public int? OrganizationalLevelAssociationID { get; set; }

	/// <summary>
	/// Gets or Sets Priority
	/// </summary>
	[DataMember(Name = "Priority")]
	public int? Priority { get; set; }

	/// <summary>
	/// Gets or Sets PurchaseOrderNumber
	/// </summary>
	[DataMember(Name = "PurchaseOrderNumber")]
	public string PurchaseOrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets QueueID
	/// </summary>
	[DataMember(Name = "QueueID")]
	public int? QueueID { get; set; }

	/// <summary>
	/// Gets or Sets Resolution
	/// </summary>
	[DataMember(Name = "Resolution")]
	public string Resolution { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ServiceLevelAgreementID
	/// </summary>
	[DataMember(Name = "ServiceLevelAgreementID")]
	public int? ServiceLevelAgreementID { get; set; }

	/// <summary>
	/// Gets or Sets SourceID
	/// </summary>
	[DataMember(Name = "SourceID")]
	public int? SourceID { get; set; }

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "Status")]
	public int? Status { get; set; }

	/// <summary>
	/// Gets or Sets SubIssueTypeID
	/// </summary>
	[DataMember(Name = "SubIssueTypeID")]
	public int? SubIssueTypeID { get; set; }

	/// <summary>
	/// Gets or Sets TicketCategoryID
	/// </summary>
	[DataMember(Name = "TicketCategoryID")]
	public int? TicketCategoryID { get; set; }

	/// <summary>
	/// Gets or Sets TicketTypeID
	/// </summary>
	[DataMember(Name = "TicketTypeID")]
	public int? TicketTypeID { get; set; }

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "Title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets WorkTypeID
	/// </summary>
	[DataMember(Name = "WorkTypeID")]
	public int? WorkTypeID { get; set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public long? SoapParentPropertyId { get; private set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
