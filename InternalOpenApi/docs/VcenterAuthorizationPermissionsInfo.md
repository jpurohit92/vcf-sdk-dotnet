# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPermissionsInfo
The Vcenter.Authorization.Permissions.Info schema contains detailed information about a specific authorization permission.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | [**VapiStdDynamicID**](VapiStdDynamicID.md) | The object that this permission is assigned on.  This property was added in __vSphere API 9.0.0.0__. | 
**Principal** | [**VcenterAuthorizationPermissionsPrincipal**](VcenterAuthorizationPermissionsPrincipal.md) | The principal that this permission is assigned for.  This property was added in __vSphere API 9.0.0.0__. | 
**Role** | **string** | The role which this permission grants.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.Role&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.authorization.Role&#x60;. | 
**Propagating** | **bool** | Indicator whether the permission apply only on the object which it is assigned on or it propagates through the hierarchy of sub-entities.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

