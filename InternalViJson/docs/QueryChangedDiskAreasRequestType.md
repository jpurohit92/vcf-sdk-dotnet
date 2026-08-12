# Vcenter.ViJson.OpenApi.Model.QueryChangedDiskAreasRequestType
The parameters of *VirtualMachine.QueryChangedDiskAreas*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Snapshot** | [**ManagedObjectReference**](ManagedObjectReference.md) | Snapshot for which changes that have been made sine \&quot;changeId\&quot; should be computed. If not set, changes are computed against the \&quot;current\&quot; snapshot of the virtual machine. However, using the \&quot;current\&quot; snapshot will only work for virtual machines that are powered off.  Refers instance of *VirtualMachineSnapshot*.  | [optional] 
**DeviceKey** | **int** | Identifies the virtual disk for which to compute changes.  | 
**StartOffset** | **long** | Start Offset in bytes at which to start computing changes. Typically, callers will make multiple calls to this function, starting with startOffset 0 and then examine the \&quot;length\&quot; property in the returned DiskChangeInfo structure, repeatedly calling queryChangedDiskAreas until a map for the entire virtual disk has been obtained.  | 
**ChangeId** | **string** | Identifier referring to a point in the past that should be used as the point in time at which to begin including changes to the disk in the result. A typical use case would be a backup application obtaining a changeId from a virtual disk&#39;s backing info when performing a backup. When a subsequent incremental backup is to be performed, this change Id can be used to obtain a list of changed areas on disk.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

