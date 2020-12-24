using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// OrganizationalLevelAssociationModel
	/// </summary>
	[DataContract]
	public partial class OrganizationalLevelAssociationModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationalLevelAssociationModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="OrganizationalLevel1ID">OrganizationalLevel1ID.</param>
		/// <param name="OrganizationalLevel2ID">OrganizationalLevel2ID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public OrganizationalLevelAssociationModel(long? Id = default, bool? IsActive = default, int? OrganizationalLevel1ID = default, int? OrganizationalLevel2ID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.IsActive = IsActive;
			this.OrganizationalLevel1ID = OrganizationalLevel1ID;
			this.OrganizationalLevel2ID = OrganizationalLevel2ID;
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
		/// Gets or Sets OrganizationalLevel1ID
		/// </summary>
		[DataMember(Name = "OrganizationalLevel1ID", EmitDefaultValue = false)]
		public int? OrganizationalLevel1ID { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevel2ID
		/// </summary>
		[DataMember(Name = "OrganizationalLevel2ID", EmitDefaultValue = false)]
		public int? OrganizationalLevel2ID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
