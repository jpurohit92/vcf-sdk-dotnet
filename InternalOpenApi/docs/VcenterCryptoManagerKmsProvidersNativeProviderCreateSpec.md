# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerKmsProvidersNativeProviderCreateSpec
The Vcenter.CryptoManager.Kms.Providers.NativeProviderCreateSpec schema contains properties that describe the desired configuration for a *Vcenter.CryptoManager.Kms.Providers.Type.NATIVE* provider.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyId** | **string** | Key identifier for the provider.    The key identifier is required to be a 128-bit UUID represented as a hexadecimal string in \&quot;12345678-abcd-1234-cdef-123456789abc\&quot; format.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, the key identifier will be generated automatically. | [optional] 
**KeyDerivationKey** | **string** | Key used to derive data encryption keys. Base64 encoded.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, the key derivation key will be generated automatically. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

