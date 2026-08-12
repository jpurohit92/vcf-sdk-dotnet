# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsIdentityDomainsInfo
The Vcenter.NamespaceManagement.Supervisors.Identity.Domains.Info schema provides details about an OIDC domain configured with a Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** | The immutable identifier of an identity domain generated when an federation domain is registered for a Supervisor.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.identity.domain&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.identity.domain&#x60;. | 
**DisplayName** | **string** | A name to be used for the given identity domain. This name will be displayed in the vCenter UI.  This property was added in __vSphere API 9.0.0.0__. | 
**CallbackUrl** | **string** | The URL used by the Identity Provider to redirect users back to the Supervisor after authentication. This URL will be used in the registration of the Supervisor with the Identity Provider to act as an OAuth 2.0 client.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

