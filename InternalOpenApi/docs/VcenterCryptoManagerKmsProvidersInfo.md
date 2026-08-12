# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerKmsProvidersInfo
The Vcenter.CryptoManager.Kms.Providers.Info schema contains properties that describe the details of a provider.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Health** | **string** | Health status of the provider  Possible values:   - &#x60;NONE&#x60;: No health status is available.   - &#x60;OK&#x60;: Operating normally.   - &#x60;WARNING&#x60;: Operating normally, but there is an issue that requires attention.   - &#x60;ERROR&#x60;: There is a critical issue that requires attention.   For more information see: *Vcenter.CryptoManager.Kms.Providers.Health*.  This property was added in __vSphere API 7.0.2.0__. | 
**Details** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Details regarding the health status of the provider.    When the provider Vcenter.CryptoManager.Kms.Providers.Health is not *Vcenter.CryptoManager.Kms.Providers.Health.NONE* or *Vcenter.CryptoManager.Kms.Providers.Health.OK*, this property will provide actionable descriptions of the issues.  This property was added in __vSphere API 7.0.2.0__. | 
**Constraints** | [**VcenterCryptoManagerKmsProvidersConstraints**](VcenterCryptoManagerKmsProvidersConstraints.md) | The constraints on the provider.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, there are no constraints on the provider. | [optional] 
**Type** | **string** | Provider type  Possible values:   - &#x60;NATIVE&#x60;: Native provider   For more information see: *Vcenter.CryptoManager.Kms.Providers.Type*.  This property was added in __vSphere API 7.0.2.0__. | 
**NativeInfo** | [**VcenterCryptoManagerKmsProvidersNativeProviderInfo**](VcenterCryptoManagerKmsProvidersNativeProviderInfo.md) | Native provider information  This property was added in __vSphere API 7.0.2.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.CryptoManager.Kms.Providers.Type.NATIVE*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

