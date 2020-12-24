using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ConfigurationItemTypeModel
	/// </summary>
	[DataContract]
	public partial class ConfigurationItemTypeModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigurationItemTypeModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="Name">Name.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ConfigurationItemTypeModel(long? Id = default, bool? IsActive = default, string Name = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.IsActive = IsActive;
			this.Name = Name;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
