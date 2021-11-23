namespace AutoTask.Psa.Api.Data;

/// <summary>
/// PhaseModel
/// </summary>
[DataContract]
public partial class PhaseModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

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
	/// Gets or Sets DueDate
	/// </summary>
	[DataMember(Name = "DueDate")]
	public DateTime? DueDate { get; set; }

	/// <summary>
	/// Gets or Sets EstimatedHours
	/// </summary>
	[DataMember(Name = "EstimatedHours")]
	public double? EstimatedHours { get; set; }

	/// <summary>
	/// Gets or Sets ExternalID
	/// </summary>
	[DataMember(Name = "ExternalID")]
	public string ExternalID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets IsScheduled
	/// </summary>
	[DataMember(Name = "IsScheduled")]
	public bool? IsScheduled { get; set; }

	/// <summary>
	/// Gets or Sets LastActivityDateTime
	/// </summary>
	[DataMember(Name = "LastActivityDateTime")]
	public DateTime? LastActivityDateTime { get; set; }

	/// <summary>
	/// Gets or Sets ParentPhaseID
	/// </summary>
	[DataMember(Name = "ParentPhaseID")]
	public int? ParentPhaseID { get; set; }

	/// <summary>
	/// Gets or Sets PhaseNumber
	/// </summary>
	[DataMember(Name = "PhaseNumber")]
	public string PhaseNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ProjectID
	/// </summary>
	[DataMember(Name = "ProjectID")]
	public int? ProjectID { get; set; }

	/// <summary>
	/// Gets or Sets StartDate
	/// </summary>
	[DataMember(Name = "StartDate")]
	public DateTime? StartDate { get; set; }

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "Title")]
	public string Title { get; set; } = string.Empty;

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
