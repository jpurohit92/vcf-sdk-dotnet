# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerHostsKmsProvidersInfo
The Vcenter.CryptoManager.Hosts.Kms.Providers.Info schema contains properties that describe the details of a provider.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Health** | **string** | Health status of the provider  Possible values:   - &#x60;NONE&#x60;: No health status is available.   - &#x60;OK&#x60;: Operating normally.   - &#x60;WARNING&#x60;: Operating normally, but there is an issue that requires attention.   - &#x60;ERROR&#x60;: There is a critical issue that requires attention.   For more information see: *Vcenter.CryptoManager.Hosts.Kms.Providers.Health*.  This property was added in __vSphere API 7.0.2.0__. | 
**Details** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Details regarding the health status of the provider.  This property was added in __vSphere API 7.0.2.0__.  When the provider Vcenter.CryptoManager.Hosts.Kms.Providers.Health is not *Vcenter.CryptoManager.Hosts.Kms.Providers.Health.OK* or *Vcenter.CryptoManager.Hosts.Kms.Providers.Health.NONE*, this property will provide actionable descriptions of the issues. | 
**Type** | **string** | Provider type  Possible values:   - &#x60;NATIVE&#x60;: Native provider   - &#x60;TRUST_AUTHORITY&#x60;: Trust Authority provider   For more information see: *Vcenter.CryptoManager.Hosts.Kms.Providers.Type*.  This property was added in __vSphere API 7.0.2.0__. | 
**NativeInfo** | [**VcenterCryptoManagerHostsKmsProvidersNativeProviderInfo**](VcenterCryptoManagerHostsKmsProvidersNativeProviderInfo.md) | Native provider information  This property was added in __vSphere API 7.0.2.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.CryptoManager.Hosts.Kms.Providers.Type.NATIVE*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

