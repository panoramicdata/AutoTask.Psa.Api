using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// PickListValue
	/// </summary>
	[DataContract]
	public partial class PickListValue
	{
		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "Value")]
		public string Value { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Label
		/// </summary>
		[DataMember(Name = "Label")]
		public string Label { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets IsDefaultValue
		/// </summary>
		[DataMember(Name = "IsDefaultValue")]
		public bool? IsDefaultValue { get; set; }

		/// <summary>
		/// Gets or Sets SortOrder
		/// </summary>
		[DataMember(Name = "SortOrder")]
		public int? SortOrder { get; set; }

		/// <summary>
		/// Gets or Sets ParentValue
		/// </summary>
		[DataMember(Name = "parentValue")]
		public string ParentValue { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive")]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsSystem
		/// </summary>
		[DataMember(Name = "IsSystem")]
		public bool? IsSystem { get; set; }
	}
}
