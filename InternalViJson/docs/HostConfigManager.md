# Vcenter.ViJson.OpenApi.Model.HostConfigManager

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpuScheduler** | [**ManagedObjectReference**](ManagedObjectReference.md) | The CPU scheduler that determines which threads execute on a CPU at any given time.  Refers instance of *HostCpuSchedulerSystem*.  | [optional] 
**DatastoreSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore manager.  Refers instance of *HostDatastoreSystem*.  | [optional] 
**MemoryManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | The memory manager on the host.  Refers instance of *HostMemorySystem*.  | [optional] 
**StorageSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | The storage configuration.  Refers instance of *HostStorageSystem*.  | [optional] 
**NetworkSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | The network system configuration.  Refers instance of *HostNetworkSystem*.  | [optional] 
**VmotionSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | Deprecated as of VI API 4.0, use *HostConfigManager.virtualNicManager* to manage the VMotion configuration of the host.  The VMotion configuration.  Refers instance of *HostVMotionSystem*.  | [optional] 
**VirtualNicManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | The VirtualNic configuration.  Refers instance of *HostVirtualNicManager*.  | [optional] 
**ServiceSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | The configuration of the host services (for example, SSH, FTP, and Telnet).  Refers instance of *HostServiceSystem*.  | [optional] 
**FirewallSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | The firewall configuration.  Refers instance of *HostFirewallSystem*.  | [optional] 
**AdvancedOption** | [**ManagedObjectReference**](ManagedObjectReference.md) | Advanced options.  Refers instance of *OptionManager*.  | [optional] 
**DiagnosticSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | The diagnostic for the ESX Server system.  Refers instance of *HostDiagnosticSystem*.  | [optional] 
**AutoStartManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Auto-start and auto-stop configuration.  Refers instance of *HostAutoStartManager*.  | [optional] 
**SnmpSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | Snmp configuration  Refers instance of *HostSnmpSystem*.  | [optional] 
**DateTimeSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | DateTime configuration  Refers instance of *HostDateTimeSystem*.  | [optional] 
**PatchManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host patch management.  Refers instance of *HostPatchManager*.  | [optional] 
**ImageConfigManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host image configuration management.  Refers instance of *HostImageConfigManager*.  | [optional] 
**BootDeviceSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | Boot device order management.  Refers instance of *HostBootDeviceSystem*.  | [optional] 
**FirmwareSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | Firmware management.  Refers instance of *HostFirmwareSystem*.  | [optional] 
**HealthStatusSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | System health status manager.  Refers instance of *HostHealthStatusSystem*.  | [optional] 
**PciPassthruSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | PciDeviceSystem for passthru.  Refers instance of *HostPciPassthruSystem*.  | [optional] 
**LicenseManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | License manager  Refers instance of *LicenseManager*.  | [optional] 
**KernelModuleSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | Kernel module configuration management.  Refers instance of *HostKernelModuleSystem*.  | [optional] 
**AuthenticationManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Authentication method configuration - for example, for Active Directory membership.  Refers instance of *HostAuthenticationManager*.  | [optional] 
**PowerSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | Power System manager.  Refers instance of *HostPowerSystem*.  | [optional] 
**CacheConfigurationManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host solid state drive cache configuration manager.  Refers instance of *HostCacheConfigurationManager*.  | [optional] 
**EsxAgentHostManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Esx Agent resource configuration manager  Refers instance of *HostEsxAgentHostManager*.  | [optional] 
**IscsiManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Iscsi Management Operations managed entity  Refers instance of *IscsiManager*.  | [optional] 
**VFlashManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | vFlash Manager  Refers instance of *HostVFlashManager*.  | [optional] 
**VsanSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | VsanSystem managed entity.  Refers instance of *HostVsanSystem*.  | [optional] 
**MessageBusProxy** | [**ManagedObjectReference**](ManagedObjectReference.md) | Common Message Bus proxy service.  This API shall always be present in vSphere API 6.0 or later.  Refers instance of *MessageBusProxy*.  | [optional] 
**UserDirectory** | [**ManagedObjectReference**](ManagedObjectReference.md) | A user directory managed object.  Refers instance of *UserDirectory*.  | [optional] 
**AccountManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A manager for host local user accounts.  Refers instance of *HostLocalAccountManager*.  | [optional] 
**HostAccessManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host access manager  Refers instance of *HostAccessManager*.  | [optional] 
**GraphicsManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host graphics manager.  Refers instance of *HostGraphicsManager*.  | [optional] 
**VsanInternalSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | VsanInternalSystem managed entity.  Refers instance of *HostVsanInternalSystem*.  | [optional] 
**CertificateManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host CertificateManager.  Refers instance of *HostCertificateManager*.  | [optional] 
**CryptoManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host CryptoManager.  Refers instance of *CryptoManager*.  | [optional] 
**NvdimmSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host Non-Volatile DIMM configuration manager  Refers instance of *HostNvdimmSystem*.  | [optional] 
**AssignableHardwareManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Assignable Hardware manager.  Refers instance of *HostAssignableHardwareManager*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

