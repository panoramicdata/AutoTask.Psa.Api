using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// DepartmentModel
	/// </summary>
	[DataContract]
	public partial class DepartmentModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Number
		/// </summary>
		[DataMember(Name = "Number", EmitDefaultValue = false)]
		public string Number { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets PrimaryLocationID
		/// </summary>
		[DataMember(Name = "PrimaryLocationID", EmitDefaultValue = false)]
		public int? PrimaryLocationID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
