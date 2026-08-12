# Vcenter.ViJson.OpenApi.Model.ClusterAgentVmHookTimedout
The VM hook remediation timed out.  In order to remediate the issue: Resolve the issue via apply API and process the hook within the timeout configured for the System VM Solution this issue's VM belongs to.  This structure may be used only with operations rendered under `/eam`.  ***Since:*** vEAM API 9.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Virtual Machine to which this issue is related.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

