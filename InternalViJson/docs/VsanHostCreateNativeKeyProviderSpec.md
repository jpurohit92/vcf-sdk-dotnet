# Vcenter.ViJson.OpenApi.Model.VsanHostCreateNativeKeyProviderSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | Provider identifier.  A unique string provided by the client.  | 
**KeyId** | **string** | Key identifier for the provider.  The key identifier is required to be a 128-bit UUID represented as a hexadecimal string in \&quot;12345678-abcd-1234-cdef-123456789abc\&quot; format. If unset, the key identifier will be generated automatically.  | [optional] 
**KeyDerivationKey** | **string** | Key used to derive data encryption keys.  Base64 encoded. If unset, the key derivation key will be generated automatically.  | [optional] 
**TpmRequired** | **bool** | TPM Required or Not.  When TPM is required, user won&#39;t be able to create native key provider on hosts without TPM. If unset, there&#39;s no TPM constraints on host.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

