# Vcenter.ViJson.OpenApi.Model.LifecycleWitnessDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The witness host.  Refers instance of *HostSystem*.  | 
**IsVirtualAppliance** | **bool** | Whether the witness host is a virtual appliance or a physical machine.  | 
**SharedClusters** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The list of clusters sharing the witness host.  A list with only one cluster means the witness host is not shared.  Refers instances of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

