# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerKmsProvidersImportResult
The Vcenter.CryptoManager.Kms.Providers.ImportResult schema contains result of the *POST /vcenter/crypto-manager/kms/providers?action=import* operation.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | Provider identifier  This property was added in __vSphere API 7.0.2.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.crypto_manager.kms.provider&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.crypto_manager.kms.provider&#x60;. | 
**Type** | **string** | Provider type  Possible values:   - &#x60;NATIVE&#x60;: Native provider   For more information see: *Vcenter.CryptoManager.Kms.Providers.Type*.  This property was added in __vSphere API 7.0.2.0__. | 
**NativeInfo** | [**VcenterCryptoManagerKmsProvidersNativeProviderInfo**](VcenterCryptoManagerKmsProvidersNativeProviderInfo.md) | Native provider information  This property was added in __vSphere API 7.0.2.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.CryptoManager.Kms.Providers.Type.NATIVE*. | [optional] 
**ExportTime** | **DateTime** | Time when the provider was exported  This property was added in __vSphere API 7.0.2.0__. | 
**Constraints** | [**VcenterCryptoManagerKmsProvidersConstraints**](VcenterCryptoManagerKmsProvidersConstraints.md) | The constraints on the provider.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, there are no constraints on the provider. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

