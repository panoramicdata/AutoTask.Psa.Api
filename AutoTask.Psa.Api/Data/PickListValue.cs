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
		/// Initializes a new instance of the <see cref="PickListValue" /> class.
		/// </summary>
		/// <param name="Value">Value.</param>
		/// <param name="Label">Label.</param>
		/// <param name="IsDefaultValue">IsDefaultValue.</param>
		/// <param name="SortOrder">SortOrder.</param>
		/// <param name="ParentValue">ParentValue.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsSystem">IsSystem.</param>
		public PickListValue(string Value = default, string Label = default, bool? IsDefaultValue = default, int? SortOrder = default, string ParentValue = default, bool? IsActive = default, bool? IsSystem = default)
		{
			this.Value = Value;
			this.Label = Label;
			this.IsDefaultValue = IsDefaultValue;
			this.SortOrder = SortOrder;
			this.ParentValue = ParentValue;
			this.IsActive = IsActive;
			this.IsSystem = IsSystem;
		}

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
