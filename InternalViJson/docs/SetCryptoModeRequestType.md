# Vcenter.ViJson.OpenApi.Model.SetCryptoModeRequestType
The parameters of *ClusterComputeResource.SetCryptoMode*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CryptoMode** | **string** | The encryption mode for the cluster. See *ClusterCryptoConfigInfoCryptoMode_enum* for supported values. An empty string is treated as a valid input and will be interpreted as *onDemand*.  | 
**Policy** | [**ClusterComputeResourceCryptoModePolicy**](ClusterComputeResourceCryptoModePolicy.md) | The encryption mode policy for the cluster. When no policy is specified, host keys will be automatically generated using the current default key provider.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

