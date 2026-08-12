# Vcenter.Automation.OpenApi.Model.VcenterCertificateManagementVcenterVmcaRootCreateSpec
The Vcenter.CertificateManagement.Vcenter.VmcaRoot.CreateSpec contains information. to generate a Private Key and CSR.  This schema was added in __vSphere API 6.9.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeySize** | **long** | The size of the key to be used for public and private key generation.  This property was added in __vSphere API 6.9.1__.  If missing or &#x60;null&#x60; the key size will be 3072. | [optional] 
**CommonName** | **string** | The common name of the host for which certificate is generated.  This property was added in __vSphere API 6.9.1__.  If missing or &#x60;null&#x60; the common name will be the primary network identifier (PNID) of the vCenter Virtual Server Appliance (VCSA). | [optional] 
**Organization** | **string** | Organization field in certificate subject.  This property was added in __vSphere API 6.9.1__.  If missing or &#x60;null&#x60; the organization will be &#39;VMware&#39;. | [optional] 
**OrganizationUnit** | **string** | Organization unit field in certificate subject.  This property was added in __vSphere API 6.9.1__.  If missing or &#x60;null&#x60; the organization unit will not be set in the certificate subject. | [optional] 
**Locality** | **string** | Locality field in certificate subject.  This property was added in __vSphere API 6.9.1__.  If missing or &#x60;null&#x60; the locality will be &#39;Palo Alto&#39;. | [optional] 
**StateOrProvince** | **string** | State field in certificate subject.  This property was added in __vSphere API 6.9.1__.  If missing or &#x60;null&#x60; the state will be &#39;California&#39;. | [optional] 
**Country** | **string** | Country field in certificate subject.  This property was added in __vSphere API 6.9.1__.  If missing or &#x60;null&#x60; the country will be &#39;US&#39;. | [optional] 
**EmailAddress** | **string** | Email field in Certificate extensions.  This property was added in __vSphere API 6.9.1__.  If missing or &#x60;null&#x60; the emailAddress will be &#39;email@acme.com&#39;. | [optional] 
**SubjectAltName** | **List&lt;string&gt;** | SubjectAltName is list of Dns Names and Ip addresses.  This property was added in __vSphere API 6.9.1__.  If missing or &#x60;null&#x60; PNID of host will be used as IPAddress or Hostname for certificate generation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

