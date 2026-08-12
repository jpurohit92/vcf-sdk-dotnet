# Vcenter.ViJson.OpenApi.Model.ClusterEnterMaintenanceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Recommendations** | [**List&lt;ClusterRecommendation&gt;**](ClusterRecommendation.md) | The list of recommendations for hosts that Virtual Center will be able to evacuate.  Each recommendation consists of a host maintenance action *ClusterAction* for a host, along with zero or more vmotions for evacuation. Application of the recommendations is not supported currently. The client will have to put the hosts into maintenance mode by calling the separate method *HostSystem.EnterMaintenanceMode_Task*.  | [optional] 
**Fault** | [**ClusterDrsFaults**](ClusterDrsFaults.md) | The faults that explain why the Virtual Center cannot evacuate some hosts.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

