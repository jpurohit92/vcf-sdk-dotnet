# Vcenter.Automation.OpenApi.Model.VcenterServiceLocator
This data object type specifies the information of a service endpoint as well as the parameters needed to locate and login to to the service endpoint.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceUuid** | **string** | Unique ID of the instance to which the service belongs. For instances that support the vSphere API, this is the same as the value found in vim.AboutInfo#instanceUuid.  This property was added in __vSphere API 9.0.0.0__. | 
**Url** | **string** | URL used to access the service endpoint.  This property was added in __vSphere API 9.0.0.0__. | 
**Credential** | [**VcenterCredential**](VcenterCredential.md) | Credential to establish the connection and login to the service.  This property was added in __vSphere API 9.0.0.0__. | 
**SslThumbprint** | **string** | The sslThumbprint of the service endpoint. Superseded by *Vcenter.ServiceLocator.ssl_certificate*. Note: If both &#x60;sslThumbprint&#x60; and &#x60;sslCertificate&#x60; are set, &#x60;sslThumbprint&#x60; must correspond to the &#x60;sslCertificate&#x60;.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60;, then &#x60;sslCertificate&#x60; will be checked. If both these fields are missing or &#x60;null&#x60;, then thumbprint from first connection will be trusted. | [optional] 
**SslCertificate** | **string** | The SSL certificate of the service endpoint in PEM format. A replacement for *Vcenter.ServiceLocator.ssl_thumbprint*. Note: If both &#x60;sslThumbprint&#x60; and &#x60;sslCertificate&#x60; are set, &#x60;sslThumbprint&#x60; must correspond to the &#x60;sslCertificate&#x60;.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60;, then remote service endpoint certificate will not be verified upon connection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

