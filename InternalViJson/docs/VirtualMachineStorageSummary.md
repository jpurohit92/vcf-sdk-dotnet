# Vcenter.ViJson.OpenApi.Model.VirtualMachineStorageSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Committed** | **long** | Total storage space, in bytes, committed to this virtual machine across all datastores.  Essentially an aggregate of the property *VirtualMachineUsageOnDatastore.committed* across all datastores that this virtual machine is located on.  | 
**Uncommitted** | **long** | Additional storage space, in bytes, potentially used by this virtual machine on all datastores.  Essentially an aggregate of the property *VirtualMachineUsageOnDatastore.uncommitted* across all datastores that this virtual machine is located on.  | 
**Unshared** | **long** | Total storage space, in bytes, occupied by the virtual machine across all datastores, that is not shared with any other virtual machine.  | 
**Timestamp** | **DateTime** | Time when values in this structure were last updated.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

