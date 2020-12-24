using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ServiceBundleServiceModel
	/// </summary>
	[DataContract]
	public partial class ServiceBundleServiceModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceBundleServiceModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ServiceBundleID">ServiceBundleID.</param>
		/// <param name="ServiceID">ServiceID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ServiceBundleServiceModel(long? Id = default, long? ServiceBundleID = default, long? ServiceID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ServiceBundleID = ServiceBundleID;
			this.ServiceID = ServiceID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ServiceBundleID
		/// </summary>
		[DataMember(Name = "ServiceBundleID", EmitDefaultValue = false)]
		public long? ServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceID
		/// </summary>
		[DataMember(Name = "ServiceID", EmitDefaultValue = false)]
		public long? ServiceID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncServiceBundleServiceInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
