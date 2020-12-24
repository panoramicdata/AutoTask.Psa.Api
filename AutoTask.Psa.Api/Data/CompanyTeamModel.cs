using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CompanyTeamModel
	/// </summary>
	[DataContract]
	public partial class CompanyTeamModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CompanyTeamModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="IsAssociatedAsComanaged">IsAssociatedAsComanaged.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public CompanyTeamModel(long? Id = default, long? CompanyID = default, bool? IsAssociatedAsComanaged = default, long? ResourceID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CompanyID = CompanyID;
			this.IsAssociatedAsComanaged = IsAssociatedAsComanaged;
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
		public long? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets IsAssociatedAsComanaged
		/// </summary>
		[DataMember(Name = "IsAssociatedAsComanaged", EmitDefaultValue = false)]
		public bool? IsAssociatedAsComanaged { get; set; }

		/// <summary>
		/// Gets or Sets ResourceID
		/// </summary>
		[DataMember(Name = "ResourceID", EmitDefaultValue = false)]
		public long? ResourceID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncAccountTeamInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
