namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ConfigurationItemBillingProductAssociationModel
/// </summary>
[DataContract]
public partial class ConfigurationItemBillingProductAssociationModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets BillingProductID
	/// </summary>
	[DataMember(Name = "BillingProductID")]
	public int? BillingProductID { get; set; }

	/// <summary>
	/// Gets or Sets ConfigurationItemID
	/// </summary>
	[DataMember(Name = "ConfigurationItemID")]
	public int? ConfigurationItemID { get; set; }

	/// <summary>
	/// Gets or Sets EffectiveDate
	/// </summary>
	[DataMember(Name = "EffectiveDate")]
	public DateTime? EffectiveDate { get; set; }

	/// <summary>
	/// Gets or Sets ExpirationDate
	/// </summary>
	[DataMember(Name = "ExpirationDate")]
	public DateTime? ExpirationDate { get; set; }

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
