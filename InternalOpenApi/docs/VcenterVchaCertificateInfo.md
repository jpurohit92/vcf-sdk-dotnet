# Vcenter.Automation.OpenApi.Model.VcenterVchaCertificateInfo
The Vcenter.Vcha.CertificateInfo Schema contains information about the SSL certificate for a management vCenter server.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SslThumbprint** | **string** | The SHA-256 thumbprint of the SSL certificate for a management vCenter server.  This property was added in __vSphere API 6.7.1__. | 
**SslCertificate** | **string** | PEM-encoded SSL certificate of the management vCenter server.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, empty ssl certificate is assumed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

