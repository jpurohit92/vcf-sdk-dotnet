# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerKmsProvidersToken
The Vcenter.CryptoManager.Kms.Providers.Token schema contains information about the token required to be passed in the HTTP header in the HTTP GET request to download the provider configuration.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Token** | **string** | A one-time, short-lived token required in \&quot;Authorization\&quot; field of the HTTP header of the request to the url.    After the token expires, any attempt to download the configuration with said token will fail.  This property was added in __vSphere API 7.0.2.0__. | 
**Expiry** | **DateTime** | Expiry time of the token  This property was added in __vSphere API 7.0.2.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

