using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ResourceRoleQueueModel
	/// </summary>
	[DataContract]
	public partial class ResourceRoleQueueModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ResourceRoleQueueModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="QueueID">QueueID.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ResourceRoleQueueModel(long? Id = default, int? QueueID = default, int? ResourceID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.QueueID = QueueID;
			this.ResourceID = ResourceID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets QueueID
		/// </summary>
		[DataMember(Name = "QueueID", EmitDefaultValue = false)]
		public int? QueueID { get; set; }

		/// <summary>
		/// Gets or Sets ResourceID
		/// </summary>
		[DataMember(Name = "ResourceID", EmitDefaultValue = false)]
		public int? ResourceID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncResourceRoleQueueInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
