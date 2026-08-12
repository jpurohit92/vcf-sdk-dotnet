# Vcenter.ViJson.OpenApi.Model.IndependentDiskVMotionNotSupported
An operation on a powered-on virtual machine requests that the virtual machine's disks be moved without choosing a new home datastore for the virtual machine, but the host does not have that capability. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AtSourceHost** | **bool** | Whether this error is for the source host.  | 
**FailedHostName** | **string** | The name of the host.  | 
**FailedHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host.  Refers instance of *HostSystem*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

