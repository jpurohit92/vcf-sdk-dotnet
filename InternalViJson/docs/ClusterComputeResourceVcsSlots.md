# Vcenter.ViJson.OpenApi.Model.ClusterComputeResourceVcsSlots

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SystemId** | **string** | Identifier of the system for which the slots are applicable.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host that has vSphere Cluster Services slots.  Refers instance of *HostSystem*.  | 
**Datastore** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Datastores on the host which are recommended for vCLS VM deployment.  ***Since:*** vSphere API Release 7.0.3.0  Refers instances of *Datastore*.  | [optional] 
**TotalSlots** | **int** | The number of total vSphere Cluster Services slots on the host.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

