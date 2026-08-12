# Vcenter.ViJson.OpenApi.Model.ComputeDiskPartitionInfoForResizeRequestType
The parameters of *HostStorageSystem.ComputeDiskPartitionInfoForResize*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Partition** | [**HostScsiDiskPartition**](HostScsiDiskPartition.md) | The disk partition to resize.  | 
**BlockRange** | [**HostDiskPartitionBlockRange**](HostDiskPartitionBlockRange.md) | Specifies the desired block range for the resized partition. The start of the block range specified should match that of the current partition.  | 
**PartitionFormat** | **string** | Specifies the desired partition format to be computed from the block range. If partitionFormat is not specified, the existing partitionFormat on disk is used, if the disk is not blank and mbr otherwise.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

