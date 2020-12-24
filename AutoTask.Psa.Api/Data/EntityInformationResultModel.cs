using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// EntityInformationResultModel
	/// </summary>
	[DataContract]
	public partial class EntityInformationResultModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EntityInformationResultModel" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		public EntityInformationResultModel()
		{
		}

		/// <summary>
		/// Gets or Sets Info
		/// </summary>
		[DataMember(Name = "Info", EmitDefaultValue = false)]
		public EntityInformationModel Info { get; private set; }
	}
}
