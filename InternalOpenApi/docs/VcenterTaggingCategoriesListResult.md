# Vcenter.Automation.OpenApi.Model.VcenterTaggingCategoriesListResult
The Vcenter.Tagging.Categories.ListResult schema contains a set of categories and the metadata about them.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Marker** | **string** | Marker is an opaque data structure that allows the caller to request the next page of categories.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, then all the categories have been returned. | [optional] 
**Items** | [**List&lt;VcenterTaggingCategoriesListItem&gt;**](VcenterTaggingCategoriesListItem.md) | List of categories.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

