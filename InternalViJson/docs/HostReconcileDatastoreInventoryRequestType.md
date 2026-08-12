# Vcenter.ViJson.OpenApi.Model.HostReconcileDatastoreInventoryRequestType
The parameters of *HostVStorageObjectManager.HostReconcileDatastoreInventory_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore that needs to be reconciled.  Refers instance of *Datastore*.  | 
**DeepCleansing** | **bool** | If set true, the reconcile task will check for the extent files and the disk descriptor file content as part of reconciliation. Note that this is a time consuming process.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

