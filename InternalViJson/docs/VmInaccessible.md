# Vcenter.ViJson.OpenApi.Model.VmInaccessible
The connection state of the agent Virtual Machine is *inaccessible*.  In order to remediate the issue: - Mark the VM for removal using the *EsxAgentManager.EsxAgentManager_MarkForRemoval*   API. - Do the necessary changes to ensure that the connection state of the VM is   *connected*.    NOTE: When the HA is enabled on the cluster these issues may be transient and automatically remediated.  This structure may be used only with operations rendered under `/eam`.  ***Since:*** vEAM API 8.3 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine to which this issue is related.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

