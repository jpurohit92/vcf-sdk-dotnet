# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerKmsProvidersNativeProviderUpdateSpec
The Vcenter.CryptoManager.Kms.Providers.NativeProviderUpdateSpec schema contains properties that describe the desired configuration for *Vcenter.CryptoManager.Kms.Providers.Type.NATIVE* provider. Exporting a *Vcenter.CryptoManager.Kms.Providers.Type.NATIVE* provider to create a new back-up is suggested after any update.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyId** | **string** | Key identifier for the provider.    The key identifier is required to be a 128-bit UUID represented as a hexadecimal string in \&quot;12345678-abcd-1234-cdef-123456789abc\&quot; format.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, the key identifier will remain unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

