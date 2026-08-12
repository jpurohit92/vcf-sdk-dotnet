# Vcenter.ViJson.OpenApi.Model.VsanClusterProactiveTestResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverallStatus** | **string** | The overall proactive test result status enumeration.  The all possible values are &#39;green&#39;, &#39;yellow&#39;, &#39;red&#39;, &#39;unknown&#39;, or &#39;info&#39;.  | 
**OverallStatusDescription** | **string** | A human readable, short description of the overall status result to let user know the potential problem in the first glance.  | 
**Timestamp** | **DateTime** | The time when the test was performed.  | 
**HealthTest** | [**VsanClusterHealthTest**](VsanClusterHealthTest.md) | It&#39;s the data driven structure to display the health test result for purpose of rendering a UI.  The structure has a description, health status, and optionally one or more \&quot;details\&quot; tables to display additional information about the test. Programmatic consumption of the health findings should avoid parsing this structure because it is meant for UI consumption and the content will change to improve user experience.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

