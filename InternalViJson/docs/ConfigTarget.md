# Vcenter.ViJson.OpenApi.Model.ConfigTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumCpus** | **int** | Number of logical CPUs that can be used to run virtual machines.  If invoked against a cluster, this is the total number of logical CPUs available in the cluster.  | 
**NumCpuCores** | **int** | Number of physical CPU cores that are available to run virtual machines.  If invoked against a cluster, this is the total number of physical CPUs available in the cluster.  | 
**NumNumaNodes** | **int** | Number of NUMA nodes.  If invoked against a cluster, this is the total number of NUMA nodes available in the cluster.  | 
**MaxCpusPerHost** | **int** | Maximum number of CPUs available on a single host.  For standalone hosts, this value will be the same as numCpus.  | [optional] 
**SmcPresent** | **bool** | Presence of System Management Controller, indicates the host is Apple hardware, and thus capable of running Mac OS guest as VM.  | 
**Datastore** | [**List&lt;VirtualMachineDatastoreInfo&gt;**](VirtualMachineDatastoreInfo.md) | List of datastores available for virtual disks and associated storage.  | [optional] 
**Network** | [**List&lt;VirtualMachineNetworkInfo&gt;**](VirtualMachineNetworkInfo.md) | List of networks available for virtual network adapters.  | [optional] 
**OpaqueNetwork** | [**List&lt;OpaqueNetworkTargetInfo&gt;**](OpaqueNetworkTargetInfo.md) | List of opaque networks available for virtual network adapters.  | [optional] 
**DistributedVirtualPortgroup** | [**List&lt;DistributedVirtualPortgroupInfo&gt;**](DistributedVirtualPortgroupInfo.md) | List of networks available from DistributedVirtualSwitch for virtual network adapters.  | [optional] 
**DistributedVirtualSwitch** | [**List&lt;DistributedVirtualSwitchInfo&gt;**](DistributedVirtualSwitchInfo.md) | List of distributed virtual switch available for virtual network adapters.  | [optional] 
**SubnetInfo** | [**List&lt;SubnetInfo&gt;**](SubnetInfo.md) | List of subnets available for virtual network adapters.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**CdRom** | [**List&lt;VirtualMachineCdromInfo&gt;**](VirtualMachineCdromInfo.md) | List of CD-ROM devices available for use by virtual CD-ROMs.  Used for *VirtualCdromAtapiBackingInfo*.  | [optional] 
**Serial** | [**List&lt;VirtualMachineSerialInfo&gt;**](VirtualMachineSerialInfo.md) | List of serial devices available to support virtualization.  Used for *VirtualSerialPortDeviceBackingInfo*.  | [optional] 
**Parallel** | [**List&lt;VirtualMachineParallelInfo&gt;**](VirtualMachineParallelInfo.md) | List of parallel devices available to support virtualization.  Used for *VirtualParallelPortDeviceBackingInfo*.  | [optional] 
**Sound** | [**List&lt;VirtualMachineSoundInfo&gt;**](VirtualMachineSoundInfo.md) | List of sound devices available to support virtualization.  Used for *VirtualSoundCardDeviceBackingInfo*.  | [optional] 
**Usb** | [**List&lt;VirtualMachineUsbInfo&gt;**](VirtualMachineUsbInfo.md) | List of USB devices on the host that are available to support virtualization.  Used for *VirtualUSBUSBBackingInfo*.  | [optional] 
**Floppy** | [**List&lt;VirtualMachineFloppyInfo&gt;**](VirtualMachineFloppyInfo.md) | List of floppy devices available for use by virtual floppies.  Used for *VirtualFloppyDeviceBackingInfo*.  | [optional] 
**LegacyNetworkInfo** | [**List&lt;VirtualMachineLegacyNetworkSwitchInfo&gt;**](VirtualMachineLegacyNetworkSwitchInfo.md) | Legacy switch names when using the LegacyNetworkBacking types.  | [optional] 
**ScsiPassthrough** | [**List&lt;VirtualMachineScsiPassthroughInfo&gt;**](VirtualMachineScsiPassthroughInfo.md) | List of generic SCSI devices.  | [optional] 
**ScsiDisk** | [**List&lt;VirtualMachineScsiDiskDeviceInfo&gt;**](VirtualMachineScsiDiskDeviceInfo.md) | List of physical SCSI disks that can be used as targets for raw disk mapping backings.  | [optional] 
**IdeDisk** | [**List&lt;VirtualMachineIdeDiskDeviceInfo&gt;**](VirtualMachineIdeDiskDeviceInfo.md) | List of physical IDE disks that can be used as targets for raw disk backings.  | [optional] 
**MaxMemMBOptimalPerf** | **int** | Maximum recommended memory size, in MB, for creating a new virtual machine.  | 
**SupportedMaxMemMB** | **int** | Maximum supported memory size, in MB, for creating a new virtual machine.  Maximum allowed size is smaller of this and limit in *GuestOsDescriptor.supportedMaxMemMB*. When invoked on the cluster, maximum size that can be created on at least one host in the cluster is reported.  | [optional] 
**ResourcePool** | [**ResourcePoolRuntimeInfo**](ResourcePoolRuntimeInfo.md) | Information about the current available resources on the current resource pool for a virtual machine.  This field is only populated from an Environment browser obtained from a virtual machine.  | [optional] 
**AutoVmotion** | **bool** | Information whether a virtual machine with this ConfigTarget can auto vmotion.  This field is only populated from an Environment browser obtained from a virtual machine.  | [optional] 
**PciPassthrough** | [**List&lt;VirtualMachinePciPassthroughInfo&gt;**](VirtualMachinePciPassthroughInfo.md) | List of generic PCI devices.  | [optional] 
**Sriov** | [**List&lt;VirtualMachineSriovInfo&gt;**](VirtualMachineSriovInfo.md) | List of SRIOV devices.  | [optional] 
**VFlashModule** | [**List&lt;VirtualMachineVFlashModuleInfo&gt;**](VirtualMachineVFlashModuleInfo.md) | List of vFlash modules.  | [optional] 
**SharedGpuPassthroughTypes** | [**List&lt;VirtualMachinePciSharedGpuPassthroughInfo&gt;**](VirtualMachinePciSharedGpuPassthroughInfo.md) | List of shared GPU passthrough types.  | [optional] 
**AvailablePersistentMemoryReservationMB** | **long** | Maximum available persistent memory reservation on a compute resource in MB.  | [optional] 
**DynamicPassthrough** | [**List&lt;VirtualMachineDynamicPassthroughInfo&gt;**](VirtualMachineDynamicPassthroughInfo.md) | List of Dynamic DirectPath PCI devices.  | [optional] 
**SgxTargetInfo** | [**VirtualMachineSgxTargetInfo**](VirtualMachineSgxTargetInfo.md) | Intel SGX information.  | [optional] 
**PrecisionClockInfo** | [**List&lt;VirtualMachinePrecisionClockInfo&gt;**](VirtualMachinePrecisionClockInfo.md) | List of host clock resources available to support virtual precision clock device.  Used for *VirtualPrecisionClockSystemClockBackingInfo*  | [optional] 
**SevSupported** | **bool** | Indicates whether the compute resource is capable of running AMD Secure Encrypted Virtualization (SEV) enabled virtual machines.  The compute resource supports SEV when this value is set to true.  ***Since:*** vSphere API Release 7.0.1.0  | [optional] 
**VgpuDeviceInfo** | [**List&lt;VirtualMachineVgpuDeviceInfo&gt;**](VirtualMachineVgpuDeviceInfo.md) | List of vGPU device capabilities.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**VgpuProfileInfo** | [**List&lt;VirtualMachineVgpuProfileInfo&gt;**](VirtualMachineVgpuProfileInfo.md) | List of vGPU profile attributes.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**VendorDeviceGroupInfo** | [**List&lt;VirtualMachineVendorDeviceGroupInfo&gt;**](VirtualMachineVendorDeviceGroupInfo.md) | List of PCI Vendor Device Groups.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**MaxSimultaneousThreads** | **int** | Max SMT (Simultaneous multithreading) threads.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**DvxClassInfo** | [**List&lt;VirtualMachineDvxClassInfo&gt;**](VirtualMachineDvxClassInfo.md) | List of Device Virtualization Extensions (DVX) classes.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**SevSnpSupported** | **bool** | Indicates whether the compute resource is capable of running AMD Secure Encrypted Virtualization Secure Nested Paging (SEV-SNP) enabled virtual machines.  The compute resource supports SEV-SNP when this value is set to true.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**TdxSupported** | **bool** | Indicates whether the compute resource is capable of running INTEL Trusted Domain Extensions (TDX) enabled virtual machines.  The compute resource supports TDX when this value is set to true.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**VMotionBandwidth** | **List&lt;long&gt;** | The set of unique vMotion bandwidth(s), in Mbps, set up on the compute resource.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

