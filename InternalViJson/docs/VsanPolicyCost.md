# Vcenter.ViJson.OpenApi.Model.VsanPolicyCost

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeDataSize** | **long** | Change (in bytes) of size of data stored on the datastore.  This is the max of reserved and used capacity.  | [optional] 
**CurrentDataSize** | **long** | Size (in bytes) of data currently stored on the datastore.  This is the max of reserved and used capacity.  | [optional] 
**TempDataSize** | **long** | Size (in bytes) for temporary data that will be needed on disk if new policy is applied.  | [optional] 
**CopyDataSize** | **long** | Size (in bytes) of data we need to write to VSAN Datastore if new policy is applied.  | [optional] 
**ChangeFlashReadCacheSize** | **long** | Change (in bytes) of flash space reserved for read cache if new policy is applied.  | [optional] 
**CurrentFlashReadCacheSize** | **long** | Size (in bytes) of flash space currently reserved for read cache.  | [optional] 
**CurrentDiskSpaceToAddressSpaceRatio** | **float** | Current ratio of physical disk space of an object to the logical VSAN address space.  For eg. an object of size 1GB with two copies of the data has two 1GB replicas and so this ratio is 2.  | [optional] 
**DiskSpaceToAddressSpaceRatio** | **float** | Ratio of physical disk space of an object to the logical VSAN address space after new policy is applied.  For eg. an object of size 1GB with two copies of the data has two 1GB replicas and so this ratio is 2.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

