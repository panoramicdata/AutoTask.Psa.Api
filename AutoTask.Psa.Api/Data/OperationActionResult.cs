using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// OperationActionResult
	/// </summary>
	[DataContract]
	public partial class OperationActionResult
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OperationActionResult" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		public OperationActionResult()
		{
		}
	}
}
