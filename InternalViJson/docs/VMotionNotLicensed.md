# Vcenter.ViJson.OpenApi.Model.VMotionNotLicensed
VMotion is not licensed on a source or destination host.  It must be licensed on both hosts. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AtSourceHost** | **bool** | Whether this error is for the source host.  | 
**FailedHost** | **string** | The name of the host with the bad interface.  | 
**FailedHostEntity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host with the bad interface.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

