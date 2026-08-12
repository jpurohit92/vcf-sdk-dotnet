# Vcenter.ViJson.OpenApi.Model.SetDefaultKmsClusterRequestType
The parameters of *CryptoManagerKmip.SetDefaultKmsCluster*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | \\[in\\] The managed entity where the default KMS cluster to be set. Currently the valid managed entity could be cluster or host folder. If omitted, then will set global default KMS cluster.  Refers instance of *ManagedEntity*.  | [optional] 
**ClusterId** | [**KeyProviderId**](KeyProviderId.md) | \\[in\\] KMS cluster ID to become default. If omitted, then will clear the default KMS cluster setting.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

