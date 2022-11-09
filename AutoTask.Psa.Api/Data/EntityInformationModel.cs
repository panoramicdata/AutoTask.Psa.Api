namespace AutoTask.Psa.Api.Data;

/// <summary>
/// EntityInformationModel
/// </summary>
[DataContract]
public class EntityInformationModel
{
	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "Name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets CanCreate
	/// </summary>
	[DataMember(Name = "CanCreate")]
	public bool? CanCreate { get; set; }

	/// <summary>
	/// Gets or Sets CanDelete
	/// </summary>
	[DataMember(Name = "CanDelete")]
	public bool? CanDelete { get; set; }

	/// <summary>
	/// Gets or Sets CanQuery
	/// </summary>
	[DataMember(Name = "CanQuery")]
	public bool? CanQuery { get; set; }

	/// <summary>
	/// Gets or Sets CanUpdate
	/// </summary>
	[DataMember(Name = "CanUpdate")]
	public bool? CanUpdate { get; set; }

	/// <summary>
	/// Gets or Sets UserAccessForCreate
	/// </summary>
	[DataMember(Name = "UserAccessForCreate")]
	public RestUserAccessLevel UserAccessForCreate { get; private set; }

	/// <summary>
	/// Gets or Sets UserAccessForDelete
	/// </summary>
	[DataMember(Name = "UserAccessForDelete")]
	public RestUserAccessLevel UserAccessForDelete { get; set; }

	/// <summary>
	/// Gets or Sets UserAccessForQuery
	/// </summary>
	[DataMember(Name = "UserAccessForQuery")]
	public RestUserAccessLevel UserAccessForQuery { get; set; }

	/// <summary>
	/// Gets or Sets UserAccessForUpdate
	/// </summary>
	[DataMember(Name = "UserAccessForUpdate")]
	public RestUserAccessLevel UserAccessForUpdate { get; set; }

	/// <summary>
	/// Gets or Sets HasUserDefinedFields
	/// </summary>
	[DataMember(Name = "HasUserDefinedFields")]
	public bool? HasUserDefinedFields { get; set; }

	/// <summary>
	/// Gets or Sets SupportsWebhookCallouts
	/// </summary>
	[DataMember(Name = "SupportsWebhookCallouts")]
	public bool? SupportsWebhookCallouts { get; set; }
}
