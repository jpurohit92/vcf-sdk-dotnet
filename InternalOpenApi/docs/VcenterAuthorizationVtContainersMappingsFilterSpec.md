# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationVtContainersMappingsFilterSpec
The Vcenter.Authorization.VtContainers.Mappings.FilterSpec schema contains properties used to filter the items returned from a *GET /vcenter/authorization/vt-containers/mappings* operation.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vtcontainers** | **List&lt;string&gt;** | A set of vTContainers.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; or empty, the result will not be filtered by vTContainer instance.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.authorization.VtContainer&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.authorization.VtContainer&#x60;. | [optional] 
**Types** | **List&lt;string&gt;** | A set of object resource types.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; or empty, the result will not be filtered by object resource type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

