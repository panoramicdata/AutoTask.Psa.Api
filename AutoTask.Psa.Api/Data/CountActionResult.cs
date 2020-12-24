using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CountActionResult
	/// </summary>
	[DataContract]
	public partial class CountActionResult
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CountActionResult" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		public CountActionResult()
		{
		}
	}
}
