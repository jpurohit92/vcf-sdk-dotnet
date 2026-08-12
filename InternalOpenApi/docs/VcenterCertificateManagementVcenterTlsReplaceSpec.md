# Vcenter.Automation.OpenApi.Model.VcenterCertificateManagementVcenterTlsReplaceSpec
The Vcenter.CertificateManagement.Vcenter.Tls.ReplaceSpec schema contains information to generate a Private Key , CSR and hence VMCA signed machine SSL.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeySize** | **long** | The size of the key to be used for public and private key generation.  This property was added in __vSphere API 6.7.2__.  If missing or &#x60;null&#x60; the key size will be &#39;3072&#39;. | [optional] 
**CommonName** | **string** | The common name of the host for which certificate is generated  This property was added in __vSphere API 6.7.2__.  If missing or &#x60;null&#x60; will default to PNID of host. | [optional] 
**Organization** | **string** | Organization field in certificate subject  This property was added in __vSphere API 6.7.2__. | 
**OrganizationUnit** | **string** | Organization unit field in certificate subject.    CA Browser forum announced that \&quot;CAs MUST NOT include the organizationalUnitName field\&quot;. So OU is no longer needed and an empty string should be used to leave it unset.  This property was added in __vSphere API 6.7.2__. | 
**Locality** | **string** | Locality field in certificate subject  This property was added in __vSphere API 6.7.2__. | 
**StateOrProvince** | **string** | State field in certificate subject  This property was added in __vSphere API 6.7.2__. | 
**Country** | **string** | Country field in certificate subject  This property was added in __vSphere API 6.7.2__. | 
**EmailAddress** | **string** | Email field in Certificate extensions  This property was added in __vSphere API 6.7.2__. | 
**SubjectAltName** | **List&lt;string&gt;** | SubjectAltName is list of Dns Names and Ip addresses  This property was added in __vSphere API 6.7.2__.  If missing or &#x60;null&#x60; PNID of host will be used as IPAddress or Hostname for certificate generation . | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

