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
		/// Gets or Sets Fields
		/// </summary>
		[DataMember(Name = "Fields", EmitDefaultValue = false)]
		public List<FieldInformationModel> Fields { get; set; } = new();
	}
}
