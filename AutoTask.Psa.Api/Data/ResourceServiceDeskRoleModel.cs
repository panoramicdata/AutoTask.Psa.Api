using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ResourceServiceDeskRoleModel
	/// </summary>
	[DataContract]
	public partial class ResourceServiceDeskRoleModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ResourceServiceDeskRoleModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsDefault">IsDefault.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="RoleID">RoleID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ResourceServiceDeskRoleModel(long? Id = default, bool? IsActive = default, bool? IsDefault = default, int? ResourceID = default, int? RoleID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.IsActive = IsActive;
			this.IsDefault = IsDefault;
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
		public ExpressionFuncResourceServiceDeskRoleInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
