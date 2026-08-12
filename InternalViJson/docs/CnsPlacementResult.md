# Vcenter.ViJson.OpenApi.Model.CnsPlacementResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | Placement result for the datastore.  Refers instance of *Datastore*.  | 
**PlacementFaults** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Placement faults if any for the datastore.  This field will be set with appropriate *CnsPlacementFault* only.    The selected datastore will not have any fault set.  | [optional] 
**Clusters** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Clusters where the datastore is mounted on all the hosts.  This field is populated only when the datastore is selected based on policy and active clusters.  Refers instances of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

