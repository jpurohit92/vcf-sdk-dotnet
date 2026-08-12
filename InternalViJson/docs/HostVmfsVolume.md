# Vcenter.ViJson.OpenApi.Model.HostVmfsVolume

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | FileSystemType of this particular file system See *HostFileSystemVolumeFileSystemType_enum*  | 
**Name** | **string** | Name of the file system volume.  | 
**Capacity** | **long** | The capacity of the file system volume, in bytes.  | 
**BlockSizeMb** | **int** | Deprecated as of vSphere API 6.5, use *HostVmfsVolume.blockSize* instead.  Block size of VMFS.  Determines maximum file size. The maximum number of blocks is typically fixed with each specific version of VMFS. To increase the maximum size of a VMFS file, increase the block size.  The minimum block size is 1MB.  | 
**BlockSize** | **int** | Block size of VMFS in KB.  Determines maximum file size. The maximum number of blocks is typically fixed with each specific version of VMFS. To increase the maximum size of a VMFS file, increase the block size.  The minimum block size is 1MB.  | [optional] 
**UnmapGranularity** | **int** | VMFS unmap reclaims unused storage space.  This property determines the granularity of unmap operations. The unit is KB. If not specified, the default value is the same as the block size of VMFS *HostVmfsVolume.blockSize*. This property cannot be changed after a VMFS volume is created.  | [optional] 
**UnmapPriority** | **string** | VMFS unmap reclaims unused storage space.  This property determines the processing rate of unmaps. See *HostVmfsVolumeUnmapPriority_enum* for supported values. If not specified, the default value is *low*, which means unmap is processed at low rate. This property can be updated by calling *HostStorageSystem.UpdateVmfsUnmapPriority*.  | [optional] 
**UnmapBandwidthSpec** | [**VmfsUnmapBandwidthSpec**](VmfsUnmapBandwidthSpec.md) | VMFS unmap bandwidth related specification.  See *VmfsUnmapBandwidthSpec* for detail.  | [optional] 
**MaxBlocks** | **int** | Maximum number of blocks.  Determines maximum file size along with blockSize. See information about the blockSize.  | 
**MajorVersion** | **int** | Major version number of VMFS.  | 
**VarVersion** | **string** | Version string.  Contains major and minor version numbers.  | 
**Uuid** | **string** | The universally unique identifier assigned to VMFS.  | 
**Extent** | [**List&lt;HostScsiDiskPartition&gt;**](HostScsiDiskPartition.md) | The list of partition names that comprise this disk&#39;s VMFS extents.  This property can be accessed via various enclosing objects. In VirtualCenter, where it can be accessed from multiple hosts, the value of this property may differ according to the context in which it is accessed. When accessed from the *VmfsDatastoreInfo* object, in VirtualCenter, this property reflects the extent information of any one of the hosts visible to the datastore.  For a VirtualCenter system which manages ESX Server 2.x and ESX Server 3.x hosts, this extent information is only correlatable across hosts if the extents are exposed on the same adapter on all hosts which can access them. To find the extent names for a specific host, this same property should be accessed via the host&#39;s *HostFileSystemVolume* object, by correlating the uuid of the VMFS datastore in the VmfsDatastoreInfo object to the uuid in the FileSystemVolume object.  For a Virtual Center system which manages only ESX Server hosts with versions 4.0 onwards , this extent information is correlatable across hosts, irrespective of the adapters the extents are exposed on.  | 
**VmfsUpgradable** | **bool** | Can the filesystem be upgraded to a newer version.  See also *HostStorageSystem.UpgradeVmfs*.  | 
**ForceMountedInfo** | [**HostForceMountedInfo**](HostForceMountedInfo.md) | Information about &#39;forceMounted&#39; VmfsVolume.  When the system detects a copy of a VmfsVolume, it will not be auto-mounted on the host and it will be detected as &#39;UnresolvedVmfsVolume&#39;. If user decides to &#39;forceMount&#39; the VmfsVolume on the host, forceMountedInfo will be populated. It will not be set for automounted VMFS volumes.  | [optional] 
**Ssd** | **bool** | Indicates whether the volume is SSD backed.  If unset, the information whether the volume is SSD backed is unknown.  | [optional] 
**Local** | **bool** | Indicates whether the volume is backed by local disk.  If unset, the information of the volume is local-disk backed is unknown.  | [optional] 
**ScsiDiskType** | **string** | The type of disk drives.  See *ScsiDiskType_enum* for supported types. If unset, the default disk drive type is *native512*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

