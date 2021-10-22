using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ThresholdStatusResultModel
	/// </summary>
	[DataContract]
	public partial class ThresholdStatusResultModel
	{
		/// <summary>
		/// Gets or Sets ExternalRequestThreshold
		/// </summary>
		[DataMember(Name = "ExternalRequestThreshold")]
		public int? ExternalRequestThreshold { get; private set; }

		/// <summary>
		/// Gets or Sets RequestThresholdTimeframe
		/// </summary>
		[DataMember(Name = "RequestThresholdTimeframe")]
		public int? RequestThresholdTimeframe { get; private set; }

		/// <summary>
		/// Gets or Sets CurrentTimeframeRequestCount
		/// </summary>
		[DataMember(Name = "CurrentTimeframeRequestCount")]
		public int? CurrentTimeframeRequestCount { get; private set; }
	}
}
