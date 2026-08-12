# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationVtContainersMappingsIterationSpec
The Vcenter.Authorization.VtContainers.Mappings.IterationSpec schema contains properties used to limit the number of items returned from the *GET /vcenter/authorization/vt-containers/mappings* operation.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Marker** | **string** | An opaque string in support of pagination which may be specified to retrieve the next set of items. The marker is obtained from the *Vcenter.Authorization.VtContainers.Mappings.ListResult* schema that is returned by the *GET /vcenter/authorization/vt-containers/mappings* operation.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; the first set of items is returned. | [optional] 
**Size** | **long** | Maximum number of items to return in a single call.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; defaults to a size defined by the service. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

