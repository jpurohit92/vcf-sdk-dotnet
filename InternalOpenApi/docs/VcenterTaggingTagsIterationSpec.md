# Vcenter.Automation.OpenApi.Model.VcenterTaggingTagsIterationSpec
The Vcenter.Tagging.Tags.IterationSpec schema contains properties used to break results into pages when listing tags.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Marker** | **string** | Marker is an opaque data structure that allows the caller to request the next page of tags.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the first page of tags will be returned. | [optional] 
**PageSize** | **long** | Used for pagination to fetch given page size  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60;, then tags will be fetched with default page size of 20. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

