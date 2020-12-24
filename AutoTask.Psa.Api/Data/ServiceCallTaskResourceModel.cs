using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ServiceCallTaskResourceModel
	/// </summary>
	[DataContract]
	public partial class ServiceCallTaskResourceModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceCallTaskResourceModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="ServiceCallTaskID">ServiceCallTaskID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ServiceCallTaskResourceModel(long? Id = default, int? ResourceID = default, int? ServiceCallTaskID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ResourceID = ResourceID;
			this.ServiceCallTaskID = ServiceCallTaskID;
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
		/// Gets or Sets ServiceCallTaskID
		/// </summary>
		[DataMember(Name = "ServiceCallTaskID", EmitDefaultValue = false)]
		public int? ServiceCallTaskID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncServiceCallTaskResourceInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
