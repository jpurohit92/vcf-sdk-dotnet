# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationVtContainersMappingsInfo
The Vcenter.Authorization.VtContainers.Mappings.Info schema contains all of the information about a containerized object mapping.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vtcontainer** | **string** | Identifier of the vTContainer instance.  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.VtContainer&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.VtContainer&#x60;. | 
**Object** | [**VapiStdDynamicID**](VapiStdDynamicID.md) | Identifier of the containerized object.  This property was added in __vSphere API 8.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

