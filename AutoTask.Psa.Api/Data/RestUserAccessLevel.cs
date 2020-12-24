using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// RestUserAccessLevel
	/// </summary>
	[DataContract]
	public partial class RestUserAccessLevel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RestUserAccessLevel" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		public RestUserAccessLevel()
		{
		}
	}
}
