# Vcenter.Automation.OpenApi.Model.VcenterDeploymentReplicatedPscSpec
The Vcenter.Deployment.ReplicatedPscSpec schema contains information used to check if the configuring PSC can be replicated to the remote PSC.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SsoSiteName** | **string** | The SSO sitename that will be used in PSC replication.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, default-first-site will be used. | [optional] 
**PartnerHostname** | **string** | The IP address or DNS resolvable name of the partner PSC appliance.  This property was added in __vSphere API 6.7__. | 
**HttpsPort** | **long** | The HTTPS port of the external PSC appliance.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, port 443 will be used. | [optional] 
**SsoAdminPassword** | **string** | The SSO administrator account password.  This property was added in __vSphere API 6.7__. | 
**SslThumbprint** | **string** | SHA1 thumbprint of the server SSL certificate will be used for verification.  This property was added in __vSphere API 6.7__.  This property is only relevant if ssl_verify is missing or &#x60;null&#x60; or has the value true. | [optional] 
**SslCertificate** | **string** | The SSL Certificate of the server that will be used for verification. The value should be a single x509 certificate encoded in PEM format. Note: &#x60;sslThumbprint&#x60; and &#x60;sslCertificate&#x60; parameters are mutually exclusive, and should never be used simultaneously.  This property was added in __vSphere API 9.0.0.0__.  This property is only relevant if ssl_verify is missing or &#x60;null&#x60; or has the value true. | [optional] 
**SslVerify** | **bool** | SSL verification should be enabled or disabled.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, ssl_verify true will be used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

