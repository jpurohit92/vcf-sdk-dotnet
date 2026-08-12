# Vcenter.ViJson.OpenApi.Model.ComputeDiskPartitionInfoRequestType
The parameters of *HostStorageSystem.ComputeDiskPartitionInfo*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DevicePath** | **string** | The name of the device path for the specific disk.  | 
**Layout** | [**HostDiskPartitionLayout**](HostDiskPartitionLayout.md) | A data object that describes the disk partition layout.  | 
**PartitionFormat** | **string** | Specifies the desired partition format to be computed from the block range. If partitionFormat is not specified, the existing partitionFormat on disk is used, if the disk is not blank and mbr otherwise.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

