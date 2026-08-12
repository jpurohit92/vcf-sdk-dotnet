# Vcenter.ViJson.OpenApi.Model.ClusterAgentVmNotRemoved
The cluster agent Virtual Machine can not be removed from a cluster.  Typically the description indicates the particular reason why vSphere ESX Agent Manager was unable to remove the cluster agent Virtual Machine.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager removes the cluster agent Virtual Machine.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Virtual Machine to which this issue is related.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

