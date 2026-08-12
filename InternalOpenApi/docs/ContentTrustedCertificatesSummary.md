# Vcenter.Automation.OpenApi.Model.ContentTrustedCertificatesSummary
The Content.TrustedCertificates.Summary schema contains a trusted certificate summary.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Certificate** | **string** | Unique identifier for the certificate. It is the TrustStore alias of the certificate. The alias is the SHA256 hash of the raw certificate data.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.TrustedCertificate&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.TrustedCertificate&#x60;. | 
**CertText** | **string** | Certificate in Base64 encoded PEM format..  This property was added in __vSphere API 7.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

