# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPermissionsPrincipal
The Vcenter.Authorization.Permissions.Principal schema contains the name, the domain and whether it is a user or group.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the principal.  Possible values:   - &#x60;USER&#x60;: The principal is a user.   - &#x60;GROUP&#x60;: The principal is a group.   For more information see: *Vcenter.Authorization.Permissions.Principal.Type*.  This property was added in __vSphere API 9.0.0.0__. | 
**Name** | **string** | The name of the principal.  This property was added in __vSphere API 9.0.0.0__. | 
**Domain** | **string** | The domain name which this principal belongs to.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, &#39;localos&#39; domain is assumed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

