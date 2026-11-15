namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ConfigurationItemExtModel
/// </summary>
[DataContract]
public class ConfigurationItemExtModel : ConfigurationItemModelBase
{
	/// <summary>
	/// Gets or Sets DattoKernelVersionID
	/// </summary>
	[DataMember(Name = "DattoKernelVersionID")]
	public string DattoKernelVersionID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DattoOSVersionID
	/// </summary>
	[DataMember(Name = "DattoOSVersionID")]
	public string DattoOSVersionID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DattoZFSVersionID
	/// </summary>
	[DataMember(Name = "DattoZFSVersionID")]
	public string DattoZFSVersionID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditAntivirusStatusID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditAntivirusStatusID")]
	public string RMMDeviceAuditAntivirusStatusID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditArchitectureID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditArchitectureID")]
	public string RMMDeviceAuditArchitectureID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditBackupStatusID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditBackupStatusID")]
	public string RMMDeviceAuditBackupStatusID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditDeviceTypeID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditDeviceTypeID")]
	public string RMMDeviceAuditDeviceTypeID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditDisplayAdaptorID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditDisplayAdaptorID")]
	public string RMMDeviceAuditDisplayAdaptorID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditDomainID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditDomainID")]
	public string RMMDeviceAuditDomainID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditManufacturerID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditManufacturerID")]
	public string RMMDeviceAuditManufacturerID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditMobileNetworkOperatorID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditMobileNetworkOperatorID")]
	public string RMMDeviceAuditMobileNetworkOperatorID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditModelID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditModelID")]
	public string RMMDeviceAuditModelID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditMotherboardID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditMotherboardID")]
	public string RMMDeviceAuditMotherboardID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditOperatingSystemID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditOperatingSystemID")]
	public string RMMDeviceAuditOperatingSystemID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditOperatingSystemNameID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditOperatingSystemNameID")]
	public string RMMDeviceAuditOperatingSystemNameID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditOperatingSystemVersionID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditOperatingSystemVersionID")]
	public string RMMDeviceAuditOperatingSystemVersionID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditPatchStatusID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditPatchStatusID")]
	public string RMMDeviceAuditPatchStatusID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditProcessorID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditProcessorID")]
	public string RMMDeviceAuditProcessorID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditServicePackID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditServicePackID")]
	public string RMMDeviceAuditServicePackID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditSoftwareStatusID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditSoftwareStatusID")]
	public string RMMDeviceAuditSoftwareStatusID { get; set; } = string.Empty;
}
