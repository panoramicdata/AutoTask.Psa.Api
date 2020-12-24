using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CompanyAlertModel
	/// </summary>
	[DataContract]
	public partial class CompanyAlertModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CompanyAlertModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AlertText">AlertText.</param>
		/// <param name="AlertTypeID">AlertTypeID.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public CompanyAlertModel(long? Id = default, string AlertText = default, int? AlertTypeID = default, int? CompanyID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AlertText = AlertText;
			this.AlertTypeID = AlertTypeID;
			this.CompanyID = CompanyID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AlertText
		/// </summary>
		[DataMember(Name = "AlertText", EmitDefaultValue = false)]
		public string AlertText { get; set; }

		/// <summary>
		/// Gets or Sets AlertTypeID
		/// </summary>
		[DataMember(Name = "AlertTypeID", EmitDefaultValue = false)]
		public int? AlertTypeID { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncAccountAlertInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
