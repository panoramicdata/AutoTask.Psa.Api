namespace AutoTask.Psa.Api.Data;

/// <summary>
/// UserDefinedFieldDefinitionModel
/// </summary>
[DataContract]
public class UserDefinedFieldDefinitionModel : DescribedNamedEntityModelBase
{
	/// <summary>
	/// Gets or Sets CreateDate
	/// </summary>
	[DataMember(Name = "CreateDate")]
	public DateTime? CreateDate { get; set; }

	/// <summary>
	/// Gets or Sets CrmToProjectUdfId
	/// </summary>
	[DataMember(Name = "CrmToProjectUdfId")]
	public long? CrmToProjectUdfId { get; set; }

	/// <summary>
	/// Gets or Sets DataType
	/// </summary>
	[DataMember(Name = "DataType")]
	public int? DataType { get; set; }

	/// <summary>
	/// Gets or Sets DefaultValue
	/// </summary>
	[DataMember(Name = "DefaultValue")]
	public object? DefaultValue { get; set; }

	/// <summary>
	/// Gets or Sets DisplayFormat
	/// </summary>
	[DataMember(Name = "DisplayFormat")]
	public int? DisplayFormat { get; set; }

	/// <summary>
	/// Gets or Sets IsEncrypted
	/// </summary>
	[DataMember(Name = "IsEncrypted")]
	public bool? IsEncrypted { get; set; }

	/// <summary>
	/// Gets or Sets IsFieldMapping
	/// </summary>
	[DataMember(Name = "IsFieldMapping")]
	public bool? IsFieldMapping { get; set; }

	/// <summary>
	/// Gets or Sets IsPrivate
	/// </summary>
	[DataMember(Name = "IsPrivate")]
	public bool? IsPrivate { get; set; }

	/// <summary>
	/// Gets or Sets IsProtected
	/// </summary>
	[DataMember(Name = "IsProtected")]
	public bool? IsProtected { get; set; }

	/// <summary>
	/// Gets or Sets IsRequired
	/// </summary>
	[DataMember(Name = "IsRequired")]
	public bool? IsRequired { get; set; }

	/// <summary>
	/// Gets or Sets IsVisibleToClientPortal
	/// </summary>
	[DataMember(Name = "IsVisibleToClientPortal")]
	public bool? IsVisibleToClientPortal { get; set; }

	/// <summary>
	/// Gets or Sets MergeVariableName
	/// </summary>
	[DataMember(Name = "MergeVariableName")]
	public string MergeVariableName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets NumberOfDecimalPlaces
	/// </summary>
	[DataMember(Name = "NumberOfDecimalPlaces")]
	public int? NumberOfDecimalPlaces { get; set; }

	/// <summary>
	/// Gets or Sets SortOrder
	/// </summary>
	[DataMember(Name = "SortOrder")]
	public int? SortOrder { get; set; }

	/// <summary>
	/// Gets or Sets UdfType
	/// </summary>
	[DataMember(Name = "UdfType")]
	public int? UdfType { get; set; }
}
