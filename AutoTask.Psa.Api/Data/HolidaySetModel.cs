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
		/// Initializes a new instance of the <see cref="HolidaySetModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="HolidaySetDescription">HolidaySetDescription.</param>
		/// <param name="HolidaySetName">HolidaySetName.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public HolidaySetModel(long? Id = default, string HolidaySetDescription = default, string HolidaySetName = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.HolidaySetDescription = HolidaySetDescription;
			this.HolidaySetName = HolidaySetName;
			this.UserDefinedFields = UserDefinedFields;
		}

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
