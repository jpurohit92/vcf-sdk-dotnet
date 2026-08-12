# Vcenter.Automation.OpenApi.Model.VcenterVchaConnectionSpec
The Vcenter.Vcha.ConnectionSpec schema contains information required to connect to a vCenter server. The connection to the vCenter server always uses the HTTPS protocol.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | IP Address or DNS of the vCenter.  This property was added in __vSphere API 6.7.1__. | 
**Port** | **long** | Port number.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, port 443 will be used. | [optional] 
**SslThumbprint** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__. this property is deprecated please use sslCertificate instead.  SHA1 hash of the server SSL certificate.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, empty ssl thumbprint is assumed. | [optional] 
**SslCertificate** | **string** | PEM-encoded server SSL certificate of vCenter. Note: &#x60;sslThumbprint&#x60; and &#x60;sslCertificate&#x60; parameters are mutually exclusive, and should never be used simultaneously.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, empty ssl certificate is assumed. | [optional] 
**Username** | **string** | Username to access the server.  This property was added in __vSphere API 6.7.1__.  This property is currently required. If missing or &#x60;null&#x60;, an error is returned. In the future, if this property is missing or &#x60;null&#x60;, the system will attempt to identify the user. If a user cannot be identified, then the requested operation will fail. | [optional] 
**Password** | **string** | Password for the specified user.  This property was added in __vSphere API 6.7.1__.  This property is currently required. If missing or &#x60;null&#x60;, an empty password is assumed. In the future, if this property is missing or &#x60;null&#x60;, the system will attempt to authenticate the user. If a user cannot be identified, then the requested operation will fail. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

