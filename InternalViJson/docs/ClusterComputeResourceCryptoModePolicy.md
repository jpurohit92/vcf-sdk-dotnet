# Vcenter.ViJson.OpenApi.Model.ClusterComputeResourceCryptoModePolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyId** | [**CryptoKeyId**](CryptoKeyId.md) | The host key identifier.  When set, all hosts in the cluster will use this key when enabling the crypto safe mode. Only one of *ClusterComputeResourceCryptoModePolicy.keyId* and *ClusterComputeResourceCryptoModePolicy.providerId* may be set.  | [optional] 
**ProviderId** | [**KeyProviderId**](KeyProviderId.md) | The host key provider identifier.  When set, all hosts in the cluster will use a key from the specified key provider when enabling the crypto safe mode. Only one of *ClusterComputeResourceCryptoModePolicy.keyId* and *ClusterComputeResourceCryptoModePolicy.providerId* may be set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

