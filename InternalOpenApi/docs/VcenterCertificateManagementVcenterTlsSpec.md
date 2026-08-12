# Vcenter.Automation.OpenApi.Model.VcenterCertificateManagementVcenterTlsSpec
The Vcenter.CertificateManagement.Vcenter.Tls.Spec schema contains information for a Certificate and Private Key.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cert** | **string** | Certificate string in PEM format.  This property was added in __vSphere API 6.7.2__. | 
**Key** | **string** | Private key string in PEM format.  This property was added in __vSphere API 6.7.2__.  If missing or &#x60;null&#x60; the private key from the certificate store will be used. It is required when replacing the certificate with a third party signed certificate. | [optional] 
**RootCert** | **string** | Third party Root CA certificate in PEM format.  This property was added in __vSphere API 6.9.1__.  If missing or &#x60;null&#x60; the new third party root CA certificate will not be added to the trust store. It is required when replacing the certificate with a third party signed certificate if the root certificate of the third party is not already a trusted root. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

