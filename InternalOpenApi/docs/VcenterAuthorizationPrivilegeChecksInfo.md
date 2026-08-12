# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPrivilegeChecksInfo
The Vcenter.Authorization.PrivilegeChecks.Info schema contains detailed information about a privilege check.  This schema was added in __vSphere API 8.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | [**VapiStdDynamicID**](VapiStdDynamicID.md) | Object for which the privilege was checked.  This property was added in __vSphere API 8.0.0.0__. | 
**Principal** | [**VcenterAuthorizationPrivilegeChecksPrincipal**](VcenterAuthorizationPrivilegeChecksPrincipal.md) | Principal for which the privilege was checked. Note that the username and domain specified are case-insensitive.  This property was added in __vSphere API 8.0.0.0__.  If missing or &#x60;null&#x60; the privilege was checked for an unauthenticated session. | [optional] 
**Privilege** | **string** | Privilege that was checked.  This property was added in __vSphere API 8.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.authz.Privilege&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.authz.Privilege&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

