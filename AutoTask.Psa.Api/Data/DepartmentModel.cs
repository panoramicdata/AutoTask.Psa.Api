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
		/// Initializes a new instance of the <see cref="DepartmentModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Number">Number.</param>
		/// <param name="PrimaryLocationID">PrimaryLocationID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public DepartmentModel(long? Id = default, string Description = default, string Name = default, string Number = default, int? PrimaryLocationID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.Description = Description;
			this.Name = Name;
			this.Number = Number;
			this.PrimaryLocationID = PrimaryLocationID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets Number
		/// </summary>
		[DataMember(Name = "Number", EmitDefaultValue = false)]
		public string Number { get; set; }

		/// <summary>
		/// Gets or Sets PrimaryLocationID
		/// </summary>
		[DataMember(Name = "PrimaryLocationID", EmitDefaultValue = false)]
		public int? PrimaryLocationID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
