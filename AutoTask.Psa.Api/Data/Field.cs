using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// Field
	/// </summary>
	[DataContract]
	public partial class Field
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Field" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Label">Label.</param>
		/// <param name="Type">Type.</param>
		/// <param name="Length">Length.</param>
		/// <param name="Description">Description.</param>
		/// <param name="IsRequired">IsRequired.</param>
		/// <param name="IsReadOnly">IsReadOnly.</param>
		/// <param name="IsQueryable">IsQueryable.</param>
		/// <param name="IsReference">IsReference.</param>
		/// <param name="ReferenceEntityType">ReferenceEntityType.</param>
		/// <param name="IsPickList">IsPickList.</param>
		/// <param name="PicklistValues">PicklistValues.</param>
		/// <param name="PicklistParentValueField">PicklistParentValueField.</param>
		/// <param name="DefaultValue">DefaultValue.</param>
		/// <param name="IsSupportedWebhookField">IsSupportedWebhookField.</param>
		public Field(string Name = default, string Label = default, string Type = default, int? Length = default, string Description = default, bool? IsRequired = default, bool? IsReadOnly = default, bool? IsQueryable = default, bool? IsReference = default, string ReferenceEntityType = default, bool? IsPickList = default, List<PickListValue> PicklistValues = default, string PicklistParentValueField = default, string DefaultValue = default, Object IsSupportedWebhookField = default)
		{
			this.Name = Name;
			this.Label = Label;
			this.Type = Type;
			this.Length = Length;
			this.Description = Description;
			this.IsRequired = IsRequired;
			this.IsReadOnly = IsReadOnly;
			this.IsQueryable = IsQueryable;
			this.IsReference = IsReference;
			this.ReferenceEntityType = ReferenceEntityType;
			this.IsPickList = IsPickList;
			this.PicklistValues = PicklistValues;
			this.PicklistParentValueField = PicklistParentValueField;
			this.DefaultValue = DefaultValue;
			this.IsSupportedWebhookField = IsSupportedWebhookField;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets Label
		/// </summary>
		[DataMember(Name = "Label", EmitDefaultValue = false)]
		public string Label { get; set; }

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "Type", EmitDefaultValue = false)]
		public string Type { get; set; }

		/// <summary>
		/// Gets or Sets Length
		/// </summary>
		[DataMember(Name = "Length", EmitDefaultValue = false)]
		public int? Length { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets IsRequired
		/// </summary>
		[DataMember(Name = "IsRequired", EmitDefaultValue = false)]
		public bool? IsRequired { get; set; }

		/// <summary>
		/// Gets or Sets IsReadOnly
		/// </summary>
		[DataMember(Name = "IsReadOnly", EmitDefaultValue = false)]
		public bool? IsReadOnly { get; set; }

		/// <summary>
		/// Gets or Sets IsQueryable
		/// </summary>
		[DataMember(Name = "IsQueryable", EmitDefaultValue = false)]
		public bool? IsQueryable { get; set; }

		/// <summary>
		/// Gets or Sets IsReference
		/// </summary>
		[DataMember(Name = "IsReference", EmitDefaultValue = false)]
		public bool? IsReference { get; set; }

		/// <summary>
		/// Gets or Sets ReferenceEntityType
		/// </summary>
		[DataMember(Name = "ReferenceEntityType", EmitDefaultValue = false)]
		public string ReferenceEntityType { get; set; }

		/// <summary>
		/// Gets or Sets IsPickList
		/// </summary>
		[DataMember(Name = "IsPickList", EmitDefaultValue = false)]
		public bool? IsPickList { get; set; }

		/// <summary>
		/// Gets or Sets PicklistValues
		/// </summary>
		[DataMember(Name = "PicklistValues", EmitDefaultValue = false)]
		public List<PickListValue> PicklistValues { get; set; }

		/// <summary>
		/// Gets or Sets PicklistParentValueField
		/// </summary>
		[DataMember(Name = "PicklistParentValueField", EmitDefaultValue = false)]
		public string PicklistParentValueField { get; set; }

		/// <summary>
		/// Gets or Sets DefaultValue
		/// </summary>
		[DataMember(Name = "DefaultValue", EmitDefaultValue = false)]
		public string DefaultValue { get; set; }

		/// <summary>
		/// Gets or Sets IsSupportedWebhookField
		/// </summary>
		[DataMember(Name = "IsSupportedWebhookField", EmitDefaultValue = false)]
		public Object IsSupportedWebhookField { get; set; }
	}
}
