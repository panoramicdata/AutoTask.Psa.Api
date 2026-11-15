namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ProductTierModel
/// </summary>
[DataContract]
public class ProductTierModel : ParentedEntityModelBase
{
	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets UnitCost
	/// </summary>
	[DataMember(Name = "UnitCost")]
	public double? UnitCost { get; set; }

	/// <summary>
	/// Gets or Sets UnitPrice
	/// </summary>
	[DataMember(Name = "UnitPrice")]
	public double? UnitPrice { get; set; }

	/// <summary>
	/// Gets or Sets UpToUnitCount
	/// </summary>
	[DataMember(Name = "UpToUnitCount")]
	public double? UpToUnitCount { get; set; }
}
