# Vcenter.ViJson.OpenApi.Model.SolutionsHookConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the configured hook, possible values - *HooksHookType_enum*.  | 
**Acknowledgement** | [**SolutionsHookAcknowledgeConfig**](SolutionsHookAcknowledgeConfig.md) | Type of acknowledgement of the configured hook.  | 
**Timeout** | **long** | The maximum time in seconds to wait for a hook to be processed.  An issue is raised if the time elapsed and the hook is still not processed. If omitted - defaults to 10 hours.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

