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
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets HolidayDate
		/// </summary>
		[DataMember(Name = "HolidayDate")]
		public DateTime? HolidayDate { get; set; }

		/// <summary>
		/// Gets or Sets HolidayName
		/// </summary>
		[DataMember(Name = "HolidayName")]
		public string HolidayName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets HolidaySetID
		/// </summary>
		[DataMember(Name = "HolidaySetID")]
		public int? HolidaySetID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId")]
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
