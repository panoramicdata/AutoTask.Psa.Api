using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ModelObject
	/// </summary>
	[DataContract]
	public partial class ModelObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ModelObject" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		public ModelObject()
		{
		}
	}
}
