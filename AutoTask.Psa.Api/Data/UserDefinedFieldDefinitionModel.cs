using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// UserDefinedFieldDefinitionModel
	/// </summary>
	[DataContract]
	public partial class UserDefinedFieldDefinitionModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserDefinedFieldDefinitionModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CreateDate">CreateDate.</param>
		/// <param name="CrmToProjectUdfId">CrmToProjectUdfId.</param>
		/// <param name="DataType">DataType.</param>
		/// <param name="DefaultValue">DefaultValue.</param>
		/// <param name="Description">Description.</param>
		/// <param name="DisplayFormat">DisplayFormat.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsEncrypted">IsEncrypted.</param>
		/// <param name="IsFieldMapping">IsFieldMapping.</param>
		/// <param name="IsPrivate">IsPrivate.</param>
		/// <param name="IsProtected">IsProtected.</param>
		/// <param name="IsRequired">IsRequired.</param>
		/// <param name="IsVisibleToClientPortal">IsVisibleToClientPortal.</param>
		/// <param name="MergeVariableName">MergeVariableName.</param>
		/// <param name="Name">Name.</param>
		/// <param name="NumberOfDecimalPlaces">NumberOfDecimalPlaces.</param>
		/// <param name="SortOrder">SortOrder.</param>
		/// <param name="UdfType">UdfType.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public UserDefinedFieldDefinitionModel(long? Id = default, DateTime? CreateDate = default, long? CrmToProjectUdfId = default, int? DataType = default, Object DefaultValue = default, string Description = default, int? DisplayFormat = default, bool? IsActive = default, bool? IsEncrypted = default, bool? IsFieldMapping = default, bool? IsPrivate = default, bool? IsProtected = default, bool? IsRequired = default, bool? IsVisibleToClientPortal = default, string MergeVariableName = default, string Name = default, int? NumberOfDecimalPlaces = default, int? SortOrder = default, int? UdfType = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CreateDate = CreateDate;
			this.CrmToProjectUdfId = CrmToProjectUdfId;
			this.DataType = DataType;
			this.DefaultValue = DefaultValue;
			this.Description = Description;
			this.DisplayFormat = DisplayFormat;
			this.IsActive = IsActive;
			this.IsEncrypted = IsEncrypted;
			this.IsFieldMapping = IsFieldMapping;
			this.IsPrivate = IsPrivate;
			this.IsProtected = IsProtected;
			this.IsRequired = IsRequired;
			this.IsVisibleToClientPortal = IsVisibleToClientPortal;
			this.MergeVariableName = MergeVariableName;
			this.Name = Name;
			this.NumberOfDecimalPlaces = NumberOfDecimalPlaces;
			this.SortOrder = SortOrder;
			this.UdfType = UdfType;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate", EmitDefaultValue = false)]
		public DateTime? CreateDate { get; set; }

		/// <summary>
		/// Gets or Sets CrmToProjectUdfId
		/// </summary>
		[DataMember(Name = "CrmToProjectUdfId", EmitDefaultValue = false)]
		public long? CrmToProjectUdfId { get; set; }

		/// <summary>
		/// Gets or Sets DataType
		/// </summary>
		[DataMember(Name = "DataType", EmitDefaultValue = false)]
		public int? DataType { get; set; }

		/// <summary>
		/// Gets or Sets DefaultValue
		/// </summary>
		[DataMember(Name = "DefaultValue", EmitDefaultValue = false)]
		public Object DefaultValue { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets DisplayFormat
		/// </summary>
		[DataMember(Name = "DisplayFormat", EmitDefaultValue = false)]
		public int? DisplayFormat { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsEncrypted
		/// </summary>
		[DataMember(Name = "IsEncrypted", EmitDefaultValue = false)]
		public bool? IsEncrypted { get; set; }

		/// <summary>
		/// Gets or Sets IsFieldMapping
		/// </summary>
		[DataMember(Name = "IsFieldMapping", EmitDefaultValue = false)]
		public bool? IsFieldMapping { get; set; }

		/// <summary>
		/// Gets or Sets IsPrivate
		/// </summary>
		[DataMember(Name = "IsPrivate", EmitDefaultValue = false)]
		public bool? IsPrivate { get; set; }

		/// <summary>
		/// Gets or Sets IsProtected
		/// </summary>
		[DataMember(Name = "IsProtected", EmitDefaultValue = false)]
		public bool? IsProtected { get; set; }

		/// <summary>
		/// Gets or Sets IsRequired
		/// </summary>
		[DataMember(Name = "IsRequired", EmitDefaultValue = false)]
		public bool? IsRequired { get; set; }

		/// <summary>
		/// Gets or Sets IsVisibleToClientPortal
		/// </summary>
		[DataMember(Name = "IsVisibleToClientPortal", EmitDefaultValue = false)]
		public bool? IsVisibleToClientPortal { get; set; }

		/// <summary>
		/// Gets or Sets MergeVariableName
		/// </summary>
		[DataMember(Name = "MergeVariableName", EmitDefaultValue = false)]
		public string MergeVariableName { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets NumberOfDecimalPlaces
		/// </summary>
		[DataMember(Name = "NumberOfDecimalPlaces", EmitDefaultValue = false)]
		public int? NumberOfDecimalPlaces { get; set; }

		/// <summary>
		/// Gets or Sets SortOrder
		/// </summary>
		[DataMember(Name = "SortOrder", EmitDefaultValue = false)]
		public int? SortOrder { get; set; }

		/// <summary>
		/// Gets or Sets UdfType
		/// </summary>
		[DataMember(Name = "UdfType", EmitDefaultValue = false)]
		public int? UdfType { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
