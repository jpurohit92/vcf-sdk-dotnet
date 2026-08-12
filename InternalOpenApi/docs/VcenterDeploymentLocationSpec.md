# Vcenter.Automation.OpenApi.Model.VcenterDeploymentLocationSpec
The Vcenter.Deployment.LocationSpec schema is used to pass the container ESXi or vCenter server of the VM to patch the size of this appliance.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The IP address or DNS resolvable name of the container.  This property was added in __vSphere API 6.7__. | 
**HttpsPort** | **long** | The HTTPS port of the container.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, port 443 will be used. | [optional] 
**SslThumbprint** | **string** | SHA1 thumbprint of the server SSL certificate will be used for verification.  This property was added in __vSphere API 6.7__.  This property is only relevant if ssl_verify is missing or &#x60;null&#x60; or has the value true. | [optional] 
**SslCertificate** | **string** | The SSL Certificate of the server that will be used for verification. The value should be a single x509 certificate encoded in PEM format.  This property was added in __vSphere API 9.0.0.0__.  This property is only relevant if ssl_verify is missing or &#x60;null&#x60; or has the value true. | [optional] 
**SslVerify** | **bool** | SSL verification should be enabled or disabled. If ssl_verify is true and and ssl_thumbprint is missing or &#x60;null&#x60;, the CA certificate will be used for verification. If ssl_verify is true and ssl_thumbprint is set then the thumbprint will be used for verification. No verification will be performed if ssl_verify value is set to false.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, ssl_verify true will be used. | [optional] 
**Username** | **string** | The administrator account on the host.  This property was added in __vSphere API 6.7__. | 
**Password** | **string** | The administrator account password.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

