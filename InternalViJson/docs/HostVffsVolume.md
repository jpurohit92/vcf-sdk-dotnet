# Vcenter.ViJson.OpenApi.Model.HostVffsVolume

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | FileSystemType of this particular file system See *HostFileSystemVolumeFileSystemType_enum*  | 
**Name** | **string** | Name of the file system volume.  | 
**Capacity** | **long** | The capacity of the file system volume, in bytes.  | 
**MajorVersion** | **int** | Major version number of VFFS.  | 
**VarVersion** | **string** | Version string.  Contains major and minor version numbers.  | 
**Uuid** | **string** | The universally unique identifier assigned to VFFS.  | 
**Extent** | [**List&lt;HostScsiDiskPartition&gt;**](HostScsiDiskPartition.md) | The list of partition names that comprise this disk&#39;s VFFS extents.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

