using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TaskSecondaryResourceModel
	/// </summary>
	[DataContract]
	public partial class TaskSecondaryResourceModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TaskSecondaryResourceModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="RoleID">RoleID.</param>
		/// <param name="TaskID">TaskID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TaskSecondaryResourceModel(long? Id = default, int? ResourceID = default, int? RoleID = default, int? TaskID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ResourceID = ResourceID;
			this.RoleID = RoleID;
			this.TaskID = TaskID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

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
		/// Gets or Sets TaskID
		/// </summary>
		[DataMember(Name = "TaskID", EmitDefaultValue = false)]
		public int? TaskID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncTaskSecondaryResourceInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
