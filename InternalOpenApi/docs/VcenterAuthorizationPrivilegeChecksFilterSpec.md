# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPrivilegeChecksFilterSpec
The Vcenter.Authorization.PrivilegeChecks.FilterSpec schema contains properties based on which privilege checks can be filtered. Any privilege check matching at least one of the conditions is returned.  This schema was added in __vSphere API 8.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Objects** | [**List&lt;VapiStdDynamicID&gt;**](VapiStdDynamicID.md) | IDs of the objects on which the privilege check was performed.  This property was added in __vSphere API 8.0.0.0__.  If missing or &#x60;null&#x60; all objects match. | [optional] 
**Sessions** | **List&lt;string&gt;** | Sessions for which the check was performed.  This property was added in __vSphere API 8.0.0.0__.  If missing or &#x60;null&#x60; all sessions match. | [optional] 
**Principals** | [**List&lt;VcenterAuthorizationPrivilegeChecksPrincipal&gt;**](VcenterAuthorizationPrivilegeChecksPrincipal.md) | Principles for which the privilege check was performed. The missing or &#x60;null&#x60; Vcenter.Authorization.PrivilegeChecks.Principal value matches privilege checks for anonymous sessions.  This property was added in __vSphere API 8.0.0.0__.  If missing or &#x60;null&#x60; all principles match. | [optional] 
**Privileges** | **List&lt;string&gt;** | Privileges that were checked.  This property was added in __vSphere API 8.0.0.0__.  If missing or &#x60;null&#x60; all privileges match.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.cis.authz.Privilege&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.cis.authz.Privilege&#x60;. | [optional] 
**OpIds** | **List&lt;string&gt;** | OpIDs of the requests for which the check was performed.  This property was added in __vSphere API 8.0.0.0__.  If missing or &#x60;null&#x60; all opIDs match. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

