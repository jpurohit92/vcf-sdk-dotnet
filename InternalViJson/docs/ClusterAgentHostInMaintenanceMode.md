# Vcenter.ViJson.OpenApi.Model.ClusterAgentHostInMaintenanceMode
An agent virtual machine operation cannot be executed on host, because the host is in maintenance mode that blocks the virtual machine operation.  This is not a remediable issue. To remediate, take the host ouf of maintenance mode.  This structure may be used only with operations rendered under `/eam`.  ***Since:*** vEAM API 8.3 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Virtual Machine to which this issue is related.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

