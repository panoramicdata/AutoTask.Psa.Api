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
		/// Initializes a new instance of the <see cref="GlobalEntityInformationResultModel" /> class.
		/// </summary>
		/// <param name="EntityDescriptions">EntityDescriptions.</param>
		public GlobalEntityInformationResultModel(List<EntityInformationResultModel> EntityDescriptions = default)
		{
			this.EntityDescriptions = EntityDescriptions;
		}

		/// <summary>
		/// Gets or Sets EntityDescriptions
		/// </summary>
		[DataMember(Name = "EntityDescriptions", EmitDefaultValue = false)]
		public List<EntityInformationResultModel> EntityDescriptions { get; set; }
	}
}
