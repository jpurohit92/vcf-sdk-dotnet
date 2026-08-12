# Vcenter.Automation.OpenApi.Model.VcenterIdentityProvidersActiveDirectoryOverLdap
The Vcenter.Identity.Providers.ActiveDirectoryOverLdap schema contains the information about to how to use an Active Directory over LDAP connection to allow searching for users and groups if the identity provider is an On-Prem service.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserName** | **string** | User name to connect to the active directory server.  This property was added in __vSphere API 7.0.0.0__. | 
**Password** | **string** | Password to connect to the active directory server.  This property was added in __vSphere API 7.0.0.0__. | 
**UsersBaseDn** | **string** | Base distinguished name for users  This property was added in __vSphere API 7.0.0.0__. | 
**GroupsBaseDn** | **string** | Base distinguished name for groups  This property was added in __vSphere API 7.0.0.0__. | 
**ServerEndpoints** | **List&lt;string&gt;** | Active directory server endpoints. At least one active directory server endpoint must be set.  This property was added in __vSphere API 7.0.0.0__. | 
**CertChain** | [**VcenterCertificateManagementX509CertChain**](VcenterCertificateManagementX509CertChain.md) | SSL certificate chain in base64 encoding.  This property was added in __vSphere API 7.0.0.0__.  This property can be missing or &#x60;null&#x60; only, if all the active directory server endpoints use the LDAP (not LDAPS) protocol. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

