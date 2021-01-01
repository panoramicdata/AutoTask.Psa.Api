using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// HolidaySetModel
	/// </summary>
	[DataContract]
	public partial class HolidaySetModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets HolidaySetDescription
		/// </summary>
		[DataMember(Name = "HolidaySetDescription", EmitDefaultValue = false)]
		public string HolidaySetDescription { get; set; }

		/// <summary>
		/// Gets or Sets HolidaySetName
		/// </summary>
		[DataMember(Name = "HolidaySetName", EmitDefaultValue = false)]
		public string HolidaySetName { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
