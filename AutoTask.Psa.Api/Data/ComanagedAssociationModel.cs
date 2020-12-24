using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ComanagedAssociationModel
	/// </summary>
	[DataContract]
	public partial class ComanagedAssociationModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ComanagedAssociationModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ComanagedAssociationModel(long? Id = default, int? CompanyID = default, int? ResourceID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CompanyID = CompanyID;
			this.ResourceID = ResourceID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets ResourceID
		/// </summary>
		[DataMember(Name = "ResourceID", EmitDefaultValue = false)]
		public int? ResourceID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
