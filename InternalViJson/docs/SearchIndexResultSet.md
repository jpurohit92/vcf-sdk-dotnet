# Vcenter.ViJson.OpenApi.Model.SearchIndexResultSet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Properties** | **List&lt;string&gt;** | The names of the resource model properties returned for each resource item in the result set.  The position (index) of each model property in this list corresponds to the position of the model property value in each resource item&#39;s values list. In other words, the name of each model property in the *SearchIndexResourceItem.propertyValues* list is given by the string with the same index (position) in this list.  | [optional] 
**Items** | [**List&lt;SearchIndexResourceItem&gt;**](SearchIndexResourceItem.md) | The list of result items.  Each item corresponds to a particular resource that matched the conditions in the specified *SearchIndexQuerySpec* instance and containing the property data retrieved for that resource.  | [optional] 
**TotalCount** | **int** | The total number of resources that matched the query, regardless of the actual number that is returned in *SearchIndexResultSet.items*.  This value is set only if it has been explicitly requested in the query, i.e. if the *SearchIndexQuerySpec.returnTotalCount* flag has been set to &#x60;true&#x60;. The &#x60;totalCount&#x60; can change as new records are added or removed between requests. This means the count is recalculated on each subsequent request to reflect the most up-to-date results. The usecase of this property is for requesting only the items matching certain query without any further properties for the resource model. For example: find the number of all vms that are powered on.  | [optional] 
**Marker** | **string** | Used for continuation of result paging.  If paging used this one will be filled with the place where the next page should continue from. It should be passed to *SearchIndexIterationSpec.marker*, so the paging can be continued.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

