using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// QueryModel
	/// </summary>
	[DataContract]
	public partial class QueryModel
	{
		/// <summary>
		/// Gets or Sets MaxRecords
		/// </summary>
		[DataMember(Name = "MaxRecords", EmitDefaultValue = false)]
		public int? MaxRecords { get; set; }

		/// <summary>
		/// Gets or Sets IncludeFields
		/// </summary>
		[DataMember(Name = "IncludeFields", EmitDefaultValue = false)]
		public List<string>? IncludeFields { get; set; }

		/// <summary>
		/// Gets or Sets Filter
		/// </summary>
		[DataMember(Name = "Filter", EmitDefaultValue = false)]
		public List<Filter>? Filter { get; set; }

		/// <summary>
		/// Gets or Sets Xml
		/// </summary>
		[DataMember(Name = "Xml", EmitDefaultValue = false)]
		public string? Xml { get; set; }
	}
}
