namespace AutoTask.Psa.Api.Data;

/// <summary>
/// An entity that also carries the identifier expression of its parent.
/// </summary>
[DataContract]
public abstract class ParentedEntityModelBase : EntityModelBase
{
	/// <summary>
	/// Gets or Sets SoapParentPropertyId
	/// </summary>
	[DataMember(Name = "SoapParentPropertyId")]
	public ExpressionFunc? SoapParentPropertyId { get; set; }
}
