# Vcenter.ViJson.OpenApi.Model.VmHookFailed
The VM hook remediation failed.  In order to remediate the issue: Resolve the issue via vLCM System VMs API and process the hook within the timeout configured for the System VM Solution this issue's VM belongs to.  This structure may be used only with operations rendered under `/eam`.  ***Since:*** vEAM API 9.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine to which this issue is related.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

