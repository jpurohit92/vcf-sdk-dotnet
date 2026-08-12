# Vcenter.ViJson.OpenApi.Model.HostVmfsSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Extent** | [**HostScsiDiskPartition**](HostScsiDiskPartition.md) | Head extent of VMFS.  The head extent identifies the VMFS. However, the head extent should not be used to identify the VMFS across host reboots. The actual identifier is specified in \&quot;vmhbaI:T:L\&quot; format which is not guaranteed to be stable across reboots. Define a volume name that is unique to the host and use it to refer to the VMFS. Alternatively, the immutable UUID of the VMFS can be used after it is created.  | 
**BlockSizeMb** | **int** | Deprecated as of vSphere API 6.5, use *HostVmfsSpec.blockSize* instead.  The block size of VMFS in megabytes (MB).  Determines the maximum file size. If this optional property is not set, the maximum file size defaults to the maximum file size for the platform.  In VMFS2, the valid block sizes 1MB, 2MB, 4MB, 8MB, 16MB, 32MB, 64MB, 128MB, and 256MB. In VMFS3, the valid block sizes are 1MB, 2MB, 4MB, and 8MB. In VMFS5, the only valid block size is 1MB.  | [optional] 
**MajorVersion** | **int** | Major version number of VMFS.  This can be changed if the VMFS is upgraded, but this is an irreversible change.  | 
**VolumeName** | **string** | Volume name of VMFS.  | 
**BlockSize** | **int** | The block size of VMFS in kilotypes (KB).  Determines the maximum file size. If this optional property is not set, the maximum file size defaults to the maximum file size for the platform.  In VMFS3, the valid block sizes are 1MB, 2MB, 4MB, and 8MB. In VMFS5, the only valid block size is 1MB. In VMFS6, the valid block sizes are 64KB and 1MB.  | [optional] 
**UnmapGranularity** | **int** | The granularity of VMFS unmap operations.  VMFS unmap reclaims unused storage space. The unit is KB. The minimum unmap granularity is 8KB. The maximum unmap granularity is determined by the block size of VMFS *HostVmfsVolume.blockSize*.  | [optional] 
**UnmapPriority** | **string** | VMFS unmap priority.  VMFS unmap reclaims unused storage space. This determines the processing rate of unmaps. See *HostVmfsVolumeUnmapPriority_enum* for supported values.  | [optional] 
**UnmapBandwidthSpec** | [**VmfsUnmapBandwidthSpec**](VmfsUnmapBandwidthSpec.md) | VMFS unmap bandwidth related specification.  See *VmfsUnmapBandwidthSpec* for detail.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

