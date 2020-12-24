using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// UserDefinedFieldInformationResultModel
	/// </summary>
	[DataContract]
	public partial class UserDefinedFieldInformationResultModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserDefinedFieldInformationResultModel" /> class.
		/// </summary>
		/// <param name="Fields">Fields.</param>
		public UserDefinedFieldInformationResultModel(List<Field> Fields = default)
		{
			this.Fields = Fields;
		}

		/// <summary>
		/// Gets or Sets Fields
		/// </summary>
		[DataMember(Name = "Fields", EmitDefaultValue = false)]
		public List<Field> Fields { get; set; }
	}
}
