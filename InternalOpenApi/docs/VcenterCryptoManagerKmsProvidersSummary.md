# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerKmsProvidersSummary
The Vcenter.CryptoManager.Kms.Providers.Summary schema contains properties that describe a provider.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | Provider identifier  This property was added in __vSphere API 7.0.2.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.crypto_manager.kms.provider&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.crypto_manager.kms.provider&#x60;. | 
**Type** | **string** | Provider type  Possible values:   - &#x60;NATIVE&#x60;: Native provider   For more information see: *Vcenter.CryptoManager.Kms.Providers.Type*.  This property was added in __vSphere API 7.0.2.0__. | 
**Health** | **string** | Health status of the provider  Possible values:   - &#x60;NONE&#x60;: No health status is available.   - &#x60;OK&#x60;: Operating normally.   - &#x60;WARNING&#x60;: Operating normally, but there is an issue that requires attention.   - &#x60;ERROR&#x60;: There is a critical issue that requires attention.   For more information see: *Vcenter.CryptoManager.Kms.Providers.Health*.  This property was added in __vSphere API 7.0.2.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

