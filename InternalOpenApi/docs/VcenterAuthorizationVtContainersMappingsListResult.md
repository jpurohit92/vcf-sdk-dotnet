# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationVtContainersMappingsListResult
The Vcenter.Authorization.VtContainers.Mappings.ListResult schema represents the result of the *GET /vcenter/authorization/vt-containers/mappings* operation.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;VcenterAuthorizationVtContainersMappingsListItem&gt;**](VcenterAuthorizationVtContainersMappingsListItem.md) | List of vTContainer mappings.  This property was added in __vSphere API 8.0.3.0__. | 
**Marker** | **string** | An opaque string in support of pagination which indicates that more items are available. The marker can be used in subsequent calls to the *GET /vcenter/authorization/vt-containers/mappings* operation to retrieve the next set of items.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; there are no additional items. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

