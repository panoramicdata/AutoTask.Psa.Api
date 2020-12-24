using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ServiceCallTaskModel
	/// </summary>
	[DataContract]
	public partial class ServiceCallTaskModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceCallTaskModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ServiceCallID">ServiceCallID.</param>
		/// <param name="TaskID">TaskID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ServiceCallTaskModel(long? Id = default, int? ServiceCallID = default, int? TaskID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ServiceCallID = ServiceCallID;
			this.TaskID = TaskID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ServiceCallID
		/// </summary>
		[DataMember(Name = "ServiceCallID", EmitDefaultValue = false)]
		public int? ServiceCallID { get; set; }

		/// <summary>
		/// Gets or Sets TaskID
		/// </summary>
		[DataMember(Name = "TaskID", EmitDefaultValue = false)]
		public int? TaskID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncServiceCallTaskInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
