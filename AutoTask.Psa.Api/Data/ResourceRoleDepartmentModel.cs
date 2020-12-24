using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ResourceRoleDepartmentModel
	/// </summary>
	[DataContract]
	public partial class ResourceRoleDepartmentModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ResourceRoleDepartmentModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="DepartmentID">DepartmentID.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsDefault">IsDefault.</param>
		/// <param name="IsDepartmentLead">IsDepartmentLead.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="RoleID">RoleID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ResourceRoleDepartmentModel(long? Id = default, int? DepartmentID = default, bool? IsActive = default, bool? IsDefault = default, bool? IsDepartmentLead = default, int? ResourceID = default, int? RoleID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.DepartmentID = DepartmentID;
			this.IsActive = IsActive;
			this.IsDefault = IsDefault;
			this.IsDepartmentLead = IsDepartmentLead;
			this.ResourceID = ResourceID;
			this.RoleID = RoleID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets DepartmentID
		/// </summary>
		[DataMember(Name = "DepartmentID", EmitDefaultValue = false)]
		public int? DepartmentID { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsDefault
		/// </summary>
		[DataMember(Name = "IsDefault", EmitDefaultValue = false)]
		public bool? IsDefault { get; set; }

		/// <summary>
		/// Gets or Sets IsDepartmentLead
		/// </summary>
		[DataMember(Name = "IsDepartmentLead", EmitDefaultValue = false)]
		public bool? IsDepartmentLead { get; set; }

		/// <summary>
		/// Gets or Sets ResourceID
		/// </summary>
		[DataMember(Name = "ResourceID", EmitDefaultValue = false)]
		public int? ResourceID { get; set; }

		/// <summary>
		/// Gets or Sets RoleID
		/// </summary>
		[DataMember(Name = "RoleID", EmitDefaultValue = false)]
		public int? RoleID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncResourceRoleDepartmentInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
