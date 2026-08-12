# Vcenter.Automation.OpenApi.Model.VcenterTaggingAssociationsListResult
The Vcenter.Tagging.Associations.ListResult schema contains the list of tag associations in a page, as well as related metadata fields.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Associations** | [**List&lt;VcenterTaggingAssociationsSummary&gt;**](VcenterTaggingAssociationsSummary.md) | List of tag associations.  This property was added in __vSphere API 7.0.0.0__. | 
**Marker** | **string** | Marker is an opaque data structure that allows the caller to request the next page of tag associations.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; or empty, there are no more tag associations to request.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.tagging.associations.Marker&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.tagging.associations.Marker&#x60;. | [optional] 
**Status** | **string** | The last status for the iterator that indicates whether any more results can be expected if the caller continues to make requests for more data using the iterator.  Possible values:   - &#x60;READY&#x60;: Iterator has more data pending and is ready to provide it. The caller can request the next page of data at any time.    The number of results returned may be less than the usual size. In other words, the iterator may not fill the page. The iterator has returned at least 1 result.   - &#x60;END_OF_DATA&#x60;: Iterator has finished iterating through its inventory. There are currently no more entities to return and the caller can terminate iteration. If the iterator returned some data, the marker may be set to allow the iterator to continue from where it left off when additional data does become available. This value is used to indicate that all available data has been returned by the iterator.   For more information see: *Vcenter.Tagging.Associations.LastIterationStatus*.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

