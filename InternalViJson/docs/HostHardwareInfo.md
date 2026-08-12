# Vcenter.ViJson.OpenApi.Model.HostHardwareInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SystemInfo** | [**HostSystemInfo**](HostSystemInfo.md) | Information about the system as a whole.  | 
**CpuPowerManagementInfo** | [**HostCpuPowerManagementInfo**](HostCpuPowerManagementInfo.md) |  | [optional] 
**CpuInfo** | [**HostCpuInfo**](HostCpuInfo.md) | Overall CPU information.  | 
**CpuPkg** | [**List&lt;HostCpuPackage&gt;**](HostCpuPackage.md) | Information about each of the physical CPU packages on the host.  | 
**MemorySize** | **long** | Total amount of physical memory on the host in bytes.  | 
**NumaInfo** | [**HostNumaInfo**](HostNumaInfo.md) | Information about the NUMA (non-uniform memory access).  | [optional] 
**SmcPresent** | **bool** | Presence of System Management Controller, indicates the host is Apple hardware, and thus capable of running Mac OS guest as VM.  | 
**PciDevice** | [**List&lt;HostPciDevice&gt;**](HostPciDevice.md) | The list of Peripheral Component Interconnect (PCI) devices available on this host.  | [optional] 
**DvxClasses** | [**List&lt;HostDvxClass&gt;**](HostDvxClass.md) | The list of Device Virtualization Extensions (DVX) classes available on this host.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**CpuFeature** | [**List&lt;HostCpuIdInfo&gt;**](HostCpuIdInfo.md) | CPU feature set that is supported by the hardware.  This is the intersection of the feature sets supported by the individual CPU packages. This feature set is modified by the *supportedCpuFeature* array in the host capabilities to obtain the feature set supported by the virtualization platform.  | [optional] 
**BiosInfo** | [**HostBIOSInfo**](HostBIOSInfo.md) | Information about the system BIOS  | [optional] 
**ReliableMemoryInfo** | [**HostReliableMemoryInfo**](HostReliableMemoryInfo.md) | Information about reliable memory.  | [optional] 
**PersistentMemoryInfo** | [**HostPersistentMemoryInfo**](HostPersistentMemoryInfo.md) | Persistent memory configuration on this host.  | [optional] 
**SgxInfo** | [**HostSgxInfo**](HostSgxInfo.md) | SGX configuration on this host.  | [optional] 
**SevInfo** | [**HostSevInfo**](HostSevInfo.md) | SEV configuration on this host.  ***Since:*** vSphere API Release 7.0.1.0  | [optional] 
**MemoryTieringType** | **string** | Type of memory tiering configured on this host.  See *HostMemoryTieringType_enum* for supported values. This field will be unset for legacy hosts as well as for hosts that don&#39;t support memory tiering.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**MemoryTierInfo** | [**List&lt;HostMemoryTierInfo&gt;**](HostMemoryTierInfo.md) | Configuration of each memory tier on this host.  The array is populated in the order of tiers (ie, tier 0 at array index 0, tier 1 at array index 1, and so on).  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**TdxInfo** | [**HostTdxInfo**](HostTdxInfo.md) | TDX (Trust Domain Extensions) configuration on this host.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

