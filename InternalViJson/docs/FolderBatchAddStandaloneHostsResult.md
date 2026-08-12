# Vcenter.ViJson.OpenApi.Model.FolderBatchAddStandaloneHostsResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddedHosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of hosts that were successfully added as standalone hosts to the inventory.  Refers instances of *HostSystem*.  | [optional] 
**HostsFailedInventoryAdd** | [**List&lt;FolderFailedHostResult&gt;**](FolderFailedHostResult.md) | Contains a fault for each host that failed to add.  A failed host will not be part of addedHosts list.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

