# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationVtContainersMappingsListItem
The Vcenter.Authorization.VtContainers.Mappings.ListItem schema contains all of the information about a containerized object mapping returned by the *GET /vcenter/authorization/vt-containers/mappings* operation.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mapping** | **string** | Identifier of the vTContainer mapping.  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.vt_containers.Mapping&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.vt_containers.Mapping&#x60;. | 
**Info** | [**VcenterAuthorizationVtContainersMappingsInfo**](VcenterAuthorizationVtContainersMappingsInfo.md) | Information about the vTContainer mapping.  This property was added in __vSphere API 8.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

