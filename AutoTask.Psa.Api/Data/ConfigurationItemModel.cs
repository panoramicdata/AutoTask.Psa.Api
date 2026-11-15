namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ConfigurationItemModel
/// </summary>
[DataContract]
public class ConfigurationItemModel : ConfigurationItemModelBase
{
	/// <summary>
	/// Gets or Sets DattoKernelVersionID
	/// </summary>
	[DataMember(Name = "DattoKernelVersionID")]
	public int? DattoKernelVersionID { get; set; }

	/// <summary>
	/// Gets or Sets DattoOSVersionID
	/// </summary>
	[DataMember(Name = "DattoOSVersionID")]
	public int? DattoOSVersionID { get; set; }

	/// <summary>
	/// Gets or Sets DattoZFSVersionID
	/// </summary>
	[DataMember(Name = "DattoZFSVersionID")]
	public int? DattoZFSVersionID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditAntivirusStatusID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditAntivirusStatusID")]
	public int? RMMDeviceAuditAntivirusStatusID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditArchitectureID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditArchitectureID")]
	public int? RMMDeviceAuditArchitectureID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditBackupStatusID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditBackupStatusID")]
	public int? RMMDeviceAuditBackupStatusID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditDeviceTypeID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditDeviceTypeID")]
	public int? RMMDeviceAuditDeviceTypeID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditDisplayAdaptorID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditDisplayAdaptorID")]
	public int? RMMDeviceAuditDisplayAdaptorID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditDomainID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditDomainID")]
	public int? RMMDeviceAuditDomainID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditManufacturerID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditManufacturerID")]
	public int? RMMDeviceAuditManufacturerID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditMobileNetworkOperatorID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditMobileNetworkOperatorID")]
	public int? RMMDeviceAuditMobileNetworkOperatorID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditModelID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditModelID")]
	public int? RMMDeviceAuditModelID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditMotherboardID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditMotherboardID")]
	public int? RMMDeviceAuditMotherboardID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditOperatingSystem
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditOperatingSystem")]
	public string RMMDeviceAuditOperatingSystem { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditPatchStatusID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditPatchStatusID")]
	public int? RMMDeviceAuditPatchStatusID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditProcessorID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditProcessorID")]
	public int? RMMDeviceAuditProcessorID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditServicePackID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditServicePackID")]
	public int? RMMDeviceAuditServicePackID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditSoftwareStatusID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditSoftwareStatusID")]
	public int? RMMDeviceAuditSoftwareStatusID { get; set; }
}
