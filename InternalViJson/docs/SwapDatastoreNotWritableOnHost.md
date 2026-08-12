# Vcenter.ViJson.OpenApi.Model.SwapDatastoreNotWritableOnHost
The compute resource and/or virtual machine configurations indicate that when executing on the host the virtual machine should use a specific datastore, but host does not have read/write access to that datastore.  (It may have no access at all, or read-only access.) If executing on the host the virtual machine would instead use its own directory for swapfile placement. This is a compatibility warning, not an error. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host on which the datastore is not writable.  Refers instance of *HostSystem*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

