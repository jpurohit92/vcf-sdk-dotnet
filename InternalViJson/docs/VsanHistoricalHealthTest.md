# Vcenter.ViJson.OpenApi.Model.VsanHistoricalHealthTest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTime** | The timestamp.  | 
**Health** | **string** | The health result enumeration.  The possible values are &#39;green&#39;, &#39;yellow&#39;, &#39;red&#39;, &#39;unknown&#39;, or &#39;info&#39;.  | 
**TestDetails** | [**List&lt;VsanClusterHealthResultBase&gt;**](VsanClusterHealthResultBase.md) | The health check detail tables.  | [optional] 
**TestCorrelation** | [**VsanHealthCorrelation**](VsanHealthCorrelation.md) | The health correlation for the current health test.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

