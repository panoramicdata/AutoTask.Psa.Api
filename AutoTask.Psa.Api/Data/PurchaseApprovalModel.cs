namespace AutoTask.Psa.Api.Data;

/// <summary>
/// PurchaseApprovalModel
/// </summary>
[DataContract]
public class PurchaseApprovalModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets CostType
	/// </summary>
	[DataMember(Name = "CostType")]
	public string CostType { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets IsApproved
	/// </summary>
	[DataMember(Name = "IsApproved")]
	public bool? IsApproved { get; set; }

	/// <summary>
	/// Gets or Sets RejectNote
	/// </summary>
	[DataMember(Name = "RejectNote")]
	public string RejectNote { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = new();
}
