using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ApiVersionResultModel
	/// </summary>
	[DataContract]
	public partial class ApiVersionsResultModel
	{
		/// <summary>
		/// Gets or Sets ApiVersions
		/// </summary>
		[DataMember(Name = "ApiVersions")]
		public List<string> ApiVersions { get; set; } = new();
	}
}
