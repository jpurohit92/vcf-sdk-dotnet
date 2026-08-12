# Vcenter.ViJson.OpenApi.Model.RetrieveResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Token** | **string** | A token used to retrieve further retrieve results.  If set, the token should be passed to *PropertyCollector.ContinueRetrievePropertiesEx* to retrieve more results. Each token may be passed to continueRetrievePropertiesEx only once, and only in the same session in which it was returned and to the same *PropertyCollector* object that returned it.  If unset, there are no further results to retrieve after this *RetrieveResult*.  | [optional] 
**Objects** | [**List&lt;ObjectContent&gt;**](ObjectContent.md) | retrieved objects.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

