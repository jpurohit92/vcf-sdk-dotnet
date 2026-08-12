# Vcenter.Automation.OpenApi.Model.VcenterNamespacesAccessCreateSpec
The Vcenter.Namespaces.Access.CreateSpec schema contains the specification required to create access control on the namespace.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Role** | **string** | Role to be assigned.  Possible values:   - &#x60;OWNER&#x60;: This role allows modification and deletion of the namespace.  This constant was added in __vSphere API 7.0.2.00100__.   - &#x60;EDIT&#x60;: This role allows modification of the namespace.   - &#x60;VIEW&#x60;: This is a read-only role on the namespace.   For more information see: *Vcenter.Namespaces.Access.Role*.  This property was added in __vSphere API 7.0.0.0__. | 
**IdentityProvider** | **string** | UUID of an external identity provider for the user, if any. Use this field if the user is coming from an external identity provider configured via the *Vcenter.NamespaceManagement.Supervisors.Identity.Providers* service.  This property was added in __vSphere API 8.0.0.1__.  If unset, vCenter Single Sign-On will be used as the identity provider.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.identity.Provider&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.identity.Provider&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

