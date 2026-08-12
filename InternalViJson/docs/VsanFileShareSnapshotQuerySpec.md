# Vcenter.ViJson.OpenApi.Model.VsanFileShareSnapshotQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareUuid** | **string** | UUID of the file share which the snapshots belong to.  | 
**SnapshotNames** | **List&lt;string&gt;** | A list of the snapshots to be queried.  | [optional] 
**StartTime** | **DateTime** | To query the snapshots created after the given time.  | [optional] 
**EndTime** | **DateTime** | To query the snapshots created before the given time.  | [optional] 
**PageSize** | **int** | This field sets the maximum number of snapshots to be returned per page.  The default and the maximum value for pageSize is 32. If pageSize is larger than 32 or is non-positive, an InvalidArgument exception will be thrown.  | [optional] 
**PageNumber** | **int** | This field is used to query the snapshots on a specified page.  The default value for pageNumber is 1. If pageNumber is non-positive or exceeds the maximum number of pages to be returned, an InvalidArgument exception will be thrown.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

