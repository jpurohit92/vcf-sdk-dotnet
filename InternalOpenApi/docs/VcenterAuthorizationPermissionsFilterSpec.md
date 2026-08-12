# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPermissionsFilterSpec
The Vcenter.Authorization.Permissions.FilterSpec schema contains properties based on which authorization permissions can be filtered. Any permission matching all of the conditions is returned.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Objects** | [**List&lt;VapiStdDynamicID&gt;**](VapiStdDynamicID.md) | Objects which permissions are assigned on.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; all permissions match. | [optional] 
**Principals** | [**List&lt;VcenterAuthorizationPermissionsPrincipal&gt;**](VcenterAuthorizationPermissionsPrincipal.md) | Principals who permissions are assigned for.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; all permissions match. | [optional] 
**Roles** | **List&lt;string&gt;** | The roles granted by the permissions.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; all permissions match.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.authorization.Role&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.authorization.Role&#x60;. | [optional] 
**IsPropagating** | **bool** | Whether the permission is propagating.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; all permissions match. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

