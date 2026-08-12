# Vcenter.ViJson.OpenApi.Model.GenerateKeyRequestType
The parameters of *CryptoManagerKmip.GenerateKey*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyProvider** | [**KeyProviderId**](KeyProviderId.md) | \\[in\\] Which provider will generate the key. If omitted, will use the default key provider.  | [optional] 
**Spec** | [**CryptoManagerKmipCustomAttributeSpec**](CryptoManagerKmipCustomAttributeSpec.md) | \\[in\\] The spec that contains custom attributes key/value pairs.  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 
**KeySpec** | [**CryptoManagerKmipGenerateKeySpec**](CryptoManagerKmipGenerateKeySpec.md) | \\[in\\] The keySpec that contains key generation options. If unset, key will be generated with default settings of the key provider.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

