namespace AutoTask.Psa.Api.Data;

/// <summary>
/// UserDefinedFieldInformationResultModel
/// </summary>
[DataContract]
public class UserDefinedFieldInformationResultModel
{
	/// <summary>
	/// Gets or Sets Fields
	/// </summary>
	[DataMember(Name = "Fields")]
	public List<Field> Fields { get; set; } = new();
}
