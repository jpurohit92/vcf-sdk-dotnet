# Vcenter.ViJson.OpenApi.Model.FolderBatchAddHostsToClusterResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostsAddedToCluster** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of hosts that were successfully added to the cluster in the desired state.  Refers instances of *HostSystem*.  | [optional] 
**HostsFailedInventoryAdd** | [**List&lt;FolderFailedHostResult&gt;**](FolderFailedHostResult.md) | Contains a fault for each host that failed addition to the inventory.  A failed host will not be part of hostsAddedToCluster list.  | [optional] 
**HostsFailedMoveToCluster** | [**List&lt;FolderFailedHostResult&gt;**](FolderFailedHostResult.md) | List of hosts that are part of inventory but failed to move to the cluster in the desired state.  A failed host will not be part of hostsAddedToCluster list however, a failed host will be part of inventory as it might have been added as a standalone host but failed to move to cluster in the desired state.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

