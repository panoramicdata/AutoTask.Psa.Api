using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ZoneInformationResultModel
	/// </summary>
	[DataContract]
	public partial class ZoneInformationResultModel
	{
		/// <summary>
		/// Gets or Sets ZoneName
		/// </summary>
		[DataMember(Name = "ZoneName", EmitDefaultValue = false)]
		public string ZoneName { get; private set; }

		/// <summary>
		/// Gets or Sets Url
		/// </summary>
		[DataMember(Name = "Url", EmitDefaultValue = false)]
		public string Url { get; private set; }

		/// <summary>
		/// Gets or Sets WebUrl
		/// </summary>
		[DataMember(Name = "WebUrl", EmitDefaultValue = false)]
		public string WebUrl { get; private set; }

		/// <summary>
		/// Gets or Sets CI
		/// </summary>
		[DataMember(Name = "CI", EmitDefaultValue = false)]
		public int? CI { get; private set; }
	}
}
