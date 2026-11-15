namespace AutoTask.Psa.Api.Data;

/// <summary>
/// SurveyResultsModel
/// </summary>
[DataContract]
public class SurveyResultsModel : EntityModelBase
{
	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets CompanyRating
	/// </summary>
	[DataMember(Name = "CompanyRating")]
	public double? CompanyRating { get; set; }

	/// <summary>
	/// Gets or Sets CompleteDate
	/// </summary>
	[DataMember(Name = "CompleteDate")]
	public DateTime? CompleteDate { get; set; }

	/// <summary>
	/// Gets or Sets ContactID
	/// </summary>
	[DataMember(Name = "ContactID")]
	public int? ContactID { get; set; }

	/// <summary>
	/// Gets or Sets ContactRating
	/// </summary>
	[DataMember(Name = "ContactRating")]
	public double? ContactRating { get; set; }

	/// <summary>
	/// Gets or Sets ResourceRating
	/// </summary>
	[DataMember(Name = "ResourceRating")]
	public double? ResourceRating { get; set; }

	/// <summary>
	/// Gets or Sets SendDate
	/// </summary>
	[DataMember(Name = "SendDate")]
	public DateTime? SendDate { get; set; }

	/// <summary>
	/// Gets or Sets SurveyID
	/// </summary>
	[DataMember(Name = "SurveyID")]
	public int? SurveyID { get; set; }

	/// <summary>
	/// Gets or Sets SurveyRating
	/// </summary>
	[DataMember(Name = "SurveyRating")]
	public double? SurveyRating { get; set; }

	/// <summary>
	/// Gets or Sets TicketID
	/// </summary>
	[DataMember(Name = "TicketID")]
	public int? TicketID { get; set; }
}
