# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerKmsProvidersCreateSpec
The Vcenter.CryptoManager.Kms.Providers.CreateSpec schema contains properties that describe the desired configuration for a new provider.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | Provider identifier.    A unique string provided by the client.  This property was added in __vSphere API 7.0.2.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.crypto_manager.kms.provider&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.crypto_manager.kms.provider&#x60;. | 
**Constraints** | [**VcenterCryptoManagerKmsProvidersConstraintsSpec**](VcenterCryptoManagerKmsProvidersConstraintsSpec.md) | The constraints on the provider.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; there are no constraints on the provider. | [optional] 
**NativeSpec** | [**VcenterCryptoManagerKmsProvidersNativeProviderCreateSpec**](VcenterCryptoManagerKmsProvidersNativeProviderCreateSpec.md) | Native provider create spec.  This property was added in __vSphere API 7.0.2.0__.  This property is required when creating a *Vcenter.CryptoManager.Kms.Providers.Type.NATIVE* provider. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

