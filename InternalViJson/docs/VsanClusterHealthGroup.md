# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthGroup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **string** | The health check group ID.  It&#39;s the identifier for a group of the vSAN health check result and will keep stable for future releases  | 
**GroupName** | **string** | The health check group name.  It will be used as UI label to show the name of the grouped health check result  | 
**GroupHealth** | **string** | The group health status aggregating from each of health check item.  All of possible health status ordering in severity level are \&quot;red, yellow, info, unknown, green\&quot;. The aggregated group health status will be the most severe status in each of sub health check item  | 
**GroupTests** | [**List&lt;VsanClusterHealthTest&gt;**](VsanClusterHealthTest.md) | The health check results for each of check item in the group  | [optional] 
**GroupDetails** | [**List&lt;VsanClusterHealthResultBase&gt;**](VsanClusterHealthResultBase.md) |  | [optional] 
**InProgress** | **bool** | True indicates health check of this group is still in progress.  It could return True for some health check groups if you are trying to get health summary via API *VsanVcClusterHealthSystem.VsanQueryVcClusterHealthSummary*. The health check result under this group will not be available until the flag is false.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

