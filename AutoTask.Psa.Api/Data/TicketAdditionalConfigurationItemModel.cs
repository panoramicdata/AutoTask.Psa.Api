using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TicketAdditionalConfigurationItemModel
	/// </summary>
	[DataContract]
	public partial class TicketAdditionalConfigurationItemModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TicketAdditionalConfigurationItemModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ConfigurationItemID">ConfigurationItemID.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TicketAdditionalConfigurationItemModel(long? Id = default, int? ConfigurationItemID = default, int? TicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ConfigurationItemID = ConfigurationItemID;
			this.TicketID = TicketID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ConfigurationItemID
		/// </summary>
		[DataMember(Name = "ConfigurationItemID", EmitDefaultValue = false)]
		public int? ConfigurationItemID { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncTicketAdditionalInstalledProductInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
