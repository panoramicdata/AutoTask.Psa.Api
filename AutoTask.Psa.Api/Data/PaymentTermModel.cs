namespace AutoTask.Psa.Api.Data;

/// <summary>
/// PaymentTermModel
/// </summary>
[DataContract]
public class PaymentTermModel : DescribedNamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets PaymentDueInDays
	/// </summary>
	[DataMember(Name = "PaymentDueInDays")]
	public int? PaymentDueInDays { get; set; }
}
