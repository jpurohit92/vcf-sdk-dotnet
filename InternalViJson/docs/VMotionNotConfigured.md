# Vcenter.ViJson.OpenApi.Model.VMotionNotConfigured
A VMotion interface is not configured (or is misconfigured) on either the source or destination host.  This is an error only when migrating a powered-on virtual machine. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AtSourceHost** | **bool** | Whether this error is for the source host.  | 
**FailedHost** | **string** | The name of the host with the bad interface.  | 
**FailedHostEntity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host with the bad interface.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

