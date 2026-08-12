# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsIdentityProvidersSummary
The Vcenter.NamespaceManagement.Supervisors.Identity.Providers.Summary schema provides an overview of an identity provider configured for the given Supervisor.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | The immutable identifier of an identity provider generated when an identity provider is registered for a Supervisor.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.identity.Provider&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.identity.Provider&#x60;. | 
**DisplayName** | **string** | A name to be used for the given identity provider. This name will be displayed in the vCenter UI.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

