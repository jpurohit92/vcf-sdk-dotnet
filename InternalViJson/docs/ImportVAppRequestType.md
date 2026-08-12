# Vcenter.ViJson.OpenApi.Model.ImportVAppRequestType
The parameters of *ResourcePool.ImportVApp*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Spec** | [**ImportSpec**](ImportSpec.md) | An *ImportSpec* describing what to import.  | 
**Folder** | [**ManagedObjectReference**](ManagedObjectReference.md) | The folder to which the entity will be attached.  ***Required privileges:*** VApp.Import  Refers instance of *Folder*.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host on which the entity will run. This must specify a host that is a member of the ComputeResource indirectly specified by the pool. For a stand-alone host or a cluster with DRS, host can be omitted, and the system selects a default.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

