using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ClassificationIconModel
	/// </summary>
	[DataContract]
	public partial class ClassificationIconModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ClassificationIconModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Description">Description.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsSystem">IsSystem.</param>
		/// <param name="Name">Name.</param>
		/// <param name="RelativeUrl">RelativeUrl.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ClassificationIconModel(long? Id = default, string Description = default, bool? IsActive = default, bool? IsSystem = default, string Name = default, string RelativeUrl = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.Description = Description;
			this.IsActive = IsActive;
			this.IsSystem = IsSystem;
			this.Name = Name;
			this.RelativeUrl = RelativeUrl;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsSystem
		/// </summary>
		[DataMember(Name = "IsSystem", EmitDefaultValue = false)]
		public bool? IsSystem { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets RelativeUrl
		/// </summary>
		[DataMember(Name = "RelativeUrl", EmitDefaultValue = false)]
		public string RelativeUrl { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
