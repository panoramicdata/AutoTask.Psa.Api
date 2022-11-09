namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CompanyToDoModel
/// </summary>
[DataContract]
public class CompanyToDoModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ActionType
	/// </summary>
	[DataMember(Name = "ActionType")]
	public int? ActionType { get; set; }

	/// <summary>
	/// Gets or Sets ActivityDescription
	/// </summary>
	[DataMember(Name = "ActivityDescription")]
	public string ActivityDescription { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets AssignedToResourceID
	/// </summary>
	[DataMember(Name = "AssignedToResourceID")]
	public long? AssignedToResourceID { get; set; }

	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public long? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets CompletedDate
	/// </summary>
	[DataMember(Name = "CompletedDate")]
	public DateTime? CompletedDate { get; set; }

	/// <summary>
	/// Gets or Sets ContactID
	/// </summary>
	[DataMember(Name = "ContactID")]
	public long? ContactID { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public long? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDateTime
	/// </summary>
	[DataMember(Name = "CreateDateTime")]
	public DateTime? CreateDateTime { get; set; }

	/// <summary>
	/// Gets or Sets CreatorResourceID
	/// </summary>
	[DataMember(Name = "CreatorResourceID")]
	public long? CreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets EndDateTime
	/// </summary>
	[DataMember(Name = "EndDateTime")]
	public DateTime? EndDateTime { get; set; }

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets LastModifiedDate
	/// </summary>
	[DataMember(Name = "LastModifiedDate")]
	public DateTime? LastModifiedDate { get; set; }

	/// <summary>
	/// Gets or Sets OpportunityID
	/// </summary>
	[DataMember(Name = "OpportunityID")]
	public long? OpportunityID { get; set; }

	/// <summary>
	/// Gets or Sets StartDateTime
	/// </summary>
	[DataMember(Name = "StartDateTime")]
	public DateTime? StartDateTime { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public long? TicketID { get; set; }

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
