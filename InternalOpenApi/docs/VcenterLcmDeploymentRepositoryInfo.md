# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentRepositoryInfo
The Vcenter.Lcm.Deployment.Repository.Info schema contains the repository configuration information.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | The address of the repository.  This property was added in __vSphere API 9.0.0.0__. | 
**Username** | **string** | The username used to authenticate with the repository,  This property was added in __vSphere API 9.0.0.0__.  Only set, when the repository requires authentication. | [optional] 
**SslVerify** | **bool** | A flag to indicate whether SSL verification is required for the Repository location.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; defaults to True | [optional] 
**Certificate** | **string** | Certificate to verify the SSL Repository location. The value should be the x509 leaf certificate encoded in PEM format.     - If ssl_verify is true and this field is omitted, a CA based validation will be used.    - If ssl_verify is true and this field is provided, it will be used for SSL validation.    This property was added in __vSphere API 9.1.0.0__.  If set will be used for SSL validation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

