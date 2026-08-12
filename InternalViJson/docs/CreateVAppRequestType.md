# Vcenter.ViJson.OpenApi.Model.CreateVAppRequestType
The parameters of *ResourcePool.CreateVApp*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the vApp container in the inventory  | 
**ResSpec** | [**ResourceConfigSpec**](ResourceConfigSpec.md) | The resource configuration for the vApp container (same as for a regular resource pool).  | 
**ConfigSpec** | [**VAppConfigSpec**](VAppConfigSpec.md) | The specification of the vApp specific meta-data.  | 
**VmFolder** | [**ManagedObjectReference**](ManagedObjectReference.md) | The parent folder for the vApp. This must be null if this is a child vApp.  Refers instance of *Folder*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

