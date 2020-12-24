using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CompanySiteConfigurationModel
	/// </summary>
	[DataContract]
	public partial class CompanySiteConfigurationModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CompanySiteConfigurationModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="LocationName">LocationName.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public CompanySiteConfigurationModel(long? Id = default, int? CompanyID = default, string LocationName = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CompanyID = CompanyID;
			this.LocationName = LocationName;
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
		/// Gets or Sets LocationName
		/// </summary>
		[DataMember(Name = "LocationName", EmitDefaultValue = false)]
		public string LocationName { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncAccountLocationInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
