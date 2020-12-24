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
		/// Initializes a new instance of the <see cref="ConfigurationItemExtModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ApiVendorID">ApiVendorID.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="CompanyLocationID">CompanyLocationID.</param>
		/// <param name="ConfigurationItemCategoryID">ConfigurationItemCategoryID.</param>
		/// <param name="ConfigurationItemType">ConfigurationItemType.</param>
		/// <param name="ContactID">ContactID.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="ContractServiceBundleID">ContractServiceBundleID.</param>
		/// <param name="ContractServiceID">ContractServiceID.</param>
		/// <param name="CreateDate">CreateDate.</param>
		/// <param name="CreatedByPersonID">CreatedByPersonID.</param>
		/// <param name="DailyCost">DailyCost.</param>
		/// <param name="DattoAvailableKilobytes">DattoAvailableKilobytes.</param>
		/// <param name="DattoDeviceMemoryMegabytes">DattoDeviceMemoryMegabytes.</param>
		/// <param name="DattoDrivesErrors">DattoDrivesErrors.</param>
		/// <param name="DattoHostname">DattoHostname.</param>
		/// <param name="DattoInternalIP">DattoInternalIP.</param>
		/// <param name="DattoKernelVersionID">DattoKernelVersionID.</param>
		/// <param name="DattoLastCheckInDateTime">DattoLastCheckInDateTime.</param>
		/// <param name="DattoNICSpeedKilobitsPerSecond">DattoNICSpeedKilobitsPerSecond.</param>
		/// <param name="DattoNumberOfAgents">DattoNumberOfAgents.</param>
		/// <param name="DattoNumberOfDrives">DattoNumberOfDrives.</param>
		/// <param name="DattoNumberOfVolumes">DattoNumberOfVolumes.</param>
		/// <param name="DattoOffsiteUsedBytes">DattoOffsiteUsedBytes.</param>
		/// <param name="DattoOSVersionID">DattoOSVersionID.</param>
		/// <param name="DattoPercentageUsed">DattoPercentageUsed.</param>
		/// <param name="DattoProtectedKilobytes">DattoProtectedKilobytes.</param>
		/// <param name="DattoRemoteIP">DattoRemoteIP.</param>
		/// <param name="DattoSerialNumber">DattoSerialNumber.</param>
		/// <param name="DattoUptimeSeconds">DattoUptimeSeconds.</param>
		/// <param name="DattoUsedKilobytes">DattoUsedKilobytes.</param>
		/// <param name="DattoZFSVersionID">DattoZFSVersionID.</param>
		/// <param name="DeviceNetworkingID">DeviceNetworkingID.</param>
		/// <param name="HourlyCost">HourlyCost.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="InstallDate">InstallDate.</param>
		/// <param name="InstalledByContactID">InstalledByContactID.</param>
		/// <param name="InstalledByID">InstalledByID.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="LastActivityPersonID">LastActivityPersonID.</param>
		/// <param name="LastActivityPersonType">LastActivityPersonType.</param>
		/// <param name="LastModifiedTime">LastModifiedTime.</param>
		/// <param name="Location">Location.</param>
		/// <param name="MonthlyCost">MonthlyCost.</param>
		/// <param name="Notes">Notes.</param>
		/// <param name="NumberOfUsers">NumberOfUsers.</param>
		/// <param name="ParentConfigurationItemID">ParentConfigurationItemID.</param>
		/// <param name="PerUseCost">PerUseCost.</param>
		/// <param name="ProductID">ProductID.</param>
		/// <param name="ReferenceNumber">ReferenceNumber.</param>
		/// <param name="ReferenceTitle">ReferenceTitle.</param>
		/// <param name="RMMDeviceAuditAntivirusStatusID">RMMDeviceAuditAntivirusStatusID.</param>
		/// <param name="RMMDeviceAuditArchitectureID">RMMDeviceAuditArchitectureID.</param>
		/// <param name="RMMDeviceAuditBackupStatusID">RMMDeviceAuditBackupStatusID.</param>
		/// <param name="RMMDeviceAuditDescription">RMMDeviceAuditDescription.</param>
		/// <param name="RMMDeviceAuditDeviceTypeID">RMMDeviceAuditDeviceTypeID.</param>
		/// <param name="RMMDeviceAuditDisplayAdaptorID">RMMDeviceAuditDisplayAdaptorID.</param>
		/// <param name="RMMDeviceAuditDomainID">RMMDeviceAuditDomainID.</param>
		/// <param name="RMMDeviceAuditExternalIPAddress">RMMDeviceAuditExternalIPAddress.</param>
		/// <param name="RMMDeviceAuditHostname">RMMDeviceAuditHostname.</param>
		/// <param name="RMMDeviceAuditIPAddress">RMMDeviceAuditIPAddress.</param>
		/// <param name="RMMDeviceAuditLastUser">RMMDeviceAuditLastUser.</param>
		/// <param name="RMMDeviceAuditMacAddress">RMMDeviceAuditMacAddress.</param>
		/// <param name="RMMDeviceAuditManufacturerID">RMMDeviceAuditManufacturerID.</param>
		/// <param name="RMMDeviceAuditMemoryBytes">RMMDeviceAuditMemoryBytes.</param>
		/// <param name="RMMDeviceAuditMissingPatchCount">RMMDeviceAuditMissingPatchCount.</param>
		/// <param name="RMMDeviceAuditMobileNetworkOperatorID">RMMDeviceAuditMobileNetworkOperatorID.</param>
		/// <param name="RMMDeviceAuditMobileNumber">RMMDeviceAuditMobileNumber.</param>
		/// <param name="RMMDeviceAuditModelID">RMMDeviceAuditModelID.</param>
		/// <param name="RMMDeviceAuditMotherboardID">RMMDeviceAuditMotherboardID.</param>
		/// <param name="RMMDeviceAuditOperatingSystemID">RMMDeviceAuditOperatingSystemID.</param>
		/// <param name="RMMDeviceAuditOperatingSystemNameID">RMMDeviceAuditOperatingSystemNameID.</param>
		/// <param name="RMMDeviceAuditOperatingSystemVersionID">RMMDeviceAuditOperatingSystemVersionID.</param>
		/// <param name="RMMDeviceAuditPatchStatusID">RMMDeviceAuditPatchStatusID.</param>
		/// <param name="RMMDeviceAuditProcessorID">RMMDeviceAuditProcessorID.</param>
		/// <param name="RMMDeviceAuditServicePackID">RMMDeviceAuditServicePackID.</param>
		/// <param name="RMMDeviceAuditSNMPContact">RMMDeviceAuditSNMPContact.</param>
		/// <param name="RMMDeviceAuditSNMPLocation">RMMDeviceAuditSNMPLocation.</param>
		/// <param name="RMMDeviceAuditSNMPName">RMMDeviceAuditSNMPName.</param>
		/// <param name="RMMDeviceAuditSoftwareStatusID">RMMDeviceAuditSoftwareStatusID.</param>
		/// <param name="RMMDeviceAuditStorageBytes">RMMDeviceAuditStorageBytes.</param>
		/// <param name="RMMDeviceID">RMMDeviceID.</param>
		/// <param name="RMMDeviceUID">RMMDeviceUID.</param>
		/// <param name="RMMOpenAlertCount">RMMOpenAlertCount.</param>
		/// <param name="SerialNumber">SerialNumber.</param>
		/// <param name="ServiceBundleID">ServiceBundleID.</param>
		/// <param name="ServiceID">ServiceID.</param>
		/// <param name="ServiceLevelAgreementID">ServiceLevelAgreementID.</param>
		/// <param name="SetupFee">SetupFee.</param>
		/// <param name="SourceChargeID">SourceChargeID.</param>
		/// <param name="SourceChargeType">SourceChargeType.</param>
		/// <param name="VendorID">VendorID.</param>
		/// <param name="WarrantyExpirationDate">WarrantyExpirationDate.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ConfigurationItemExtModel(long? Id = default, int? ApiVendorID = default, int? CompanyID = default, int? CompanyLocationID = default, int? ConfigurationItemCategoryID = default, int? ConfigurationItemType = default, int? ContactID = default, int? ContractID = default, int? ContractServiceBundleID = default, int? ContractServiceID = default, DateTime? CreateDate = default, int? CreatedByPersonID = default, double? DailyCost = default, long? DattoAvailableKilobytes = default, int? DattoDeviceMemoryMegabytes = default, bool? DattoDrivesErrors = default, string DattoHostname = default, string DattoInternalIP = default, string DattoKernelVersionID = default, DateTime? DattoLastCheckInDateTime = default, int? DattoNICSpeedKilobitsPerSecond = default, int? DattoNumberOfAgents = default, int? DattoNumberOfDrives = default, int? DattoNumberOfVolumes = default, long? DattoOffsiteUsedBytes = default, string DattoOSVersionID = default, double? DattoPercentageUsed = default, long? DattoProtectedKilobytes = default, string DattoRemoteIP = default, string DattoSerialNumber = default, int? DattoUptimeSeconds = default, long? DattoUsedKilobytes = default, string DattoZFSVersionID = default, string DeviceNetworkingID = default, double? HourlyCost = default, int? ImpersonatorCreatorResourceID = default, DateTime? InstallDate = default, int? InstalledByContactID = default, int? InstalledByID = default, bool? IsActive = default, int? LastActivityPersonID = default, int? LastActivityPersonType = default, DateTime? LastModifiedTime = default, string Location = default, double? MonthlyCost = default, string Notes = default, double? NumberOfUsers = default, int? ParentConfigurationItemID = default, double? PerUseCost = default, int? ProductID = default, string ReferenceNumber = default, string ReferenceTitle = default, string RMMDeviceAuditAntivirusStatusID = default, string RMMDeviceAuditArchitectureID = default, string RMMDeviceAuditBackupStatusID = default, string RMMDeviceAuditDescription = default, string RMMDeviceAuditDeviceTypeID = default, string RMMDeviceAuditDisplayAdaptorID = default, string RMMDeviceAuditDomainID = default, string RMMDeviceAuditExternalIPAddress = default, string RMMDeviceAuditHostname = default, string RMMDeviceAuditIPAddress = default, string RMMDeviceAuditLastUser = default, string RMMDeviceAuditMacAddress = default, string RMMDeviceAuditManufacturerID = default, long? RMMDeviceAuditMemoryBytes = default, int? RMMDeviceAuditMissingPatchCount = default, string RMMDeviceAuditMobileNetworkOperatorID = default, string RMMDeviceAuditMobileNumber = default, string RMMDeviceAuditModelID = default, string RMMDeviceAuditMotherboardID = default, string RMMDeviceAuditOperatingSystemID = default, string RMMDeviceAuditOperatingSystemNameID = default, string RMMDeviceAuditOperatingSystemVersionID = default, string RMMDeviceAuditPatchStatusID = default, string RMMDeviceAuditProcessorID = default, string RMMDeviceAuditServicePackID = default, string RMMDeviceAuditSNMPContact = default, string RMMDeviceAuditSNMPLocation = default, string RMMDeviceAuditSNMPName = default, string RMMDeviceAuditSoftwareStatusID = default, long? RMMDeviceAuditStorageBytes = default, long? RMMDeviceID = default, string RMMDeviceUID = default, int? RMMOpenAlertCount = default, string SerialNumber = default, int? ServiceBundleID = default, int? ServiceID = default, int? ServiceLevelAgreementID = default, double? SetupFee = default, int? SourceChargeID = default, int? SourceChargeType = default, int? VendorID = default, DateTime? WarrantyExpirationDate = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ApiVendorID = ApiVendorID;
			this.CompanyID = CompanyID;
			this.CompanyLocationID = CompanyLocationID;
			this.ConfigurationItemCategoryID = ConfigurationItemCategoryID;
			this.ConfigurationItemType = ConfigurationItemType;
			this.ContactID = ContactID;
			this.ContractID = ContractID;
			this.ContractServiceBundleID = ContractServiceBundleID;
			this.ContractServiceID = ContractServiceID;
			this.CreateDate = CreateDate;
			this.CreatedByPersonID = CreatedByPersonID;
			this.DailyCost = DailyCost;
			this.DattoAvailableKilobytes = DattoAvailableKilobytes;
			this.DattoDeviceMemoryMegabytes = DattoDeviceMemoryMegabytes;
			this.DattoDrivesErrors = DattoDrivesErrors;
			this.DattoHostname = DattoHostname;
			this.DattoInternalIP = DattoInternalIP;
			this.DattoKernelVersionID = DattoKernelVersionID;
			this.DattoLastCheckInDateTime = DattoLastCheckInDateTime;
			this.DattoNICSpeedKilobitsPerSecond = DattoNICSpeedKilobitsPerSecond;
			this.DattoNumberOfAgents = DattoNumberOfAgents;
			this.DattoNumberOfDrives = DattoNumberOfDrives;
			this.DattoNumberOfVolumes = DattoNumberOfVolumes;
			this.DattoOffsiteUsedBytes = DattoOffsiteUsedBytes;
			this.DattoOSVersionID = DattoOSVersionID;
			this.DattoPercentageUsed = DattoPercentageUsed;
			this.DattoProtectedKilobytes = DattoProtectedKilobytes;
			this.DattoRemoteIP = DattoRemoteIP;
			this.DattoSerialNumber = DattoSerialNumber;
			this.DattoUptimeSeconds = DattoUptimeSeconds;
			this.DattoUsedKilobytes = DattoUsedKilobytes;
			this.DattoZFSVersionID = DattoZFSVersionID;
			this.DeviceNetworkingID = DeviceNetworkingID;
			this.HourlyCost = HourlyCost;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.InstallDate = InstallDate;
			this.InstalledByContactID = InstalledByContactID;
			this.InstalledByID = InstalledByID;
			this.IsActive = IsActive;
			this.LastActivityPersonID = LastActivityPersonID;
			this.LastActivityPersonType = LastActivityPersonType;
			this.LastModifiedTime = LastModifiedTime;
			this.Location = Location;
			this.MonthlyCost = MonthlyCost;
			this.Notes = Notes;
			this.NumberOfUsers = NumberOfUsers;
			this.ParentConfigurationItemID = ParentConfigurationItemID;
			this.PerUseCost = PerUseCost;
			this.ProductID = ProductID;
			this.ReferenceNumber = ReferenceNumber;
			this.ReferenceTitle = ReferenceTitle;
			this.RMMDeviceAuditAntivirusStatusID = RMMDeviceAuditAntivirusStatusID;
			this.RMMDeviceAuditArchitectureID = RMMDeviceAuditArchitectureID;
			this.RMMDeviceAuditBackupStatusID = RMMDeviceAuditBackupStatusID;
			this.RMMDeviceAuditDescription = RMMDeviceAuditDescription;
			this.RMMDeviceAuditDeviceTypeID = RMMDeviceAuditDeviceTypeID;
			this.RMMDeviceAuditDisplayAdaptorID = RMMDeviceAuditDisplayAdaptorID;
			this.RMMDeviceAuditDomainID = RMMDeviceAuditDomainID;
			this.RMMDeviceAuditExternalIPAddress = RMMDeviceAuditExternalIPAddress;
			this.RMMDeviceAuditHostname = RMMDeviceAuditHostname;
			this.RMMDeviceAuditIPAddress = RMMDeviceAuditIPAddress;
			this.RMMDeviceAuditLastUser = RMMDeviceAuditLastUser;
			this.RMMDeviceAuditMacAddress = RMMDeviceAuditMacAddress;
			this.RMMDeviceAuditManufacturerID = RMMDeviceAuditManufacturerID;
			this.RMMDeviceAuditMemoryBytes = RMMDeviceAuditMemoryBytes;
			this.RMMDeviceAuditMissingPatchCount = RMMDeviceAuditMissingPatchCount;
			this.RMMDeviceAuditMobileNetworkOperatorID = RMMDeviceAuditMobileNetworkOperatorID;
			this.RMMDeviceAuditMobileNumber = RMMDeviceAuditMobileNumber;
			this.RMMDeviceAuditModelID = RMMDeviceAuditModelID;
			this.RMMDeviceAuditMotherboardID = RMMDeviceAuditMotherboardID;
			this.RMMDeviceAuditOperatingSystemID = RMMDeviceAuditOperatingSystemID;
			this.RMMDeviceAuditOperatingSystemNameID = RMMDeviceAuditOperatingSystemNameID;
			this.RMMDeviceAuditOperatingSystemVersionID = RMMDeviceAuditOperatingSystemVersionID;
			this.RMMDeviceAuditPatchStatusID = RMMDeviceAuditPatchStatusID;
			this.RMMDeviceAuditProcessorID = RMMDeviceAuditProcessorID;
			this.RMMDeviceAuditServicePackID = RMMDeviceAuditServicePackID;
			this.RMMDeviceAuditSNMPContact = RMMDeviceAuditSNMPContact;
			this.RMMDeviceAuditSNMPLocation = RMMDeviceAuditSNMPLocation;
			this.RMMDeviceAuditSNMPName = RMMDeviceAuditSNMPName;
			this.RMMDeviceAuditSoftwareStatusID = RMMDeviceAuditSoftwareStatusID;
			this.RMMDeviceAuditStorageBytes = RMMDeviceAuditStorageBytes;
			this.RMMDeviceID = RMMDeviceID;
			this.RMMDeviceUID = RMMDeviceUID;
			this.RMMOpenAlertCount = RMMOpenAlertCount;
			this.SerialNumber = SerialNumber;
			this.ServiceBundleID = ServiceBundleID;
			this.ServiceID = ServiceID;
			this.ServiceLevelAgreementID = ServiceLevelAgreementID;
			this.SetupFee = SetupFee;
			this.SourceChargeID = SourceChargeID;
			this.SourceChargeType = SourceChargeType;
			this.VendorID = VendorID;
			this.WarrantyExpirationDate = WarrantyExpirationDate;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		public string DattoHostname { get; set; }

		/// <summary>
		/// Gets or Sets DattoInternalIP
		/// </summary>
		[DataMember(Name = "DattoInternalIP", EmitDefaultValue = false)]
		public string DattoInternalIP { get; set; }

		/// <summary>
		/// Gets or Sets DattoKernelVersionID
		/// </summary>
		[DataMember(Name = "DattoKernelVersionID", EmitDefaultValue = false)]
		public string DattoKernelVersionID { get; set; }

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
		public string DattoOSVersionID { get; set; }

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
		public string DattoRemoteIP { get; set; }

		/// <summary>
		/// Gets or Sets DattoSerialNumber
		/// </summary>
		[DataMember(Name = "DattoSerialNumber", EmitDefaultValue = false)]
		public string DattoSerialNumber { get; set; }

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
		public string DattoZFSVersionID { get; set; }

		/// <summary>
		/// Gets or Sets DeviceNetworkingID
		/// </summary>
		[DataMember(Name = "DeviceNetworkingID", EmitDefaultValue = false)]
		public string DeviceNetworkingID { get; set; }

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
		public string Location { get; set; }

		/// <summary>
		/// Gets or Sets MonthlyCost
		/// </summary>
		[DataMember(Name = "MonthlyCost", EmitDefaultValue = false)]
		public double? MonthlyCost { get; set; }

		/// <summary>
		/// Gets or Sets Notes
		/// </summary>
		[DataMember(Name = "Notes", EmitDefaultValue = false)]
		public string Notes { get; set; }

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
		public string ReferenceNumber { get; set; }

		/// <summary>
		/// Gets or Sets ReferenceTitle
		/// </summary>
		[DataMember(Name = "ReferenceTitle", EmitDefaultValue = false)]
		public string ReferenceTitle { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditAntivirusStatusID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditAntivirusStatusID", EmitDefaultValue = false)]
		public string RMMDeviceAuditAntivirusStatusID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditArchitectureID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditArchitectureID", EmitDefaultValue = false)]
		public string RMMDeviceAuditArchitectureID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditBackupStatusID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditBackupStatusID", EmitDefaultValue = false)]
		public string RMMDeviceAuditBackupStatusID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditDescription
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditDescription", EmitDefaultValue = false)]
		public string RMMDeviceAuditDescription { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditDeviceTypeID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditDeviceTypeID", EmitDefaultValue = false)]
		public string RMMDeviceAuditDeviceTypeID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditDisplayAdaptorID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditDisplayAdaptorID", EmitDefaultValue = false)]
		public string RMMDeviceAuditDisplayAdaptorID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditDomainID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditDomainID", EmitDefaultValue = false)]
		public string RMMDeviceAuditDomainID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditExternalIPAddress
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditExternalIPAddress", EmitDefaultValue = false)]
		public string RMMDeviceAuditExternalIPAddress { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditHostname
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditHostname", EmitDefaultValue = false)]
		public string RMMDeviceAuditHostname { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditIPAddress
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditIPAddress", EmitDefaultValue = false)]
		public string RMMDeviceAuditIPAddress { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditLastUser
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditLastUser", EmitDefaultValue = false)]
		public string RMMDeviceAuditLastUser { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditMacAddress
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditMacAddress", EmitDefaultValue = false)]
		public string RMMDeviceAuditMacAddress { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditManufacturerID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditManufacturerID", EmitDefaultValue = false)]
		public string RMMDeviceAuditManufacturerID { get; set; }

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
		public string RMMDeviceAuditMobileNetworkOperatorID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditMobileNumber
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditMobileNumber", EmitDefaultValue = false)]
		public string RMMDeviceAuditMobileNumber { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditModelID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditModelID", EmitDefaultValue = false)]
		public string RMMDeviceAuditModelID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditMotherboardID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditMotherboardID", EmitDefaultValue = false)]
		public string RMMDeviceAuditMotherboardID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditOperatingSystemID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditOperatingSystemID", EmitDefaultValue = false)]
		public string RMMDeviceAuditOperatingSystemID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditOperatingSystemNameID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditOperatingSystemNameID", EmitDefaultValue = false)]
		public string RMMDeviceAuditOperatingSystemNameID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditOperatingSystemVersionID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditOperatingSystemVersionID", EmitDefaultValue = false)]
		public string RMMDeviceAuditOperatingSystemVersionID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditPatchStatusID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditPatchStatusID", EmitDefaultValue = false)]
		public string RMMDeviceAuditPatchStatusID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditProcessorID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditProcessorID", EmitDefaultValue = false)]
		public string RMMDeviceAuditProcessorID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditServicePackID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditServicePackID", EmitDefaultValue = false)]
		public string RMMDeviceAuditServicePackID { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditSNMPContact
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditSNMPContact", EmitDefaultValue = false)]
		public string RMMDeviceAuditSNMPContact { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditSNMPLocation
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditSNMPLocation", EmitDefaultValue = false)]
		public string RMMDeviceAuditSNMPLocation { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditSNMPName
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditSNMPName", EmitDefaultValue = false)]
		public string RMMDeviceAuditSNMPName { get; set; }

		/// <summary>
		/// Gets or Sets RMMDeviceAuditSoftwareStatusID
		/// </summary>
		[DataMember(Name = "RMMDeviceAuditSoftwareStatusID", EmitDefaultValue = false)]
		public string RMMDeviceAuditSoftwareStatusID { get; set; }

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
		public string RMMDeviceUID { get; set; }

		/// <summary>
		/// Gets or Sets RMMOpenAlertCount
		/// </summary>
		[DataMember(Name = "RMMOpenAlertCount", EmitDefaultValue = false)]
		public int? RMMOpenAlertCount { get; set; }

		/// <summary>
		/// Gets or Sets SerialNumber
		/// </summary>
		[DataMember(Name = "SerialNumber", EmitDefaultValue = false)]
		public string SerialNumber { get; set; }

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
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
