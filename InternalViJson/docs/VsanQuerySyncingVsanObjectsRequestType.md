# Vcenter.ViJson.OpenApi.Model.VsanQuerySyncingVsanObjectsRequestType
The parameters of *VsanSystemEx.VsanQuerySyncingVsanObjects*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuids** | **List&lt;string&gt;** | Restricts the list of object identities to query.  | [optional] 
**Start** | **int** | Indicates the number of objects to be skipped when returns query results. A value less than 0 is illegal. Default: 0.  | [optional] 
**Limit** | **int** | Restricts the max number of objects to return. Valid value is from 0 to 200. A value less than 0 is illegal, 0 is valid only when \&quot;includeSummary\&quot; is true. Default: 100.  | [optional] 
**IncludeSummary** | **bool** | Indicates whether to return summary data in query result. Default: True.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

