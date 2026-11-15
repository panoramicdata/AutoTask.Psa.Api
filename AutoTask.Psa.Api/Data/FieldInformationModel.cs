namespace AutoTask.Psa.Api.Data;

/// <summary>
/// FieldInformationModel
/// </summary>
[DataContract]
public class FieldInformationModel : FieldModelBase
{
	/// <summary>
	/// Gets or Sets DataType
	/// </summary>
	[DataMember(Name = "DataType")]
	public string DataType { get; set; } = string.Empty;
}
