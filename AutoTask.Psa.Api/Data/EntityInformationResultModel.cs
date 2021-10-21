using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// EntityInformationResultModel
	/// </summary>
	[DataContract]
	public partial class EntityInformationResultModel
	{
		/// <summary>
		/// Gets or Sets Info
		/// </summary>
		[DataMember(Name = "Info")]
		public EntityInformationModel Info { get; set; } = new();
	}
}
