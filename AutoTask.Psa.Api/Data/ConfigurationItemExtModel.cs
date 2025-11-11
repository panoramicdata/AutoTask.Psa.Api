namespace AutoTask.Psa.Api.Data;

/// <summary>
/// ConfigurationItemExtModel
/// </summary>
[DataContract]
public class ConfigurationItemExtModel
{
	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "Id")]
	public long? Id { get; set; }

	/// <summary>
	/// Gets or Sets ApiVendorID
	/// </summary>
	[DataMember(Name = "ApiVendorID")]
	public int? ApiVendorID { get; set; }

	/// <summary>
	/// Gets or Sets CompanyID
	/// </summary>
	[DataMember(Name = "CompanyID")]
	public int? CompanyID { get; set; }

	/// <summary>
	/// Gets or Sets CompanyLocationID
	/// </summary>
	[DataMember(Name = "CompanyLocationID")]
	public int? CompanyLocationID { get; set; }

	/// <summary>
	/// Gets or Sets ConfigurationItemCategoryID
	/// </summary>
	[DataMember(Name = "ConfigurationItemCategoryID")]
	public int? ConfigurationItemCategoryID { get; set; }

	/// <summary>
	/// Gets or Sets ConfigurationItemType
	/// </summary>
	[DataMember(Name = "ConfigurationItemType")]
	public int? ConfigurationItemType { get; set; }

	/// <summary>
	/// Gets or Sets ContactID
	/// </summary>
	[DataMember(Name = "ContactID")]
	public int? ContactID { get; set; }

	/// <summary>
	/// Gets or Sets ContractID
	/// </summary>
	[DataMember(Name = "ContractID")]
	public int? ContractID { get; set; }

	/// <summary>
	/// Gets or Sets ContractServiceBundleID
	/// </summary>
	[DataMember(Name = "ContractServiceBundleID")]
	public int? ContractServiceBundleID { get; set; }

	/// <summary>
	/// Gets or Sets ContractServiceID
	/// </summary>
	[DataMember(Name = "ContractServiceID")]
	public int? ContractServiceID { get; set; }

	/// <summary>
	/// Gets or Sets CreateDate
	/// </summary>
	[DataMember(Name = "CreateDate")]
	public DateTime? CreateDate { get; set; }

	/// <summary>
	/// Gets or Sets CreatedByPersonID
	/// </summary>
	[DataMember(Name = "CreatedByPersonID")]
	public int? CreatedByPersonID { get; set; }

	/// <summary>
	/// Gets or Sets DailyCost
	/// </summary>
	[DataMember(Name = "DailyCost")]
	public double? DailyCost { get; set; }

	/// <summary>
	/// Gets or Sets DattoAvailableKilobytes
	/// </summary>
	[DataMember(Name = "DattoAvailableKilobytes")]
	public long? DattoAvailableKilobytes { get; set; }

	/// <summary>
	/// Gets or Sets DattoDeviceMemoryMegabytes
	/// </summary>
	[DataMember(Name = "DattoDeviceMemoryMegabytes")]
	public int? DattoDeviceMemoryMegabytes { get; set; }

	/// <summary>
	/// Gets or Sets DattoDrivesErrors
	/// </summary>
	[DataMember(Name = "DattoDrivesErrors")]
	public bool? DattoDrivesErrors { get; set; }

	/// <summary>
	/// Gets or Sets DattoHostname
	/// </summary>
	[DataMember(Name = "DattoHostname")]
	public string DattoHostname { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DattoInternalIP
	/// </summary>
	[DataMember(Name = "DattoInternalIP")]
	public string DattoInternalIP { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DattoKernelVersionID
	/// </summary>
	[DataMember(Name = "DattoKernelVersionID")]
	public string DattoKernelVersionID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DattoLastCheckInDateTime
	/// </summary>
	[DataMember(Name = "DattoLastCheckInDateTime")]
	public DateTime? DattoLastCheckInDateTime { get; set; }

	/// <summary>
	/// Gets or Sets DattoNICSpeedKilobitsPerSecond
	/// </summary>
	[DataMember(Name = "DattoNICSpeedKilobitsPerSecond")]
	public int? DattoNICSpeedKilobitsPerSecond { get; set; }

	/// <summary>
	/// Gets or Sets DattoNumberOfAgents
	/// </summary>
	[DataMember(Name = "DattoNumberOfAgents")]
	public int? DattoNumberOfAgents { get; set; }

	/// <summary>
	/// Gets or Sets DattoNumberOfDrives
	/// </summary>
	[DataMember(Name = "DattoNumberOfDrives")]
	public int? DattoNumberOfDrives { get; set; }

	/// <summary>
	/// Gets or Sets DattoNumberOfVolumes
	/// </summary>
	[DataMember(Name = "DattoNumberOfVolumes")]
	public int? DattoNumberOfVolumes { get; set; }

	/// <summary>
	/// Gets or Sets DattoOffsiteUsedBytes
	/// </summary>
	[DataMember(Name = "DattoOffsiteUsedBytes")]
	public long? DattoOffsiteUsedBytes { get; set; }

	/// <summary>
	/// Gets or Sets DattoOSVersionID
	/// </summary>
	[DataMember(Name = "DattoOSVersionID")]
	public string DattoOSVersionID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DattoPercentageUsed
	/// </summary>
	[DataMember(Name = "DattoPercentageUsed")]
	public double? DattoPercentageUsed { get; set; }

	/// <summary>
	/// Gets or Sets DattoProtectedKilobytes
	/// </summary>
	[DataMember(Name = "DattoProtectedKilobytes")]
	public long? DattoProtectedKilobytes { get; set; }

	/// <summary>
	/// Gets or Sets DattoRemoteIP
	/// </summary>
	[DataMember(Name = "DattoRemoteIP")]
	public string DattoRemoteIP { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DattoSerialNumber
	/// </summary>
	[DataMember(Name = "DattoSerialNumber")]
	public string DattoSerialNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DattoUptimeSeconds
	/// </summary>
	[DataMember(Name = "DattoUptimeSeconds")]
	public int? DattoUptimeSeconds { get; set; }

	/// <summary>
	/// Gets or Sets DattoUsedKilobytes
	/// </summary>
	[DataMember(Name = "DattoUsedKilobytes")]
	public long? DattoUsedKilobytes { get; set; }

	/// <summary>
	/// Gets or Sets DattoZFSVersionID
	/// </summary>
	[DataMember(Name = "DattoZFSVersionID")]
	public string DattoZFSVersionID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DeviceNetworkingID
	/// </summary>
	[DataMember(Name = "DeviceNetworkingID")]
	public string DeviceNetworkingID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets HourlyCost
	/// </summary>
	[DataMember(Name = "HourlyCost")]
	public double? HourlyCost { get; set; }

	/// <summary>
	/// Gets or Sets ImpersonatorCreatorResourceID
	/// </summary>
	[DataMember(Name = "ImpersonatorCreatorResourceID")]
	public int? ImpersonatorCreatorResourceID { get; set; }

	/// <summary>
	/// Gets or Sets InstallDate
	/// </summary>
	[DataMember(Name = "InstallDate")]
	public DateTime? InstallDate { get; set; }

	/// <summary>
	/// Gets or Sets InstalledByContactID
	/// </summary>
	[DataMember(Name = "InstalledByContactID")]
	public int? InstalledByContactID { get; set; }

	/// <summary>
	/// Gets or Sets InstalledByID
	/// </summary>
	[DataMember(Name = "InstalledByID")]
	public int? InstalledByID { get; set; }

	/// <summary>
	/// Gets or Sets IsActive
	/// </summary>
	[DataMember(Name = "IsActive")]
	public bool? IsActive { get; set; }

	/// <summary>
	/// Gets or Sets LastActivityPersonID
	/// </summary>
	[DataMember(Name = "LastActivityPersonID")]
	public int? LastActivityPersonID { get; set; }

	/// <summary>
	/// Gets or Sets LastActivityPersonType
	/// </summary>
	[DataMember(Name = "LastActivityPersonType")]
	public int? LastActivityPersonType { get; set; }

	/// <summary>
	/// Gets or Sets LastModifiedTime
	/// </summary>
	[DataMember(Name = "LastModifiedTime")]
	public DateTime? LastModifiedTime { get; set; }

	/// <summary>
	/// Gets or Sets Location
	/// </summary>
	[DataMember(Name = "Location")]
	public string Location { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets MonthlyCost
	/// </summary>
	[DataMember(Name = "MonthlyCost")]
	public double? MonthlyCost { get; set; }

	/// <summary>
	/// Gets or Sets Notes
	/// </summary>
	[DataMember(Name = "Notes")]
	public string Notes { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets NumberOfUsers
	/// </summary>
	[DataMember(Name = "NumberOfUsers")]
	public double? NumberOfUsers { get; set; }

	/// <summary>
	/// Gets or Sets ParentConfigurationItemID
	/// </summary>
	[DataMember(Name = "ParentConfigurationItemID")]
	public int? ParentConfigurationItemID { get; set; }

	/// <summary>
	/// Gets or Sets PerUseCost
	/// </summary>
	[DataMember(Name = "PerUseCost")]
	public double? PerUseCost { get; set; }

	/// <summary>
	/// Gets or Sets ProductID
	/// </summary>
	[DataMember(Name = "ProductID")]
	public int? ProductID { get; set; }

	/// <summary>
	/// Gets or Sets ReferenceNumber
	/// </summary>
	[DataMember(Name = "ReferenceNumber")]
	public string ReferenceNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ReferenceTitle
	/// </summary>
	[DataMember(Name = "ReferenceTitle")]
	public string ReferenceTitle { get; set; } = string.Empty;

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
	/// Gets or Sets RMMDeviceAuditDescription
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditDescription")]
	public string RMMDeviceAuditDescription { get; set; } = string.Empty;

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
	/// Gets or Sets RMMDeviceAuditExternalIPAddress
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditExternalIPAddress")]
	public string RMMDeviceAuditExternalIPAddress { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditHostname
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditHostname")]
	public string RMMDeviceAuditHostname { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditIPAddress
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditIPAddress")]
	public string RMMDeviceAuditIPAddress { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditLastUser
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditLastUser")]
	public string RMMDeviceAuditLastUser { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditMacAddress
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditMacAddress")]
	public string RMMDeviceAuditMacAddress { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditManufacturerID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditManufacturerID")]
	public string RMMDeviceAuditManufacturerID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditMemoryBytes
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditMemoryBytes")]
	public long? RMMDeviceAuditMemoryBytes { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditMissingPatchCount
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditMissingPatchCount")]
	public int? RMMDeviceAuditMissingPatchCount { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceAuditMobileNetworkOperatorID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditMobileNetworkOperatorID")]
	public string RMMDeviceAuditMobileNetworkOperatorID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditMobileNumber
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditMobileNumber")]
	public string RMMDeviceAuditMobileNumber { get; set; } = string.Empty;

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
	/// Gets or Sets RMMDeviceAuditSNMPContact
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditSNMPContact")]
	public string RMMDeviceAuditSNMPContact { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditSNMPLocation
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditSNMPLocation")]
	public string RMMDeviceAuditSNMPLocation { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditSNMPName
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditSNMPName")]
	public string RMMDeviceAuditSNMPName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditSoftwareStatusID
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditSoftwareStatusID")]
	public string RMMDeviceAuditSoftwareStatusID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMDeviceAuditStorageBytes
	/// </summary>
	[DataMember(Name = "RMMDeviceAuditStorageBytes")]
	public long? RMMDeviceAuditStorageBytes { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceID
	/// </summary>
	[DataMember(Name = "RMMDeviceID")]
	public long? RMMDeviceID { get; set; }

	/// <summary>
	/// Gets or Sets RMMDeviceUID
	/// </summary>
	[DataMember(Name = "RMMDeviceUID")]
	public string RMMDeviceUID { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets RMMOpenAlertCount
	/// </summary>
	[DataMember(Name = "RMMOpenAlertCount")]
	public int? RMMOpenAlertCount { get; set; }

	/// <summary>
	/// Gets or Sets SerialNumber
	/// </summary>
	[DataMember(Name = "SerialNumber")]
	public string SerialNumber { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets ServiceBundleID
	/// </summary>
	[DataMember(Name = "ServiceBundleID")]
	public int? ServiceBundleID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceID
	/// </summary>
	[DataMember(Name = "ServiceID")]
	public int? ServiceID { get; set; }

	/// <summary>
	/// Gets or Sets ServiceLevelAgreementID
	/// </summary>
	[DataMember(Name = "ServiceLevelAgreementID")]
	public int? ServiceLevelAgreementID { get; set; }

	/// <summary>
	/// Gets or Sets SetupFee
	/// </summary>
	[DataMember(Name = "SetupFee")]
	public double? SetupFee { get; set; }

	/// <summary>
	/// Gets or Sets SourceChargeID
	/// </summary>
	[DataMember(Name = "SourceChargeID")]
	public int? SourceChargeID { get; set; }

	/// <summary>
	/// Gets or Sets SourceChargeType
	/// </summary>
	[DataMember(Name = "SourceChargeType")]
	public int? SourceChargeType { get; set; }

	/// <summary>
	/// Gets or Sets VendorID
	/// </summary>
	[DataMember(Name = "VendorID")]
	public int? VendorID { get; set; }

	/// <summary>
	/// Gets or Sets WarrantyExpirationDate
	/// </summary>
	[DataMember(Name = "WarrantyExpirationDate")]
	public DateTime? WarrantyExpirationDate { get; set; }

	/// <summary>
	/// Gets or Sets UserDefinedFields
	/// </summary>
	[DataMember(Name = "UserDefinedFields")]
	public List<UserDefinedField> UserDefinedFields { get; set; } = [];
}
