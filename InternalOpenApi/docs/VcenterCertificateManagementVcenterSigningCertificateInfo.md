# Vcenter.Automation.OpenApi.Model.VcenterCertificateManagementVcenterSigningCertificateInfo
The Vcenter.CertificateManagement.Vcenter.SigningCertificate.Info schema contains data that represents vCenter signing certificates.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveCertChain** | [**VcenterCertificateManagementX509CertChain**](VcenterCertificateManagementX509CertChain.md) | The certificate chain that is actively being use by vCenter token service to sign tokens.  This property was added in __vSphere API 7.0.3.0__. | 
**SigningCertChains** | [**List&lt;VcenterCertificateManagementX509CertChain&gt;**](VcenterCertificateManagementX509CertChain.md) | List of signing certificate chains for validating vCenter-issued tokens. The list contains X509 certificate chains, each of which is ordered and contains the leaf, intermediate and root certs needed for the complete chain of trust. The leaf certificate is first in the chain and should be used for verifying vCenter-issued tokens.  This property was added in __vSphere API 7.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

