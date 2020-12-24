using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// QueryCountResultModel
	/// </summary>
	[DataContract]
	public partial class QueryCountResultModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QueryCountResultModel" /> class.
		/// </summary>
		/// <param name="QueryCount">QueryCount.</param>
		public QueryCountResultModel(int? QueryCount = default)
		{
			this.QueryCount = QueryCount;
		}

		/// <summary>
		/// Gets or Sets QueryCount
		/// </summary>
		[DataMember(Name = "QueryCount", EmitDefaultValue = false)]
		public int? QueryCount { get; set; }
	}
}
