using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ConfigurationItemExtModel
	/// </summary>
	[DataContract]
	public partial class ConfigurationItemExtModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ApiVendorID
		/// </summary>
		[DataMember(Name = "ApiVendorID", EmitDefaultValue = false)]
		public int? ApiVendorID { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets CompanyLocationID
		/// </summary>
		[DataMember(Name = "CompanyLocationID", EmitDefaultValue = false)]
		public int? CompanyLocationID { get; set; }

		/// <summary>
		/// Gets or Sets ConfigurationItemCategoryID
		/// </summary>
		[DataMember(Name = "ConfigurationItemCategoryID", EmitDefaultValue = false)]
		public int? ConfigurationItemCategoryID { get; set; }

		/// <summary>
		/// Gets or Sets ConfigurationItemType
		/// </summary>
		[DataMember(Name = "ConfigurationItemType", EmitDefaultValue = false)]
		public int? ConfigurationItemType { get; set; }

		/// <summary>
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public int? ContactID { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceBundleID
		/// </summary>
		[DataMember(Name = "ContractServiceBundleID", EmitDefaultValue = false)]
		public int? ContractServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceID
		/// </summary>
		[DataMember(Name = "ContractServiceID", EmitDefaultValue = false)]
		public int? ContractServiceID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate", EmitDefaultValue = false)]
		public DateTime? CreateDate { get; set; }

		/// <summary>
		/// Gets or Sets CreatedByPersonID
		/// </summary>
		[DataMember(Name = "CreatedByPersonID", EmitDefaultValue = false)]
		public int? CreatedByPersonID { get; set; }

		/// <summary>
		/// Gets or Sets DailyCost
		/// </summary>
		[DataMember(Name = "DailyCost", EmitDefaultValue = false)]
		public double? DailyCost { get; set; }

		/// <summary>
		/// Gets or Sets DattoAvailableKilobytes
		/// </summary>
		[DataMember(Name = "DattoAvailableKilobytes", EmitDefaultValue = false)]
		public long? DattoAvailableKilobytes { get; set; }

		/// <summary>
		/// Gets or Sets DattoDeviceMemoryMegabytes
		/// </summary>
		[DataMember(Name = "DattoDeviceMemoryMegabytes", EmitDefaultValue = false)]
		public int? DattoDeviceMemoryMegabytes { get; set; }

		/// <summary>
		/// Gets or Sets DattoDrivesErrors
		/// </summary>
		[DataMember(Name = "DattoDrivesErrors", EmitDefaultValue = false)]
		public bool? DattoDrivesErrors { get; set; }

		/// <summary>
		/// Gets or Sets DattoHostname
		/// </summary>
		[DataMember(Name = "DattoHostname", EmitDefaultValue = false)]
		public string DattoHostname { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DattoInternalIP
		/// </summary>
		[DataMember(Name = "DattoInternalIP", EmitDefaultValue = false)]
		public string DattoInternalIP { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DattoKernelVersionID
		/// </summary>
		[DataMember(Name = "DattoKernelVersionID", EmitDefaultValue = false)]
		public string DattoKernelVersionID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DattoLastCheckInDateTime
		/// </summary>
		[DataMember(Name = "DattoLastCheckInDateTime", EmitDefaultValue = false)]
		public DateTime? DattoLastCheckInDateTime { get; set; }

		/// <summary>
		/// Gets or Sets DattoNICSpeedKilobitsPerSecond
		/// </summary>
		[DataMember(Name = "DattoNICSpeedKilobitsPerSecond", EmitDefaultValue = false)]
		public int? DattoNICSpeedKilobitsPerSecond { get; set; }

		/// <summary>
		/// Gets or Sets DattoNumberOfAgents
		/// </summary>
		[DataMember(Name = "DattoNumberOfAgents", EmitDefaultValue = false)]
		public int? DattoNumberOfAgents { get; set; }

		/// <summary>
		/// Gets or Sets DattoNumberOfDrives
		/// </summary>
		[DataMember(Name = "DattoNumberOfDrives", EmitDefaultValue = false)]
		public int? DattoNumberOfDrives { get; set; }

		/// <summary>
		/// Gets or Sets DattoNumberOfVolumes
		/// </summary>
		[DataMember(Name = "DattoNumberOfVolumes", EmitDefaultValue = false)]
		public int? DattoNumberOfVolumes { get; set; }

		/// <summary>
		/// Gets or Sets DattoOffsiteUsedBytes
		/// </summary>
		[DataMember(Name = "DattoOffsiteUsedBytes", EmitDefaultValue = false)]
		public long? DattoOffsiteUsedBytes { get; set; }

		/// <summary>
		/// Gets or Sets DattoOSVersionID
		/// </summary>
		[DataMember(Name = "DattoOSVersionID", EmitDefaultValue = false)]
		public string DattoOSVersionID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DattoPercentageUsed
		/// </summary>
		[DataMember(Name = "DattoPercentageUsed", EmitDefaultValue = false)]
		public double? DattoPercentageUsed { get; set; }

		/// <summary>
		/// Gets or Sets DattoProtectedKilobytes
		/// </summary>
		[DataMember(Name = "DattoProtectedKilobytes", EmitDefaultValue = false)]
		public long? DattoProtectedKilobytes { get; set; }

		/// <summary>
		/// Gets or Sets DattoRemoteIP
		/// </summary>
		[DataMember(Name = "DattoRemoteIP", EmitDefaultValue = false)]
		public string DattoRemoteIP { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DattoSerialNumber
		/// </summary>
		[DataMember(Name = "DattoSerialNumber", EmitDefaultValue = false)]
		public string DattoSerialNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DattoUptimeSeconds
		/// </summary>
		[DataMember(Name = "DattoUptimeSeconds", EmitDefaultValue = false)]
		public int? DattoUptimeSeconds { get; set; }

		/// <summary>
		/// Gets or Sets DattoUsedKilobytes
		/// </summary>
		[DataMember(Name = "DattoUsedKilobytes", EmitDefaultValue = false)]
		public long? DattoUsedKilobytes { get; set; }

		/// <summary>
		/// Gets or Sets DattoZFSVersionID
		/// </summary>
		[DataMember(Name = "DattoZFSVersionID", EmitDefaultValue = false)]
		public string DattoZFSVersionID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DeviceNetworkingID
		/// </summary>
		[DataMember(Name = "DeviceNetworkingID", EmitDefaultValue = false)]
		public string DeviceNetworkingID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets HourlyCost
		/// </summary>
		[DataMember(Name = "HourlyCost", EmitDefaultValue = false)]
		public double? HourlyCost { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets InstallDate
		/// </summary>
		[DataMember(Name = "InstallDate", EmitDefaultValue = false)]
		public DateTime? InstallDate { get; set; }

		/// <summary>
		/// Gets or Sets InstalledByContactID
		/// </summary>
		[DataMember(Name = "InstalledByContactID", EmitDefaultValue = false)]
		public int? InstalledByContactID { get; set; }

		/// <summary>
		/// Gets or Sets InstalledByID
		/// </summary>
		[DataMember(Name = "InstalledByID", EmitDefaultValue = false)]
		public int? InstalledByID { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityPersonID
		/// </summary>
		[DataMember(Name = "LastActivityPersonID", EmitDefaultValue = false)]
		public int? LastActivityPersonID { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityPersonType
		/// </summary>
		[DataMember(Name = "LastActivityPersonType", EmitDefaultValue = false)]
		public int? LastActivityPersonType { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedTime
		/// </summary>
		[DataMember(Name = "LastModifiedTime", EmitDefaultValue = false)]
		public DateTime? LastModifiedTime { get; set; }

		/// <summary>
		/// Gets or Sets Location
		/// </summary>
		[DataMember(Name = "Location", EmitDefaultValue = false)]
		public string Location { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets MonthlyCost
		/// </summary>
		[DataMember(Name = "MonthlyCost", EmitDefaultValue = false)]
		public double? MonthlyCost { get; set; }

		/// <summary>
		/// Gets or Sets Notes
		/// </summary>
		[DataMember(Name = "Notes", EmitDefaultValue = false)]
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets NumberOfUsers
		/// </summary>
		[DataMember(Name = "NumberOfUsers", EmitDefaultValue = false)]
		public double? NumberOfUsers { get; set; }

		/// <summary>
		/// Gets or Sets ParentConfigurationItemID
		/// </summary>
		[DataMember(Name = "ParentConfigurationItemID", EmitDefaultValue = false)]
		public int? ParentConfigurationItemID { get; set; }

		/// <summary>
		/// Gets or Sets PerUseCost
		/// </summary>
		[DataMember(Name = "PerUseCost", EmitDefaultValue = false)]
		public double? PerUseCost { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public int? ProductID { get; set; }

		/// <summary>
		/// Gets or Sets ReferenceNumber
		/// </summary>
		[DataMember(Name = "ReferenceNumber", EmitDefaultValue = false)]
		public string ReferenceNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ReferenceTitle
		/// </summary>
		[DataMember(Name = "ReferenceTitle", EmitDefaultValue = false)]
		public string ReferenceTitle { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditAntivirusStatusID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditAntivirusStatusID", EmitDefaultValue = false)]
		public string RMMDeviceAuditAntivirusStatusID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditArchitectureID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditArchitectureID", EmitDefaultValue = false)]
		public string RMMDeviceAuditArchitectureID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditBackupStatusID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditBackupStatusID", EmitDefaultValue = false)]
		public string RMMDeviceAuditBackupStatusID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditDescription
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditDescription", EmitDefaultValue = false)]
		public string RMMDeviceAuditDescription { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditDeviceTypeID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditDeviceTypeID", EmitDefaultValue = false)]
		public string RMMDeviceAuditDeviceTypeID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditDisplayAdaptorID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditDisplayAdaptorID", EmitDefaultValue = false)]
		public string RMMDeviceAuditDisplayAdaptorID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditDomainID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditDomainID", EmitDefaultValue = false)]
		public string RMMDeviceAuditDomainID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditExternalIPAddress
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditExternalIPAddress", EmitDefaultValue = false)]
		public string RMMDeviceAuditExternalIPAddress { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditHostname
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditHostname", EmitDefaultValue = false)]
		public string RMMDeviceAuditHostname { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditIPAddress
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditIPAddress", EmitDefaultValue = false)]
		public string RMMDeviceAuditIPAddress { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditLastUser
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditLastUser", EmitDefaultValue = false)]
		public string RMMDeviceAuditLastUser { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditMacAddress
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditMacAddress", EmitDefaultValue = false)]
		public string RMMDeviceAuditMacAddress { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditManufacturerID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditManufacturerID", EmitDefaultValue = false)]
		public string RMMDeviceAuditManufacturerID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditMemoryBytes
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditMemoryBytes", EmitDefaultValue = false)]
		public long? RMMDeviceAuditMemoryBytes { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditMissingPatchCount
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditMissingPatchCount", EmitDefaultValue = false)]
		public int? RMMDeviceAuditMissingPatchCount { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditMobileNetworkOperatorID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditMobileNetworkOperatorID", EmitDefaultValue = false)]
		public string RMMDeviceAuditMobileNetworkOperatorID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditMobileNumber
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditMobileNumber", EmitDefaultValue = false)]
		public string RMMDeviceAuditMobileNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditModelID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditModelID", EmitDefaultValue = false)]
		public string RMMDeviceAuditModelID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditMotherboardID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditMotherboardID", EmitDefaultValue = false)]
		public string RMMDeviceAuditMotherboardID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditOperatingSystemID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditOperatingSystemID", EmitDefaultValue = false)]
		public string RMMDeviceAuditOperatingSystemID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditOperatingSystemNameID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditOperatingSystemNameID", EmitDefaultValue = false)]
		public string RMMDeviceAuditOperatingSystemNameID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditOperatingSystemVersionID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditOperatingSystemVersionID", EmitDefaultValue = false)]
		public string RMMDeviceAuditOperatingSystemVersionID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditPatchStatusID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditPatchStatusID", EmitDefaultValue = false)]
		public string RMMDeviceAuditPatchStatusID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditProcessorID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditProcessorID", EmitDefaultValue = false)]
		public string RMMDeviceAuditProcessorID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditServicePackID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditServicePackID", EmitDefaultValue = false)]
		public string RMMDeviceAuditServicePackID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditSNMPContact
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditSNMPContact", EmitDefaultValue = false)]
		public string RMMDeviceAuditSNMPContact { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditSNMPLocation
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditSNMPLocation", EmitDefaultValue = false)]
		public string RMMDeviceAuditSNMPLocation { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditSNMPName
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditSNMPName", EmitDefaultValue = false)]
		public string RMMDeviceAuditSNMPName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditSoftwareStatusID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditSoftwareStatusID", EmitDefaultValue = false)]
		public string RMMDeviceAuditSoftwareStatusID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMDeviceAuditStorageBytes
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditStorageBytes", EmitDefaultValue = false)]
		public long? RMMDeviceAuditStorageBytes { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceID
		/// </summary>
		[DataMember(Name = "RMMDeviceID", EmitDefaultValue = false)]
		public long? RMMDeviceID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceUID
		/// </summary>
		[DataMember(Name = "RMMDeviceUID", EmitDefaultValue = false)]
		public string RMMDeviceUID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets RMMOpenAlertCount
		/// </summary>
		[DataMember(Name = "RMMOpenAlertCount", EmitDefaultValue = false)]
		public int? RMMOpenAlertCount { get; set; }

		/// <summary>
		/// Gets or Sets SerialNumber
		/// </summary>
		[DataMember(Name = "SerialNumber", EmitDefaultValue = false)]
		public string SerialNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ServiceBundleID
		/// </summary>
		[DataMember(Name = "ServiceBundleID", EmitDefaultValue = false)]
		public int? ServiceBundleID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceID
		/// </summary>
		[DataMember(Name = "ServiceID", EmitDefaultValue = false)]
		public int? ServiceID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceLevelAgreementID
		/// </summary>
		[DataMember(Name = "ServiceLevelAgreementID", EmitDefaultValue = false)]
		public int? ServiceLevelAgreementID { get; set; }

		/// <summary>
		/// Gets or Sets SetupFee
		/// </summary>
		[DataMember(Name = "SetupFee", EmitDefaultValue = false)]
		public double? SetupFee { get; set; }

		/// <summary>
		/// Gets or Sets SourceChargeID
		/// </summary>
		[DataMember(Name = "SourceChargeID", EmitDefaultValue = false)]
		public int? SourceChargeID { get; set; }

		/// <summary>
		/// Gets or Sets SourceChargeType
		/// </summary>
		[DataMember(Name = "SourceChargeType", EmitDefaultValue = false)]
		public int? SourceChargeType { get; set; }

		/// <summary>
		/// Gets or Sets VendorID
		/// </summary>
		[DataMember(Name = "VendorID", EmitDefaultValue = false)]
		public int? VendorID { get; set; }

		/// <summary>
		/// Gets or Sets WarrantyExpirationDate
		/// </summary>
		[DataMember(Name = "WarrantyExpirationDate", EmitDefaultValue = false)]
		public DateTime? WarrantyExpirationDate { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
