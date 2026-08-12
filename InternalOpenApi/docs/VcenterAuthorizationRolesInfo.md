# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationRolesInfo
The Vcenter.Authorization.Roles.Info schema contains detailed information about a specific role.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the role.  This property was added in __vSphere API 9.0.0.0__. | 
**Description** | **string** | A brief summary what this role is dedicated for.  This property was added in __vSphere API 9.0.0.0__. | 
**Privileges** | **List&lt;string&gt;** | The set of *Vcenter.Authorization.Privileges* which are part of this role.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.authorization.Privilege&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.authorization.Privilege&#x60;. | 
**System** | **bool** | Indicator if role is created as system built-in role.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

