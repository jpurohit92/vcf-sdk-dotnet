# Vcenter.ViJson.OpenApi.Model.RecoveredDiskInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceKey** | **int** | Virtual disk key.  Note that disk device keys must not change after recovery - in other words, the device key is the same on both the source and target sites.  For example, if a VMDK d1 is being replicated to d1&#39;, and d1 is attached as device 2001 to the source VM, the recovered VM should have d1&#39; attached as 2001.  | 
**DsUrl** | **string** | URL of the datastore that disk was recovered to.  | 
**DiskPath** | **string** | Full pathname of the disk.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

