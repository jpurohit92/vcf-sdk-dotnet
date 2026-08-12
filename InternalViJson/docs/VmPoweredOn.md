# Vcenter.ViJson.OpenApi.Model.VmPoweredOn
An agent virtual machine is expected to be powered off, but the agent virtual machine is powered on.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager powers off the agent virtual machine.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine to which this issue is related.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

