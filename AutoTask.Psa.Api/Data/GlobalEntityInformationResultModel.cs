using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// GlobalEntityInformationResultModel
	/// </summary>
	[DataContract]
	public partial class GlobalEntityInformationResultModel
	{
		/// <summary>
		/// Gets or Sets EntityDescriptions
		/// </summary>
		[DataMember(Name = "EntityDescriptions", EmitDefaultValue = false)]
		public List<EntityInformationResultModel> EntityDescriptions { get; set; } = new();
	}
}
