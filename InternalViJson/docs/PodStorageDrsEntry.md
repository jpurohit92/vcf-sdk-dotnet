# Vcenter.ViJson.OpenApi.Model.PodStorageDrsEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StorageDrsConfig** | [**StorageDrsConfigInfo**](StorageDrsConfigInfo.md) | Storage DRS configuration.  | 
**Recommendation** | [**List&lt;ClusterRecommendation&gt;**](ClusterRecommendation.md) | List of recommended actions for the Storage Pod.  It is possible that the current set of recommendations may be empty, either due to not having any running dynamic recommendation generation module, or since there may be no recommended actions at this time.  | [optional] 
**DrsFault** | [**List&lt;ClusterDrsFaults&gt;**](ClusterDrsFaults.md) | A collection of the DRS faults generated in the last Storage DRS invocation.  Each element of the collection is the set of faults generated in one recommendation.  | [optional] 
**ActionHistory** | [**List&lt;ClusterActionHistory&gt;**](ClusterActionHistory.md) | The set of actions that have been performed recently.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

