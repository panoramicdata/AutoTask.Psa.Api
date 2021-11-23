namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractBillingRuleModel
/// </summary>
[DataContract]
public partial class ContractBillingRuleModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets CreateChargesAsBillable
	/// </summary>
	[DataMember(Name = "CreateChargesAsBillable")]
	public bool? CreateChargesAsBillable { get; set; }

	/// <summary>
	/// Gets or Sets DailyProratedCost
	/// </summary>
	[DataMember(Name = "DailyProratedCost")]
	public double? DailyProratedCost { get; set; }

	/// <summary>
	/// Gets or Sets DailyProratedPrice
	/// </summary>
	[DataMember(Name = "DailyProratedPrice")]
	public double? DailyProratedPrice { get; set; }

	/// <summary>
	/// Gets or Sets DetermineUnits
	/// </summary>
	[DataMember(Name = "DetermineUnits")]
	public int? DetermineUnits { get; set; }

	/// <summary>
	/// Gets or Sets EndDate
	/// </summary>
	[DataMember(Name = "EndDate")]
	public DateTime? EndDate { get; set; }

	/// <summary>
	/// Gets or Sets ExecutionMethod
	/// </summary>
	[DataMember(Name = "ExecutionMethod")]
	public int? ExecutionMethod { get; set; }

	/// <summary>
	/// Gets or Sets IncludeItemsInChargeDescription
	/// </summary>
	[DataMember(Name = "IncludeItemsInChargeDescription")]
	public bool? IncludeItemsInChargeDescription { get; set; }

	/// <summary>
	/// Gets or Sets InvoiceDescription
	/// </summary>
	[DataMember(Name = "InvoiceDescription")]
	public string InvoiceDescription { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets IsDailyProrationEnabled
	/// </summary>
	[DataMember(Name = "IsDailyProrationEnabled")]
	public bool? IsDailyProrationEnabled { get; set; }

	/// <summary>
	/// Gets or Sets MaximumUnits
	/// </summary>
	[DataMember(Name = "MaximumUnits")]
	public int? MaximumUnits { get; set; }

	/// <summary>
	/// Gets or Sets MinimumUnits
	/// </summary>
	[DataMember(Name = "MinimumUnits")]
	public int? MinimumUnits { get; set; }

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets StartDate
	/// </summary>
	[DataMember(Name = "StartDate")]
	public DateTime? StartDate { get; set; }

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
