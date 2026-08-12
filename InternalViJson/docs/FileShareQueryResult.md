# Vcenter.ViJson.OpenApi.Model.FileShareQueryResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileShares** | [**List&lt;VsanFileShare&gt;**](VsanFileShare.md) | A list of file shares that matches query criteria.  Note that the number of return value will be limited by offset or the limit in the query specification and the total number of remaining file shares.  | [optional] 
**NextOffset** | **string** | This field indicates the starting offset for the next query.  If there is no more share to be returned, this value is None. If there are more shares after this result to be returned, it should be passed to next query. For more explanation, see *VsanFileShareQuerySpec.offset*  | [optional] 
**TotalShareCount** | **long** | The number of file shares created in total.  This value could be used by client to decide if there is a need to make further calls for querying remaining file shares.  | [optional] 
**MaxShareCount** | **long** | This field indicates the maximum number of shares that can be configured in the cluster.  This field will only be set in a vSAN ESA cluster.  ***Since:*** 8.0.0.4  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

