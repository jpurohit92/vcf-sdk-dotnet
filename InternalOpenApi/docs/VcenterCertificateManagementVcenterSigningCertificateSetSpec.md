# Vcenter.Automation.OpenApi.Model.VcenterCertificateManagementVcenterSigningCertificateSetSpec
The Vcenter.CertificateManagement.Vcenter.SigningCertificate.SetSpec schema contains data to set the active vCenter signing certificate.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SigningCertChain** | [**VcenterCertificateManagementX509CertChain**](VcenterCertificateManagementX509CertChain.md) | Signing certificate chain that the vCenter token service will actively use to sign tokens. The chain must include a valid certificate chain with the leaf cert marked for digital signature key usage.  This property was added in __vSphere API 7.0.3.0__. | 
**PrivateKey** | **string** | The corresponding unencrypted PKCS#8 private key in base64-encoded PEM format.  This property was added in __vSphere API 7.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

