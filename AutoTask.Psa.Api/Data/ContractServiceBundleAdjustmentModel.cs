namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ContractServiceBundleAdjustmentModel
/// </summary>
[DataContract]
public partial class ContractServiceBundleAdjustmentModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets AdjustedUnitPrice
	/// </summary>
	[DataMember(Name = "AdjustedUnitPrice")]
	public double? AdjustedUnitPrice { get; set; }

	/// <summary>
	/// Gets or Sets AllowRepeatServiceBundle
	/// </summary>
	[DataMember(Name = "AllowRepeatServiceBundle")]
	public bool? AllowRepeatServiceBundle { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets ContractServiceBundleID
	/// </summary>
	[DataMember(Name = "ContractServiceBundleID")]
	public int? ContractServiceBundleID { get; set; }

	/// <summary>
	/// Gets or Sets EffectiveDate
	/// </summary>
	[DataMember(Name = "EffectiveDate")]
	public DateTime? EffectiveDate { get; set; }

	/// <summary>
	/// Gets or Sets QuoteItemID
	/// </summary>
	[DataMember(Name = "QuoteItemID")]
	public int? QuoteItemID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceBundleID
	/// </summary>
	[DataMember(Name = "ServiceBundleID")]
	public int? ServiceBundleID { get; set; }

	/// <summary>
	/// Gets or Sets UnitChange
	/// </summary>
	[DataMember(Name = "UnitChange")]
	public int? UnitChange { get; set; }

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
