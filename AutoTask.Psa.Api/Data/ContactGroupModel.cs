using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContactGroupModel
	/// </summary>
	[DataContract]
	public partial class ContactGroupModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactGroupModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Name">Name.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContactGroupModel(long? Id = default, string Name = default, bool? IsActive = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.Name = Name;
			this.IsActive = IsActive;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
