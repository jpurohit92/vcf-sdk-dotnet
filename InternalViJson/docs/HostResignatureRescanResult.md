# Vcenter.ViJson.OpenApi.Model.HostResignatureRescanResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rescan** | [**List&lt;HostVmfsRescanResult&gt;**](HostVmfsRescanResult.md) | Deprecated as of vSphere API 5.1, the results of the operation are available when the task completes. That is, for shared volumes, the new volume is mounted on all of the connected hosts.  List of VMFS Rescan operation results.  | [optional] 
**Result** | [**ManagedObjectReference**](ManagedObjectReference.md) | When an UnresolvedVmfsVolume has been resignatured, we want to return the newly created VMFS Datastore.  Refers instance of *Datastore*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

