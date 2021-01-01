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
