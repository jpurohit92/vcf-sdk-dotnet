# Vcenter.Automation.OpenApi.Model.VcenterDeploymentUpgradeSourceApplianceSpec
This schema is deprecated as of __vSphere API 9.0.0.0__.  The Vcenter.Deployment.Upgrade.SourceApplianceSpec schema contains information used to connect to the appliance used as the source for an upgrade.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  The IP address or DNS resolvable name of the source appliance.  This property was added in __vSphere API 6.7__. | 
**HttpsPort** | **long** | This property is deprecated as of __vSphere API 9.0.0.0__.  The HTTPS port of the source appliance.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, port 443 will be used. | [optional] 
**SslThumbprint** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  SHA1 thumbprint of the server SSL certificate will be used for verification.  This property was added in __vSphere API 6.7__.  This property is only relevant if ssl_verify is missing or &#x60;null&#x60; or has the value true. | [optional] 
**SslCertificate** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  The SSL Certificate of the server that will be used for verification. The value should be a single x509 certificate encoded in PEM format.  This property was added in __vSphere API 9.0.0.0__.  This property is only relevant if ssl_verify is missing or &#x60;null&#x60; or has the value true. | [optional] 
**SslVerify** | **bool** | This property is deprecated as of __vSphere API 9.0.0.0__.  SSL verification should be enabled or disabled for the source appliance validations. By default it is enabled and will use SSL certificate for verification. If thumbprint is provided, will use thumbprint for the verification.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, ssl_verify true will be used. | [optional] 
**SsoAdminUsername** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  The SSO administrator account on the source appliance.  This property was added in __vSphere API 6.7__. | 
**SsoAdminPassword** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  The SSO administrator account password.  This property was added in __vSphere API 6.7__. | 
**RootPassword** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  The password of the root user on the source appliance.  This property was added in __vSphere API 6.7__. | 
**SshVerify** | **bool** | This property is deprecated as of __vSphere API 9.0.0.0__.  Appliance SSH verification should be enabled or disabled. By default it is disabled and will not use any verification. If thumbprint is provided, thumbprint verification will be performed.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, ssh_verify true will be used. | [optional] 
**SshThumbprint** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  MD5 thumbprint of the server SSH key will be used for verification.  This property was added in __vSphere API 6.7__.  This property is only relevant if ssh_verify is missing or &#x60;null&#x60; or has the value true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

