# Vcenter.ViJson.OpenApi.Model.VmOrphaned
An agent virtual machine exists on a host, but the host is no longer part of scope for the agency.  This typically happens if a host is disconnected when the agency configuration is changed.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager deletes the agent virtual machine.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine to which this issue is related.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

