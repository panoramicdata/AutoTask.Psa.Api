using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// SkillModel
	/// </summary>
	[DataContract]
	public partial class SkillModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SkillModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CategoryID">CategoryID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="Name">Name.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public SkillModel(long? Id = default, long? CategoryID = default, string Description = default, bool? IsActive = default, string Name = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CategoryID = CategoryID;
			this.Description = Description;
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
		/// Gets or Sets CategoryID
		/// </summary>
		[DataMember(Name = "CategoryID", EmitDefaultValue = false)]
		public long? CategoryID { get; set; }

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
