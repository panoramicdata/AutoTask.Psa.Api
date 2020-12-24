using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ThresholdStatusResultModel
	/// </summary>
	[DataContract]
	public partial class ThresholdStatusResultModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ThresholdStatusResultModel" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		public ThresholdStatusResultModel()
		{
		}

		/// <summary>
		/// Gets or Sets ExternalRequestThreshold
		/// </summary>
		[DataMember(Name = "ExternalRequestThreshold", EmitDefaultValue = false)]
		public int? ExternalRequestThreshold { get; private set; }
		/// <summary>
		/// Gets or Sets RequestThresholdTimeframe
		/// </summary>
		[DataMember(Name = "RequestThresholdTimeframe", EmitDefaultValue = false)]
		public int? RequestThresholdTimeframe { get; private set; }
		/// <summary>
		/// Gets or Sets CurrentTimeframeRequestCount
		/// </summary>
		[DataMember(Name = "CurrentTimeframeRequestCount", EmitDefaultValue = false)]
		public int? CurrentTimeframeRequestCount { get; private set; }
	}
}
