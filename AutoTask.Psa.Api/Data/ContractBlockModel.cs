namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractBlockModel
/// </summary>
[DataContract]
public class ContractBlockModel : ContractPaymentModelBase
{
	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets HourlyRate
	/// </summary>
	[DataMember(Name = "HourlyRate")]
	public double? HourlyRate { get; set; }

	/// <summary>
	/// Gets or Sets Hours
	/// </summary>
	[DataMember(Name = "Hours")]
	public double? Hours { get; set; }

	/// <summary>
	/// Gets or Sets HoursApproved
	/// </summary>
	[DataMember(Name = "HoursApproved")]
	public double? HoursApproved { get; set; }
}
