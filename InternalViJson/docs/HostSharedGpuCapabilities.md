# Vcenter.ViJson.OpenApi.Model.HostSharedGpuCapabilities

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vgpu** | **string** | Name of a particular VGPU available as a shared GPU device.  See also *VirtualMachinePciSharedGpuPassthroughInfo*.  | 
**DiskSnapshotSupported** | **bool** | Indicates whether the GPU plugin on this host is capable of disk-only snapshots when VM is not powered off.  Disk Snaphosts on powered off VM are always supported.  | 
**MemorySnapshotSupported** | **bool** | Indicates whether the GPU plugin on this host is capable of memory snapshots.  | 
**SuspendSupported** | **bool** | Indicates whether the GPU plugin on this host is capable of suspend-resume.  | 
**MigrateSupported** | **bool** | Indicates whether the GPU plugin on this host is capable of migration.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

