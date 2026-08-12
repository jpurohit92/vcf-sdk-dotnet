# Vcenter.ViJson.OpenApi.Model.VirtualMachineUsageOnDatastore

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to datastore for which information is being provided.  Refers instance of *Datastore*.  | 
**Committed** | **long** | Storage space, in bytes, on this datastore that is actually being used by the virtual machine.  It includes space actually occupied by disks, logs, snapshots, configuration files etc. Files of the virtual machine which are present on a different datastore (e.g. a virtual disk on another datastore) are not included here. *VirtualMachineFileLayoutEx* provides a detailed break-up of the committed space.  | 
**Uncommitted** | **long** | Additional storage space, in bytes, potentially used by the virtual machine on this datastore.  Additional space may be needed for example when lazily allocated disks grow, or storage for swap is allocated when powering on the virtual machine.  If the virtual machine is running off delta disks (for example because a snapshot was taken), then only the potential growth of the currently used delta-disks is considered.  | 
**Unshared** | **long** | Storage space, in bytes, occupied by the virtual machine on this datastore that is not shared with any other virtual machine.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

