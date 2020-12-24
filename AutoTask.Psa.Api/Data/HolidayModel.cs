using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// HolidayModel
	/// </summary>
	[DataContract]
	public partial class HolidayModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HolidayModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="HolidayDate">HolidayDate.</param>
		/// <param name="HolidayName">HolidayName.</param>
		/// <param name="HolidaySetID">HolidaySetID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public HolidayModel(long? Id = default, DateTime? HolidayDate = default, string HolidayName = default, int? HolidaySetID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.HolidayDate = HolidayDate;
			this.HolidayName = HolidayName;
			this.HolidaySetID = HolidaySetID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets HolidayDate
		/// </summary>
		[DataMember(Name = "HolidayDate", EmitDefaultValue = false)]
		public DateTime? HolidayDate { get; set; }

		/// <summary>
		/// Gets or Sets HolidayName
		/// </summary>
		[DataMember(Name = "HolidayName", EmitDefaultValue = false)]
		public string HolidayName { get; set; }

		/// <summary>
		/// Gets or Sets HolidaySetID
		/// </summary>
		[DataMember(Name = "HolidaySetID", EmitDefaultValue = false)]
		public int? HolidaySetID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncHolidayInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
