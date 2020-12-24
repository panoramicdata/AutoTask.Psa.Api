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
		/// Initializes a new instance of the <see cref="QueryModel" /> class.
		/// </summary>
		/// <param name="MaxRecords">MaxRecords.</param>
		/// <param name="IncludeFields">IncludeFields.</param>
		/// <param name="Filter">Filter.</param>
		/// <param name="Xml">Xml.</param>
		public QueryModel(int? MaxRecords = default, List<string> IncludeFields = default, List<Filter> Filter = default, string Xml = default)
		{
			this.MaxRecords = MaxRecords;
			this.IncludeFields = IncludeFields;
			this.Filter = Filter;
			this.Xml = Xml;
		}

		/// <summary>
		/// Gets or Sets MaxRecords
		/// </summary>
		[DataMember(Name = "MaxRecords", EmitDefaultValue = false)]
		public int? MaxRecords { get; set; }

		/// <summary>
		/// Gets or Sets IncludeFields
		/// </summary>
		[DataMember(Name = "IncludeFields", EmitDefaultValue = false)]
		public List<string> IncludeFields { get; set; }

		/// <summary>
		/// Gets or Sets Filter
		/// </summary>
		[DataMember(Name = "Filter", EmitDefaultValue = false)]
		public List<Filter> Filter { get; set; }

		/// <summary>
		/// Gets or Sets Xml
		/// </summary>
		[DataMember(Name = "Xml", EmitDefaultValue = false)]
		public string Xml { get; set; }
	}
}
