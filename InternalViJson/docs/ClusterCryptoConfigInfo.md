# Vcenter.ViJson.OpenApi.Model.ClusterCryptoConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CryptoMode** | **string** | The cluster encryption mode.  See *ClusterCryptoConfigInfoCryptoMode_enum* for supported values.  | [optional] 
**Policy** | [**ClusterComputeResourceCryptoModePolicy**](ClusterComputeResourceCryptoModePolicy.md) | The encryption mode policy for the cluster.  When unset, host keys will be automatically generated using the current default key provider.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

