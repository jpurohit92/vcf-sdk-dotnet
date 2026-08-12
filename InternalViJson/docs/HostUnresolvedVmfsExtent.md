# Vcenter.ViJson.OpenApi.Model.HostUnresolvedVmfsExtent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Device** | [**HostScsiDiskPartition**](HostScsiDiskPartition.md) | The device information  | 
**DevicePath** | **string** | The device path of an VMFS extent  | 
**VmfsUuid** | **string** | The UUID of the VMFS volume read from to the partition.  | 
**IsHeadExtent** | **bool** | Is this a copy of the head extent of the VMFS volume?  | 
**Ordinal** | **int** | A number indicating the order of an extent in a volume.  An extent with a lower ordinal value than another extent provides a range of blocks to a volume at an earlier block address range. Extents with the same ordinal provide the same range of blocks to a volume. A zero ordinal indicates that the extent is a head extent.  In the case each extent in the *HostUnresolvedVmfsVolume* is represented in the list of *HostUnresolvedVmfsExtent* data objects, the ordinal will refer to the absolute index of the extent in the volume. For example, ordinal \&quot;1\&quot; refers to the second extent; ordinal \&quot;2\&quot; refers to the third extent.  In the case that some extents of the volume are not represented in the *HostUnresolvedVmfsExtent* list, the ordinal will not precisely describe the position in the list of extents. A number will be skipped to indicate holes in the extent order. For example, given a volume with five extents with the second and third extents missing, the ordinal values in use will be {0, 2, 3}. The missing second and third extent are represented by the missing ordinal value \&quot;1\&quot; while the fourth and fifth extents will be assigned an ordinal of \&quot;2\&quot; and \&quot;3\&quot; respectively.  The reason the ordinals are not reliable in the case of missing extents is because the extents are identified by their start and end blocks. The ordinals are just a hint used to help indicate extents that correspond to the same start and end blocks.  | 
**StartBlock** | **int** | Index of the first block that this extent provides.  | 
**EndBlock** | **int** | Index of the last block that this extent provides.  | 
**Reason** | **string** | Reason as to why the partition is marked as copy of a VMFS volume&#39;s extent.  Possible reasons are the disk id is not matching with what the scsi inq is saying or disk uuid is not matching  See also *HostUnresolvedVmfsExtentUnresolvedReason_enum*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

