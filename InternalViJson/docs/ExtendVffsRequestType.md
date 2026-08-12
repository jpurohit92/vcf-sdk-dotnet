# Vcenter.ViJson.OpenApi.Model.ExtendVffsRequestType
The parameters of *HostStorageSystem.ExtendVffs*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VffsPath** | **string** | The path of the VFFS to extend. See *FileSystemMountInfo*.  | 
**DevicePath** | **string** | Device path of the SSD disk.  | 
**Spec** | [**HostDiskPartitionSpec**](HostDiskPartitionSpec.md) | A data object that describes the SSD disk partition information. If this property is not provided, partition information will be computed and generated.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

