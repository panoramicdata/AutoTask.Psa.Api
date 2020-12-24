using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ApiVersionResultModel
	/// </summary>
	[DataContract]
	public partial class ApiVersionResultModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApiVersionResultModel" /> class.
		/// </summary>
		/// <param name="ApiVersions">ApiVersions.</param>
		public ApiVersionResultModel(List<string> ApiVersions = default)
		{
			this.ApiVersions = ApiVersions;
		}

		/// <summary>
		/// Gets or Sets ApiVersions
		/// </summary>
		[DataMember(Name = "ApiVersions", EmitDefaultValue = false)]
		public List<string> ApiVersions { get; set; }
	}
}
