namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Members common to every AutoTask entity that has an identifier and user defined fields.
/// </summary>
[DataContract]
public abstract class EntityModelBase
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
