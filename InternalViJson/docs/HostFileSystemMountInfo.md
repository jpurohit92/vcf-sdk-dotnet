# Vcenter.ViJson.OpenApi.Model.HostFileSystemMountInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MountInfo** | [**HostMountInfo**](HostMountInfo.md) | Information about the mount point.  | 
**Volume** | [**HostFileSystemVolume**](HostFileSystemVolume.md) | Information about the mounted volume.  | 
**VStorageSupport** | **string** | vStorage hardware acceleration support status.  This property represents the volume&#39;s capability for storage acceleration. See *FileSystemMountInfoVStorageSupportStatus_enum* for valid values.  If the ESX Server supports hardware acceleration, the Server can offload specific virtual machine management operations to a storage device with the hardware acceleration feature. With hardware assistance, the host performs storage operations faster and consumes less CPU, memory, and storage fabric bandwidth.  For vSphere 4.0 or earlier hosts, this value will be unset.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

