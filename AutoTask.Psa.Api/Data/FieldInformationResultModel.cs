namespace AutoTask.Psa.Api.Data;

/// <summary>
/// FieldInformationResultModel
/// </summary>
[DataContract]
public class FieldInformationResultModel
{
	/// <summary>
	/// Gets or Sets Fields
	/// </summary>
	[DataMember(Name = "Fields")]
	public List<FieldInformationModel> Fields { get; set; } = new();
}
