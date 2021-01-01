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
		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public string Value { get; set; }

		/// <summary>
		/// Gets or Sets Label
		/// </summary>
		[DataMember(Name = "Label", EmitDefaultValue = false)]
		public string Label { get; set; }

		/// <summary>
		/// Gets or Sets IsDefaultValue
		/// </summary>
		[DataMember(Name = "IsDefaultValue", EmitDefaultValue = false)]
		public bool? IsDefaultValue { get; set; }

		/// <summary>
		/// Gets or Sets SortOrder
		/// </summary>
		[DataMember(Name = "SortOrder", EmitDefaultValue = false)]
		public int? SortOrder { get; set; }

		/// <summary>
		/// Gets or Sets ParentValue
		/// </summary>
		[DataMember(Name = "parentValue", EmitDefaultValue = false)]
		public string ParentValue { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsSystem
		/// </summary>
		[DataMember(Name = "IsSystem", EmitDefaultValue = false)]
		public bool? IsSystem { get; set; }
	}
}
