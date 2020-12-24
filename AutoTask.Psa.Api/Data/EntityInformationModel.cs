using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// EntityInformationModel
	/// </summary>
	[DataContract]
	public partial class EntityInformationModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EntityInformationModel" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		public EntityInformationModel()
		{
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; private set; }
		/// <summary>
		/// Gets or Sets CanCreate
		/// </summary>
		[DataMember(Name = "CanCreate", EmitDefaultValue = false)]
		public bool? CanCreate { get; private set; }
		/// <summary>
		/// Gets or Sets CanDelete
		/// </summary>
		[DataMember(Name = "CanDelete", EmitDefaultValue = false)]
		public bool? CanDelete { get; private set; }
		/// <summary>
		/// Gets or Sets CanQuery
		/// </summary>
		[DataMember(Name = "CanQuery", EmitDefaultValue = false)]
		public bool? CanQuery { get; private set; }
		/// <summary>
		/// Gets or Sets CanUpdate
		/// </summary>
		[DataMember(Name = "CanUpdate", EmitDefaultValue = false)]
		public bool? CanUpdate { get; private set; }
		/// <summary>
		/// Gets or Sets UserAccessForCreate
		/// </summary>
		[DataMember(Name = "UserAccessForCreate", EmitDefaultValue = false)]
		public RestUserAccessLevel UserAccessForCreate { get; private set; }
		/// <summary>
		/// Gets or Sets UserAccessForDelete
		/// </summary>
		[DataMember(Name = "UserAccessForDelete", EmitDefaultValue = false)]
		public RestUserAccessLevel UserAccessForDelete { get; private set; }
		/// <summary>
		/// Gets or Sets UserAccessForQuery
		/// </summary>
		[DataMember(Name = "UserAccessForQuery", EmitDefaultValue = false)]
		public RestUserAccessLevel UserAccessForQuery { get; private set; }
		/// <summary>
		/// Gets or Sets UserAccessForUpdate
		/// </summary>
		[DataMember(Name = "UserAccessForUpdate", EmitDefaultValue = false)]
		public RestUserAccessLevel UserAccessForUpdate { get; private set; }
		/// <summary>
		/// Gets or Sets HasUserDefinedFields
		/// </summary>
		[DataMember(Name = "HasUserDefinedFields", EmitDefaultValue = false)]
		public bool? HasUserDefinedFields { get; private set; }
		/// <summary>
		/// Gets or Sets SupportsWebhookCallouts
		/// </summary>
		[DataMember(Name = "SupportsWebhookCallouts", EmitDefaultValue = false)]
		public bool? SupportsWebhookCallouts { get; private set; }
	}
}
