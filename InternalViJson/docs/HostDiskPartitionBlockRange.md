# Vcenter.ViJson.OpenApi.Model.HostDiskPartitionBlockRange

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Partition** | **int** | Partition number.  This number is a hint from the server indicating what the partition number for this block range is if the range corresponds to a partition. The partition number should correlate to the one in the partition specification. If sent back to the server, this property is ignored.  | [optional] 
**Type** | **string** | The type of data in the partition.  See also *HostDiskPartitionAttributes.type*.  | 
**Start** | [**HostDiskDimensionsLba**](HostDiskDimensionsLba.md) | The starting block address of the disk range.  The block numbers start from zero. The range is inclusive of the end address.  | 
**End** | [**HostDiskDimensionsLba**](HostDiskDimensionsLba.md) | The end block address of the disk range.  The block numbers start from zero. The range is inclusive of the end address.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

