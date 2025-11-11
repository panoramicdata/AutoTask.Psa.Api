namespace AutoTask.Psa.Api.Data;

/// <summary>
/// SubscriptionPeriodModel
/// </summary>
[DataContract]
public class SubscriptionPeriodModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets PeriodCost
	/// </summary>
	[DataMember(Name = "PeriodCost")]
	public double? PeriodCost { get; set; }

	/// <summary>
	/// Gets or Sets PeriodDate
	/// </summary>
	[DataMember(Name = "PeriodDate")]
	public DateTime? PeriodDate { get; set; }

	/// <summary>
	/// Gets or Sets PeriodPrice
	/// </summary>
	[DataMember(Name = "PeriodPrice")]
	public double? PeriodPrice { get; set; }

	/// <summary>
	/// Gets or Sets PostedDate
	/// </summary>
	[DataMember(Name = "PostedDate")]
	public DateTime? PostedDate { get; set; }

	/// <summary>
	/// Gets or Sets PurchaseOrderNumber
	/// </summary>
	[DataMember(Name = "PurchaseOrderNumber")]
	public string PurchaseOrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets SubscriptionID
	/// </summary>
	[DataMember(Name = "SubscriptionID")]
	public int? SubscriptionID { get; set; }

	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public long? SoapParentPropertyId { get; private set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
