# Vcenter.ViJson.OpenApi.Model.VsanWhatifCapacity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalWhatifCapacityB** | **long** | The total size of data in byte that a vSAN cluster can accommodate if all objects are stored with the specified storage policy.  | 
**FreeWhatifCapacityB** | **long** | The total size of data in byte that the remaining free space of a vSAN cluster can accommodate if all objects are stored with the specified storage policy.  | 
**StoragePolicy** | [**VirtualMachineProfileSpec**](VirtualMachineProfileSpec.md) | The string of the specified storage policy  | 
**IsSatisfiable** | **bool** | Describe if the vSAN datastore can satisfy the required FTT in the specified storage policy.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

