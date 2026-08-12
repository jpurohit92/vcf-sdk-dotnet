# Vcenter.ViJson.OpenApi.Model.ClusterPowerOnVmResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attempted** | [**List&lt;ClusterAttemptedVmInfo&gt;**](ClusterAttemptedVmInfo.md) | The list of virtual machines the Virtual Center has attempted to power on.  For a virtual machine not managed by DRS, a task ID is also returned.  | [optional] 
**NotAttempted** | [**List&lt;ClusterNotAttemptedVmInfo&gt;**](ClusterNotAttemptedVmInfo.md) | The list of virtual machines DRS can not find suitable hosts for powering on.  There is one fault associated with each virtual machine.  | [optional] 
**Recommendations** | [**List&lt;ClusterRecommendation&gt;**](ClusterRecommendation.md) | The list of recommendations that need the client to approve manually.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

