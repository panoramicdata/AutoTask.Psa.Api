namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ServiceLevelAgreementResultsModel
/// </summary>
[DataContract]
public class ServiceLevelAgreementResultsModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets FirstResponseElapsedHours
	/// </summary>
	[DataMember(Name = "FirstResponseElapsedHours")]
	public double? FirstResponseElapsedHours { get; set; }

	/// <summary>
	/// Gets or Sets FirstResponseInitiatingResourceID
	/// </summary>
	[DataMember(Name = "FirstResponseInitiatingResourceID")]
	public int? FirstResponseInitiatingResourceID { get; set; }

	/// <summary>
	/// Gets or Sets FirstResponseResourceID
	/// </summary>
	[DataMember(Name = "FirstResponseResourceID")]
	public int? FirstResponseResourceID { get; set; }

	/// <summary>
	/// Gets or Sets IsFirstResponseMet
	/// </summary>
	[DataMember(Name = "IsFirstResponseMet")]
	public bool? IsFirstResponseMet { get; set; }

	/// <summary>
	/// Gets or Sets IsResolutionMet
	/// </summary>
	[DataMember(Name = "IsResolutionMet")]
	public bool? IsResolutionMet { get; set; }

	/// <summary>
	/// Gets or Sets IsResolutionPlanMet
	/// </summary>
	[DataMember(Name = "IsResolutionPlanMet")]
	public bool? IsResolutionPlanMet { get; set; }

	/// <summary>
	/// Gets or Sets ResolutionElapsedHours
	/// </summary>
	[DataMember(Name = "ResolutionElapsedHours")]
	public double? ResolutionElapsedHours { get; set; }

	/// <summary>
	/// Gets or Sets ResolutionPlanElapsedHours
	/// </summary>
	[DataMember(Name = "ResolutionPlanElapsedHours")]
	public double? ResolutionPlanElapsedHours { get; set; }

	/// <summary>
	/// Gets or Sets ResolutionPlanResourceID
	/// </summary>
	[DataMember(Name = "ResolutionPlanResourceID")]
	public int? ResolutionPlanResourceID { get; set; }

	/// <summary>
	/// Gets or Sets ResolutionResourceID
	/// </summary>
	[DataMember(Name = "ResolutionResourceID")]
	public int? ResolutionResourceID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceLevelAgreementName
	/// </summary>
	[DataMember(Name = "ServiceLevelAgreementName")]
	public string ServiceLevelAgreementName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }

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
