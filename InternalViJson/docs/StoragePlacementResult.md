# Vcenter.ViJson.OpenApi.Model.StoragePlacementResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Recommendations** | [**List&lt;ClusterRecommendation&gt;**](ClusterRecommendation.md) | The list of recommendations that the client needs to approve manually.  | [optional] 
**DrsFault** | [**ClusterDrsFaults**](ClusterDrsFaults.md) | Information about any fault in case Storage DRS failed to make a recommendation.  | [optional] 
**Task** | [**ManagedObjectReference**](ManagedObjectReference.md) | The ID of the task, which monitors the storage placement or datastore entering maintennace mode operation.  Refers instance of *Task*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

