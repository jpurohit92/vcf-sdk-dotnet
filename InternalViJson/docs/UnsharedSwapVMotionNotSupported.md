# Vcenter.ViJson.OpenApi.Model.UnsharedSwapVMotionNotSupported
The compute resource and virtual machine configurations for swapfile placement would require the virtual machine swapfile to change location for this VMotion; however the host does not support this. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AtSourceHost** | **bool** | Whether this error is for the source host.  | 
**FailedHostName** | **string** | The name of the host.  | 
**FailedHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host.  Refers instance of *HostSystem*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

