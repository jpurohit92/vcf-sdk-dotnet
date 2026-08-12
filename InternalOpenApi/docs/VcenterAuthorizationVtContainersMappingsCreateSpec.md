# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationVtContainersMappingsCreateSpec
The Vcenter.Authorization.VtContainers.Mappings.CreateSpec schema contains the information necessary for associating an object with a vTContainer instance.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vtcontainer** | **string** | Identifier of the vTContainer instance.  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.VtContainer&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.VtContainer&#x60;. | 
**Object** | [**VapiStdDynamicID**](VapiStdDynamicID.md) | Identifier of the object that will be containerized.  This property was added in __vSphere API 8.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

