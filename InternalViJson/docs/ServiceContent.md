# Vcenter.ViJson.OpenApi.Model.ServiceContent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RootFolder** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the top of the inventory managed by this service.  Refers instance of *Folder*.  | 
**PropertyCollector** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to a per-session object for retrieving properties and updates.  Refers instance of *PropertyCollector*.  | 
**ViewManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object for tracking custom sets of objects.  Refers instance of *ViewManager*.  | [optional] 
**About** | [**AboutInfo**](AboutInfo.md) | Information about the service, such as the software version.  | 
**Setting** | [**ManagedObjectReference**](ManagedObjectReference.md) | Generic configuration for a management server.  This is for example by vCenter to store the vCenter Settings. This is not used for a stand-alone host, instead the vim.host.ConfigManager.advancedOption is used.  See also *HostConfigManager*.  Refers instance of *OptionManager*.  | [optional] 
**UserDirectory** | [**ManagedObjectReference**](ManagedObjectReference.md) | A user directory managed object.  Refers instance of *UserDirectory*.  | [optional] 
**SessionManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Managed object for logging in and managing sessions.  Refers instance of *SessionManager*.  | [optional] 
**AuthorizationManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Manages permissions for managed entities in the service.  Refers instance of *AuthorizationManager*.  | [optional] 
**ServiceManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages local services.  Refers instance of *ServiceManager*.  | [optional] 
**PerfManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages the collection and reporting of performance statistics.  Refers instance of *PerformanceManager*.  | [optional] 
**ScheduledTaskManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages scheduled tasks.  Refers instance of *ScheduledTaskManager*.  | [optional] 
**AlarmManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages alarms.  Refers instance of *AlarmManager*.  | [optional] 
**EventManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages events.  Refers instance of *EventManager*.  | [optional] 
**TaskManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages tasks.  Refers instance of *TaskManager*.  | [optional] 
**ExtensionManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages extensions.  Refers instance of *ExtensionManager*.  | [optional] 
**CustomizationSpecManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages saved guest customization specifications.  Refers instance of *CustomizationSpecManager*.  | [optional] 
**GuestCustomizationManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages guest customization of a running VM.  The typical usage is for the guest customization after the InstantClone operation. See *VirtualMachine.InstantClone_Task*.  Refers instance of *VirtualMachineGuestCustomizationManager*.  | [optional] 
**CustomFieldsManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that managed custom fields.  Refers instance of *CustomFieldsManager*.  | [optional] 
**AccountManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages host local user and group accounts.  Refers instance of *HostLocalAccountManager*.  | [optional] 
**DiagnosticManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that provides access to low-level log files.  Refers instance of *DiagnosticManager*.  | [optional] 
**LicenseManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages licensing  Refers instance of *LicenseManager*.  | [optional] 
**SearchIndex** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that allows search of the inventory  Refers instance of *SearchIndex*.  | [optional] 
**FileManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that allows management of files present on datastores.  Refers instance of *FileManager*.  | [optional] 
**DatastoreNamespaceManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Datastore Namespace manager.  A singleton managed object that is used to manage manipulations related to datastores&#39; namespaces.  Refers instance of *DatastoreNamespaceManager*.  | [optional] 
**VirtualDiskManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that allows management of virtual disks on datastores.  Refers instance of *VirtualDiskManager*.  | [optional] 
**VirtualizationManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | Deprecated as of VI API 2.5, use the VMware vCenter Converter plug-in.  A singleton managed object that manages the discovery, analysis, recommendation and virtualization of physical machines  Refers instance of *VirtualizationManager*.  | [optional] 
**SnmpSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that allows SNMP configuration.  Not set if not supported on a particular platform.  Refers instance of *HostSnmpSystem*.  | [optional] 
**VmProvisioningChecker** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that can answer questions about the feasibility of certain provisioning operations.  Refers instance of *VirtualMachineProvisioningChecker*.  | [optional] 
**VmCompatibilityChecker** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that can answer questions about compatibility of a virtual machine with a host.  Refers instance of *VirtualMachineCompatibilityChecker*.  | [optional] 
**OvfManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that can generate OVF descriptors (export) and create vApps (single-VM or vApp container-based) from OVF descriptors (import).  Refers instance of *OvfManager*.  | [optional] 
**IpPoolManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that supports management of IpPool objects.  IP pools are used when allocating IPv4 and IPv6 addresses to vApps.  Refers instance of *IpPoolManager*.  | [optional] 
**DvSwitchManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that provides relevant information of DistributedVirtualSwitch.  Refers instance of *DistributedVirtualSwitchManager*.  | [optional] 
**HostProfileManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages the host profiles.  Refers instance of *HostProfileManager*.  | [optional] 
**ClusterProfileManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages the cluster profiles.  Refers instance of *ClusterProfileManager*.  | [optional] 
**ComplianceManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages compliance aspects of entities.  Refers instance of *ProfileComplianceManager*.  | [optional] 
**LocalizationManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that provides methods for retrieving message catalogs for client-side localization support.  Refers instance of *LocalizationManager*.  | [optional] 
**StorageResourceManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that provides methods for storage resource management.  Refers instance of *StorageResourceManager*.  | [optional] 
**GuestOperationsManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that provides methods for guest operations.  Refers instance of *GuestOperationsManager*.  | [optional] 
**OverheadMemoryManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that provides methods for looking up static VM overhead memory.  Refers instance of *OverheadMemoryManager*.  | [optional] 
**CertificateManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | host certificate manager A singleton managed object to manage the certificates between the Certificate Server and the host.  Refers instance of *CertificateManager*.  | [optional] 
**IoFilterManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages IO Filters installed on the ESXi hosts and IO Filter configuration of virtual disks.  Refers instance of *IoFilterManager*.  | [optional] 
**VStorageObjectManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages all storage objects in the Virtual Infrastructure.  If connected to a vCenter, this is the *VcenterVStorageObjectManager*; If connected to an ESXi host, this is the *HostVStorageObjectManager*.  A storage object in the Virtual Infrastructure is represented by a vStorageObject.  Refers instance of *VStorageObjectManagerBase*.  | [optional] 
**HostSpecManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages the host specification data.  Refers instance of *HostSpecificationManager*.  | [optional] 
**CryptoManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object used to manage cryptographic keys.  Refers instance of *CryptoManager*.  | [optional] 
**HealthUpdateManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages the health updates.  Refers instance of *HealthUpdateManager*.  | [optional] 
**FailoverClusterConfigurator** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object that manages the VCHA Cluster configuration.  Refers instance of *FailoverClusterConfigurator*.  | [optional] 
**FailoverClusterManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object for managing a configured VCHA Cluster.  Refers instance of *FailoverClusterManager*.  | [optional] 
**TenantManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object used to configure tenants.  Refers instance of *TenantTenantManager*.  | [optional] 
**SiteInfoManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object used to manage site related capabilities.  Refers instance of *SiteInfoManager*.  | [optional] 
**StorageQueryManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object used to query storage related entities.  Refers instance of *StorageQueryManager*.  | [optional] 
**DirectPathProfileManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | A singleton managed object used to query DirectPath profiles.  ***Since:*** vSphere API Release 9.0.0.0  Refers instance of *DirectPathProfileManager*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

