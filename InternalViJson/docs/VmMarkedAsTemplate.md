# Vcenter.ViJson.OpenApi.Model.VmMarkedAsTemplate
Deprecated template agent VMs are not used anymore by VM deployment and monitoring.  An agent virtual machine is a virtual machine template.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager converts the agent virtual machine template to a virtual machine.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine to which this issue is related.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

