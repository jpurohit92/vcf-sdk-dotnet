# Vcenter.ViJson.OpenApi.Model.VslmVsoVStorageObjectQueryResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllRecordsReturned** | **bool** | If set to false, more results were found than could be returned (either limited by maxResult input argument in the *VslmVStorageObjectManager.VslmListVStorageObjectForSpec* API or truncated because the number of results exceeded the internal limit).  | 
**Id** | [**List&lt;ID&gt;**](ID.md) | IDs of the VStorageObjects matching the query criteria NOTE: This field will be removed once the dev/qe code is refactored.  IDs will be returned in ascending order. If *VslmVsoVStorageObjectQueryResult.allRecordsReturned* is set to false, to get the additional results, repeat the query with ID &amp;gt; last ID as part of the query spec *VslmVsoVStorageObjectQuerySpec*.  | [optional] 
**QueryResults** | [**List&lt;VslmVsoVStorageObjectResult&gt;**](VslmVsoVStorageObjectResult.md) | Results of the query criteria.  *IDs* will be returned in ascending order. If *VslmVsoVStorageObjectQueryResult.allRecordsReturned* is set to false,then, to get the additional results, repeat the query with ID &amp;gt; last ID as part of the query spec *VslmVsoVStorageObjectQuerySpec*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

