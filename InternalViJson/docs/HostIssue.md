# Vcenter.ViJson.OpenApi.Model.HostIssue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | A unique identifier per &lt;code&gt;Issue&lt;/code&gt; instance.  | 
**Description** | **string** | A localized message describing the issue.  | 
**Time** | **DateTime** | The point in time when this issue was generated.  Note that issues can be regenerated periodically, so this time does not necessarily reflect the first time the issue was detected.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host to which the issue is related.  Refers instance of *HostSystem*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

