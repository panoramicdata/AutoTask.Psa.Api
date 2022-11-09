namespace AutoTask.Psa.Api.Data;

/// <summary>
/// CompanyNoteModel
/// </summary>
[DataContract]
public class CompanyNoteModel
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
	/// Gets or Sets AssignedResourceID
	/// </summary>
	[DataMember(Name = "AssignedResourceID")]
	public int? AssignedResourceID { get; set; }

	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets CompletedDateTime
	/// </summary>
	[DataMember(Name = "CompletedDateTime")]
	public DateTime? CompletedDateTime { get; set; }

	/// <summary>
	/// Gets or Sets ContactID
	/// </summary>
	[DataMember(Name = "ContactID")]
	public int? ContactID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDateTime
	/// </summary>
	[DataMember(Name = "CreateDateTime")]
	public DateTime? CreateDateTime { get; set; }

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
	/// Gets or Sets ImpersonatorUpdaterResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorUpdaterResourceID")]
	public int? ImpersonatorUpdaterResourceID { get; set; }

	/// <summary>
	/// Gets or Sets LastModifiedDate
	/// </summary>
	[DataMember(Name = "LastModifiedDate")]
	public DateTime? LastModifiedDate { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Note
	/// </summary>
	[DataMember(Name = "Note")]
	public string Note { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets OpportunityID
	/// </summary>
	[DataMember(Name = "OpportunityID")]
	public int? OpportunityID { get; set; }

	/// <summary>
	/// Gets or Sets StartDateTime
	/// </summary>
	[DataMember(Name = "StartDateTime")]
	public DateTime? StartDateTime { get; set; }

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
