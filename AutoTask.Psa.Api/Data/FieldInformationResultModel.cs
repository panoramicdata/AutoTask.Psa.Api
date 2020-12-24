using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// FieldInformationResultModel
	/// </summary>
	[DataContract]
	public partial class FieldInformationResultModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FieldInformationResultModel" /> class.
		/// </summary>
		/// <param name="Fields">Fields.</param>
		public FieldInformationResultModel(List<FieldInformationModel> Fields = default)
		{
			this.Fields = Fields;
		}

		/// <summary>
		/// Gets or Sets Fields
		/// </summary>
		[DataMember(Name = "Fields", EmitDefaultValue = false)]
		public List<FieldInformationModel> Fields { get; set; }
	}
}
