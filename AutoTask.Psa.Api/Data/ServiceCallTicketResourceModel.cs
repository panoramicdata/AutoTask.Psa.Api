using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ServiceCallTicketResourceModel
	/// </summary>
	[DataContract]
	public partial class ServiceCallTicketResourceModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceCallTicketResourceModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="ServiceCallTicketID">ServiceCallTicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ServiceCallTicketResourceModel(long? Id = default, int? ResourceID = default, int? ServiceCallTicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ResourceID = ResourceID;
			this.ServiceCallTicketID = ServiceCallTicketID;
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
		/// Gets or Sets ServiceCallTicketID
		/// </summary>
		[DataMember(Name = "ServiceCallTicketID", EmitDefaultValue = false)]
		public int? ServiceCallTicketID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncServiceCallTicketResourceInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
