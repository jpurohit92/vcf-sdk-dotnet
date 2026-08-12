# Vcenter.ViJson.OpenApi.Model.GuestOsDescriptor

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier (short name) for the guest operating system.  | 
**Family** | **string** | Family to which this guest operating system belongs.  | 
**FullName** | **string** | Full name of the guest operating system.  For example, if the value of \&quot;id\&quot; is \&quot;win2000Pro\&quot;, then the value of \&quot;fullName\&quot; is \&quot;Windows 2000 Professional\&quot;.  | 
**SupportedMaxCPUs** | **int** | Maximum number of processors supported for this guest.  | 
**NumSupportedPhysicalSockets** | **int** | Maximum number of sockets supported for this guest.  | 
**NumSupportedCoresPerSocket** | **int** | Maximum number of cores per socket for this guest.  | 
**SupportedMinMemMB** | **int** | Minimum memory requirements supported for this guest, in MB.  | 
**SupportedMaxMemMB** | **int** | Maximum memory requirements supported for this guest, in MB.  | 
**RecommendedMemMB** | **int** | Recommended default memory size for this guest, in MB.  | 
**RecommendedColorDepth** | **int** | Recommended default color depth for this guest.  | 
**SupportedDiskControllerList** | **List&lt;string&gt;** | List of supported disk controller types for this guest.  | 
**RecommendedSCSIController** | **string** | Recommended default SCSI controller type for this guest.  | [optional] 
**RecommendedDiskController** | **string** | Recommended default disk controller type for this guest.  | 
**SupportedNumDisks** | **int** | Number of disks supported for this guest.  | 
**RecommendedDiskSizeMB** | **int** | Recommended default disk size for this guest, in MB.  | 
**RecommendedCdromController** | **string** | Recommended default CD-ROM type for this guest.  | 
**SupportedEthernetCard** | **List&lt;string&gt;** | List of supported ethernet cards for this guest.  | 
**RecommendedEthernetCard** | **string** | Recommended default ethernet controller type for this guest.  | [optional] 
**SupportsSlaveDisk** | **bool** | Flag to indicate whether or not this guest can support a disk configured as a slave.  | [optional] 
**CpuFeatureMask** | [**List&lt;HostCpuIdInfo&gt;**](HostCpuIdInfo.md) | Specifies the CPU feature compatibility masks.  | [optional] 
**SmcRequired** | **bool** | Flag that indicates whether the guest requires an SMC (Apple hardware).  This is logically equivalent to GuestOS &#x3D; Mac OS  | 
**SupportsWakeOnLan** | **bool** | Flag to indicate whether or not this guest can support Wake-on-LAN.  | 
**SupportsVMI** | **bool** | Flag indicating whether or not this guest supports the virtual machine interface.  | 
**SupportsMemoryHotAdd** | **bool** | Whether the memory size for this guest can be changed while the virtual machine is running.  | 
**SupportsCpuHotAdd** | **bool** | Whether virtual CPUs can be added to this guest while the virtual machine is running.  | 
**SupportsCpuHotRemove** | **bool** | Whether virtual CPUs can be removed from this guest while the virtual machine is running.  | 
**SupportedFirmware** | **List&lt;string&gt;** | Supported firmware types for this guest.  Possible values are described in *GuestOsDescriptorFirmwareType_enum*  | 
**RecommendedFirmware** | **string** | Recommended firmware type for this guest.  Possible values are described in *GuestOsDescriptorFirmwareType_enum*  | 
**SupportedUSBControllerList** | **List&lt;string&gt;** | List of supported USB controllers for this guest.  | [optional] 
**RecommendedUSBController** | **string** | Recommended default USB controller type for this guest.  | [optional] 
**Supports3D** | **bool** | Whether this guest supports 3D graphics.  | 
**Recommended3D** | **bool** | Recommended 3D graphics for this guest.  | 
**SmcRecommended** | **bool** | Whether SMC (Apple hardware) is recommended for this guest.  | 
**Ich7mRecommended** | **bool** | Whether I/O Controller Hub is recommended for this guest.  | 
**UsbRecommended** | **bool** | Whether USB controller is recommended for this guest.  | 
**SupportLevel** | **string** | Support level of this Guest Possible values are described in *GuestOsDescriptorSupportLevel_enum*  | 
**SupportedForCreate** | **bool** | Whether or not this guest should be allowed for selection during virtual machine creation.  | 
**VRAMSizeInKB** | [**IntOption**](IntOption.md) | Video RAM size limits supported by this guest, in KB.  | 
**NumSupportedFloppyDevices** | **int** | Maximum number of floppies supported by this guest.  | 
**WakeOnLanEthernetCard** | **List&lt;string&gt;** | List of NICs supported by this guest that support Wake-On-Lan.  | [optional] 
**SupportsPvscsiControllerForBoot** | **bool** | Whether or not this guest can use pvscsi as boot adapter.  | 
**DiskUuidEnabled** | **bool** | Whether or not this guest should have disk uuid enabled by default.  | 
**SupportsHotPlugPCI** | **bool** | Whether or not this guest supports hot plug of PCI devices.  | 
**SupportsSecureBoot** | **bool** | Whether or not this guest supports Secure Boot.  If some of the OS releases that fall under this guest OS descriptor support Secure Boot, it is reasonable to offer the ability to enable Secure Boot. Only meaningful when virtual EFI firmware is in use.  | [optional] 
**DefaultSecureBoot** | **bool** | Whether or not Secure Boot should be enabled by default for this guest OS.  If all OS releases that fall under this guest OS descriptor support Secure Boot and are known to operate correctly with Secure Boot enabled, it is reasonable to enable it by default. Only meaningful when virtual EFI firmware is in use.  | [optional] 
**PersistentMemorySupported** | **bool** | Support of persistent memory (virtual NVDIMM device).  See also *VirtualNVDIMM*.  | [optional] 
**SupportedMinPersistentMemoryMB** | **long** | Minimum persistent memory supported for this guest, in MB.  | [optional] 
**SupportedMaxPersistentMemoryMB** | **long** | Maximum persistent memory supported for this guest, in MB.  Total size of all the virtual NVDIMM devices should be less than this value.  | [optional] 
**RecommendedPersistentMemoryMB** | **long** | Recommended default persistent memory size for this guest, in MB.  | [optional] 
**PersistentMemoryHotAddSupported** | **bool** | Support of persistent memory hot-add operation.  | [optional] 
**PersistentMemoryHotRemoveSupported** | **bool** | Support of persistent memory hot-remove operation.  | [optional] 
**PersistentMemoryColdGrowthSupported** | **bool** | Support of virtual NVDIMM cold-growth operation.  | [optional] 
**PersistentMemoryColdGrowthGranularityMB** | **long** | Virtual NVDIMM cold-growth granularity in MB.  | [optional] 
**PersistentMemoryHotGrowthSupported** | **bool** | Support of virtual NVDIMM hot-growth operation.  | [optional] 
**PersistentMemoryHotGrowthGranularityMB** | **long** | Virtual NVDIMM hot-growth granularity in MB.  | [optional] 
**NumRecommendedPhysicalSockets** | **int** | Recommended number of sockets for this guest.  | [optional] 
**NumRecommendedCoresPerSocket** | **int** | Recommended number of cores per socket for this guest.  | [optional] 
**VvtdSupported** | [**BoolOption**](BoolOption.md) | Support of Intel Virtualization Technology for Directed I/O.  | [optional] 
**VbsSupported** | [**BoolOption**](BoolOption.md) | Support of Virtualization-based security.  | [optional] 
**VsgxSupported** | [**BoolOption**](BoolOption.md) | Support for Intel Software Guard Extensions  | [optional] 
**VsgxRemoteAttestationSupported** | **bool** | Support for Intel Software Guard Extensions remote attestation.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**SupportsTPM20** | **bool** | Support for TPM 2.0.  | [optional] 
**RecommendedTPM20** | **bool** | Support for default vTPM  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**VwdtSupported** | **bool** | Support for Virtual Watchdog Timer.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

