# Vcenter.Automation.OpenApi.Model.VcenterDeploymentMigrateMigrationAssistantSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.Deployment.Migrate.MigrationAssistantSpec schema contains the information needed to connect to the Migration Assistant that is running on the source windows vCenter Server machine.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HttpsPort** | **long** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The HTTPS port being used by Migration Assistant.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, port 9123 will be used. | [optional] 
**SslThumbprint** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  SHA1 thumbprint of the Migration Assistant SSL certificate that will be used for verification.  This property was added in __vSphere API 7.0.0.0__. | 
**SslCertificate** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The SSL Certificate of the server that will be used for verification. The value should be a single x509 certificate encoded in PEM format.  This property was added in __vSphere API 9.0.0.0__.  This property is only relevant if sslVerify is missing or &#x60;null&#x60; or has the value true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

