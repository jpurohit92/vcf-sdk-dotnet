# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerKmsProvidersLocation
The Vcenter.CryptoManager.Kms.Providers.Location schema contains the location as well as a token required (as a header in the HTTP GET request) to download the configuration.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | Provider configuration download URL  This property was added in __vSphere API 7.0.2.0__. | 
**DownloadToken** | [**VcenterCryptoManagerKmsProvidersToken**](VcenterCryptoManagerKmsProvidersToken.md) | Information about the token required in the HTTP GET request to download the provider configuration.  This property was added in __vSphere API 7.0.2.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

