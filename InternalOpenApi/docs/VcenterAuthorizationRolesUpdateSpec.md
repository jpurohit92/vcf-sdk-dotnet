# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationRolesUpdateSpec
The Vcenter.Authorization.Roles.UpdateSpec schema contains detailed information about the update of a specific role.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the role.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**Description** | **string** | A brief summary what this role is dedicated for.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**Privileges** | **List&lt;string&gt;** | The set of *Vcenter.Authorization.Privileges* which are part of this role.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the value is unchanged.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.authorization.Privilege&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.authorization.Privilege&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

